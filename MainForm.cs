using System;
using System.Windows.Forms;
using CreatureXmlEditor.Models;
using CreatureXmlEditor.Utilities;

namespace CreatureXmlEditor
{
    public partial class MainForm : Form
    {
        private Creature creature;
        private string currentFilePath = "";
        private bool isModified = false;

        public MainForm()
        {
            InitializeComponent();
            creature = new Creature();
            LoadCreatureToForm();
        }

        private void LoadCreatureToForm()
        {
            // Basic Info
            txtCreatureName.Text = creature.Name;
            txtCategory.Text = creature.Category;

            // Level Statistics
            numAverageLevel.Value = creature.LevelStatistics.AverageLevel;

            // Movement Statistics
            numBaseMovement.Value = creature.MovementStatistics.BaseMovement;
            numAttackQuickness.Value = creature.MovementStatistics.AttackQuickness;

            // Combat Statistics
            numArmorType.Value = creature.CombatStatistics.ArmorType;
            numDefensiveBonus.Value = creature.CombatStatistics.DefensiveBonus;
            numBaseHits.Value = creature.CombatStatistics.BaseHits;

            // Load lists
            LoadDefensiveModifications();
            LoadResistanceRollBonuses();
            LoadAttacks();
            LoadSkills();

            // Description
            txtDescription.Text = creature.Description;

            isModified = false;
            UpdateTitle();
        }

        private void LoadDefensiveModifications()
        {
            lstDefensiveModifications.Items.Clear();
            foreach (var mod in creature.CombatStatistics.DefensiveModifications.Modifications)
            {
                lstDefensiveModifications.Items.Add(mod);
            }
        }

        private void LoadResistanceRollBonuses()
        {
            lstResistanceRollBonuses.Items.Clear();
            foreach (var bonus in creature.CombatStatistics.ResistanceRollBonuses.Bonuses)
            {
                lstResistanceRollBonuses.Items.Add(bonus);
            }
        }

        private void LoadAttacks()
        {
            lstAttacks.Items.Clear();
            foreach (var attack in creature.CombatStatistics.Attacks.AttackList)
            {
                lstAttacks.Items.Add(attack);
            }
        }

        private void LoadSkills()
        {
            lstSkills.Items.Clear();
            foreach (var skill in creature.ManeuverSkills.Skills)
            {
                lstSkills.Items.Add(skill);
            }
        }

        private void SaveFormToCreature()
        {
            // Basic Info
            creature.Name = txtCreatureName.Text;
            creature.Category = txtCategory.Text;

            // Level Statistics
            creature.LevelStatistics.AverageLevel = (int)numAverageLevel.Value;

            // Movement Statistics
            creature.MovementStatistics.BaseMovement = (int)numBaseMovement.Value;
            creature.MovementStatistics.AttackQuickness = (int)numAttackQuickness.Value;

            // Combat Statistics
            creature.CombatStatistics.ArmorType = (int)numArmorType.Value;
            creature.CombatStatistics.DefensiveBonus = (int)numDefensiveBonus.Value;
            creature.CombatStatistics.BaseHits = (int)numBaseHits.Value;

            // Description
            creature.Description = txtDescription.Text;
        }

        private void UpdateTitle()
        {
            string modified = isModified ? " *" : "";
            string fileName = string.IsNullOrEmpty(currentFilePath) ? "New Creature" : System.IO.Path.GetFileName(currentFilePath);
            this.Text = $"Creature XML Editor - {fileName}{modified}";
        }

        // Event Handlers
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save before closing?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveCreature();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(
                    "Create a new creature? Unsaved changes will be lost.",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;
            }

            creature = new Creature();
            currentFilePath = "";
            LoadCreatureToForm();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|Creature Files (*.creature.xml)|*.creature.xml|All Files (*.*)|*.*",
                Title = "Open Creature File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    creature = XmlHelper.LoadFromFile(openFileDialog.FileName);
                    currentFilePath = openFileDialog.FileName;
                    LoadCreatureToForm();
                    MessageBox.Show("File loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveCreature();
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Creature XML Files (*.creature.xml)|*.creature.xml|XML Files (*.xml)|*.xml",
                Title = "Save Creature File",
                FileName = creature.Name.Replace(" ", "_") + ".creature.xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                SaveCreature();
            }
        }

        private void SaveCreature()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show("Please use 'Save As' to specify a file location.", "No File Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnSaveAs_Click(null, null);
                return;
            }

            try
            {
                SaveFormToCreature();
                XmlHelper.SaveToFile(creature, currentFilePath);
                isModified = false;
                UpdateTitle();
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Text changed handlers
        private void TextChanged_Handler(object sender, EventArgs e)
        {
            isModified = true;
            UpdateTitle();
        }

        private void NumericChanged_Handler(object sender, EventArgs e)
        {
            isModified = true;
            UpdateTitle();
        }

        // Defensive Modifications
        private void btnAddDefensiveModification_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDefModConcept.Text))
            {
                MessageBox.Show("Please enter a concept.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mod = new DefensiveModification((int)numDefModBonus.Value, txtDefModConcept.Text);
            creature.CombatStatistics.DefensiveModifications.Modifications.Add(mod);
            LoadDefensiveModifications();

            txtDefModConcept.Clear();
            numDefModBonus.Value = 0;
            isModified = true;
            UpdateTitle();
        }

        private void BtnRemoveDefensiveModification_Click(object sender, EventArgs e)
        {
            if (lstDefensiveModifications.SelectedIndex >= 0)
            {
                creature.CombatStatistics.DefensiveModifications.Modifications.RemoveAt(lstDefensiveModifications.SelectedIndex);
                LoadDefensiveModifications();
                isModified = true;
                UpdateTitle();
            }
        }

        // Resistance Roll Bonuses
        private void BtnAddResistanceRollBonus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResistConcept.Text))
            {
                MessageBox.Show("Please enter a concept.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bonus = new ResistanceRollBonus(txtResistConcept.Text, (int)numResistBonus.Value);
            creature.CombatStatistics.ResistanceRollBonuses.Bonuses.Add(bonus);
            LoadResistanceRollBonuses();

            txtResistConcept.Clear();
            numResistBonus.Value = 0;
            isModified = true;
            UpdateTitle();
        }

        private void BtnRemoveResistanceRollBonus_Click(object sender, EventArgs e)
        {
            if (lstResistanceRollBonuses.SelectedIndex >= 0)
            {
                creature.CombatStatistics.ResistanceRollBonuses.Bonuses.RemoveAt(lstResistanceRollBonuses.SelectedIndex);
                LoadResistanceRollBonuses();
                isModified = true;
                UpdateTitle();
            }
        }

        // Attacks
        private void BtnAddAttack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAttackName.Text) || string.IsNullOrWhiteSpace(txtAttackTableName.Text))
            {
                MessageBox.Show("Please enter both attack name and table name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var attack = new Attack((int)numAttackBonus.Value, txtAttackTableName.Text, txtAttackName.Text, (int)numAttackSizeAdj.Value);
            creature.CombatStatistics.Attacks.AttackList.Add(attack);
            LoadAttacks();

            txtAttackName.Clear();
            txtAttackTableName.Clear();
            numAttackBonus.Value = 0;
            numAttackSizeAdj.Value = 0;
            isModified = true;
            UpdateTitle();
        }

        private void BtnRemoveAttack_Click(object sender, EventArgs e)
        {
            if (lstAttacks.SelectedIndex >= 0)
            {
                creature.CombatStatistics.Attacks.AttackList.RemoveAt(lstAttacks.SelectedIndex);
                LoadAttacks();
                isModified = true;
                UpdateTitle();
            }
        }

        // Skills
        private void BtnAddSkill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSkillName.Text) || string.IsNullOrWhiteSpace(txtSkillTableName.Text))
            {
                MessageBox.Show("Please enter both skill name and table name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var skill = new Skill(txtSkillName.Text, txtSkillTableName.Text, (int)numSkillRanks.Value, (int)numSkillBonus.Value);
            creature.ManeuverSkills.Skills.Add(skill);
            LoadSkills();

            txtSkillName.Clear();
            txtSkillTableName.Clear();
            numSkillRanks.Value = 0;
            numSkillBonus.Value = 0;
            isModified = true;
            UpdateTitle();
        }

        private void BtnRemoveSkill_Click(object sender, EventArgs e)
        {
            if (lstSkills.SelectedIndex >= 0)
            {
                creature.ManeuverSkills.Skills.RemoveAt(lstSkills.SelectedIndex);
                LoadSkills();
                isModified = true;
                UpdateTitle();
            }
        }
    }
}