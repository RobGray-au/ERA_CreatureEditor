using CreatureXmlEditor.Models;
using CreatureXmlEditor.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatureXmlEditor
{
    public partial class CreatureEditForm : Form
    {
        private Creature creature;
        private string currentFilePath = "";
        private bool isModified = false;
        public List<ResistanceType> ResistanceList;
        public List<AttackType> AttackList;

        public CreatureEditForm()
        {
            InitializeComponent();
            LoadJSON();

            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1)
                                    .AddDays(version.Build).AddSeconds(version.Revision * 2);
            string displayableVersion = $"{version} ({buildDate})";
            
            this.txtSplash.Text += string.Format("\n\r\n\r\n\rVer: {0}   Created by: RobG\n",displayableVersion);
            this.Shown += ShowForm;
        }


        #region formsetup
        private void ShowForm(object sender, EventArgs e) 
        {
            {
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    txtSplash.Visible = true;
                    tabControl.Visible = false;
                    txtSplash.Width = Convert.ToInt32(this.ClientSize.Width * .9);
                    txtSplash.Height = Convert.ToInt32(this.ClientSize.Height * .9);
                    txtSplash.Top = (this.ClientSize.Height - txtSplash.Height) / 2;
                    txtSplash.Left = (this.ClientSize.Width - txtSplash.Width) / 2;
                }
                else
                {
                    txtSplash.Visible = false;
                    tabControl.Visible = true;
                }
            };
        }

        // Source - https://stackoverflow.com/a/2335407
        // Posted by vts123, modified by community. See post 'Timeline' for change history
        // Retrieved 2026-03-06, License - CC BY-SA 4.0

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {

            Graphics g = e.Graphics;
            Brush _TextBrush;

            // Use our own font. Because we CAN.
            Font _TabFont = tabControl.Font;
            Brush _activeTabBG = Brushes.Gray;
            //Brush _inactiveTabBG = Brushes.LightGray;

            // Get the real bounds for the tab rectangle.
            Rectangle _TabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _TextBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(_activeTabBG, e.Bounds);
            }
            else
            {
                _TextBrush = new System.Drawing.SolidBrush(e.ForeColor);
                // e.DrawBackground();
            }


            // Draw string. Center the text.
            StringFormat _StringFlags = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(tabControl.TabPages[e.Index].Text, _TabFont, _TextBrush,
                         _TabBounds, new StringFormat(_StringFlags));

        }

        #endregion

        #region Helper Methods
        private void LoadJSON()
        {
            try
            {
                ResistanceList = Utilities.JsonHelper.LoadResistances("Resources/Types_Resistance.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading resistance types: {ex.Message}", "JSON Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResistanceList = new List<ResistanceType>();
            }

            try
            {
                AttackList = Utilities.JsonHelper.LoadAttacks("Resources/Types_Attacks.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attack types: {ex.Message}", "JSON Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AttackList = new List<AttackType>();
            }

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


        private void AlertSaveRequired()
        {
            DialogResult isSave = MessageBox.Show("You must create or load  the character before assigning properties", "No Character saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tabBasicInfo.Select();
        }

        private void SaveCreature()
        {
            if (creature == null)
            {
                MessageBox.Show("There is no creature to save. Create or load a creature first.", "No Creature", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show("Please use 'Save As' to specify a file location.", "No File Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //BtnSaveAs_Click(null, null);
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


        private void LoadDefensiveModifications()
        {
            lstDefensiveModifications.Items.Clear();
            foreach (DefensiveModification mod in creature.CombatStatistics.DefensiveModifications.Modifications)
            {
                lstDefensiveModifications.Items.Add(mod);
            }
        }

        private void LoadResistanceRollBonuses()
        {
            lstResistanceRollBonuses.Items.Clear();
            foreach (ResistanceRollBonus bonus in creature.CombatStatistics.ResistanceRollBonuses.Bonuses)
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
        #endregion

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

 

        #region Basic Info TAB
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

        private void UpdateTitle()
        {
            string modified = isModified ? " *" : "";
            string fileName = string.IsNullOrEmpty(currentFilePath) ? "New Creature" : System.IO.Path.GetFileName(currentFilePath);
            this.Text = $"Creature XML Editor - {fileName}{modified}";
        }


        private void tabBasic_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Level & Characteristics TAB
        private void tabLevelCharacter_Click(object sender, EventArgs e)
        {

        }

        private void tabLevelCharacter_Enter(object sender, EventArgs e)
        {
            cboResistConcept.Items.Clear();
            var arrQ = ResistanceList.Select(i => new { Value = i.Concept, Name = i.ResistanceName }).ToArray();
            cboResistConcept.Items.AddRange(ResistanceList.ToArray());
            cboResistConcept.SelectedIndex = -1;
        }
        private void lstResistanceRollBonuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load the selected resistance roll bonus details into the form controls
            if (lstResistanceRollBonuses.SelectedIndex >= 0)
            {
                var bonus = creature.CombatStatistics.ResistanceRollBonuses.Bonuses[lstResistanceRollBonuses.SelectedIndex];
                cboResistConcept.Text = bonus.Concept;
                numResistBonus.Value = bonus.TotalBonus;
                btnAddResistanceRollBonus.Text = "Update";
            }
        }

        // Resistance Roll Bonuses
        private void btnAddResistanceRollBonus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboResistConcept.Text))
            {
                MessageBox.Show("Please enter a concept.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnAddResistanceRollBonus.Text == "Update" && lstResistanceRollBonuses.SelectedIndex >= 0)
            {
                // Update existing bonus
                var bonus = creature.CombatStatistics.ResistanceRollBonuses.Bonuses[lstResistanceRollBonuses.SelectedIndex];
                bonus.Concept = cboResistConcept.Text;
                bonus.TotalBonus = (int)numResistBonus.Value;
            }
            else
            {
                // Add new bonus
                var bonus = new ResistanceRollBonus(cboResistConcept.Text, (int)numResistBonus.Value);
                creature.CombatStatistics.ResistanceRollBonuses.Bonuses.Add(bonus);
            }
            LoadResistanceRollBonuses();

            ResetResistancesAdd();
            isModified = true;
            UpdateTitle();
        }

        private void btnRemoveResistanceRollBonus_Click(object sender, EventArgs e)
        {
            if (lstResistanceRollBonuses.SelectedIndex >= 0)
            {
                creature.CombatStatistics.ResistanceRollBonuses.Bonuses.RemoveAt(lstResistanceRollBonuses.SelectedIndex);
                LoadResistanceRollBonuses();
                ResetResistancesAdd();
                isModified = true;
                UpdateTitle();
            }
        }

        private void ResetResistancesAdd()
        {
            btnAddResistanceRollBonus.Text = "Add";
            cboResistConcept.Text = "";
            cboResistConcept.SelectedIndex = -1;
            numResistBonus.Value = 0;
        }

        #endregion

        #region Attacks TAB
        // Attacks
        private void tabCombat_Enter(object sender, EventArgs e)
        {
            if (creature == null) 
            { 
                AlertSaveRequired();
                return;
            }
            cboAttackTableName.Items.Clear();
            var qA = AttackList.Select(i => new { WeapName = i.WeaponName, TblName = i.TableName }).ToArray();
            cboAttackTableName.Items.AddRange(qA.ToArray());
            cboAttackTableName.SelectedIndex = -1;

        }

 

        private void lstAttacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load the selected attack details into the form controls
            if (lstAttacks.SelectedIndex >= 0)
            {
                var attack = creature.CombatStatistics.Attacks.AttackList[lstAttacks.SelectedIndex];
                cboAttackTableName.Text = attack.TableName;
                txtAttackName.Text = attack.Name;
                numAttackBonus.Value = attack.Bonus;
                numAttackSizeAdj.Value = attack.SizeAdjustment;
                btnAddAttack.Text = "Update";
            }
        }
        private void cboAttackTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this is new selection , so copy the attack name to the text box for editing
            if (cboAttackTableName.SelectedIndex >= 0 && cboAttackTableName.SelectedIndex < AttackList.Count)
            {
                var selectedAttack = AttackList[cboAttackTableName.SelectedIndex];
                if (string.IsNullOrWhiteSpace(txtAttackName.Text))
                    txtAttackName.Text = selectedAttack.WeaponName;
            }
        }
        private void btnAddAttack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboAttackTableName.Text) || string.IsNullOrWhiteSpace(txtAttackName.Text))
            {
                MessageBox.Show("Please enter both attack name and table name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnAddAttack.Text == "Update" && lstAttacks.SelectedIndex >= 0)
            {
                // Update existing attack
                var attack = creature.CombatStatistics.Attacks.AttackList[lstAttacks.SelectedIndex];
                attack.Name = txtAttackName.Text;
                attack.TableName = cboAttackTableName.Text;
                attack.Bonus = (int)numAttackBonus.Value;
                attack.SizeAdjustment = (int)numAttackSizeAdj.Value;
            }
            else
            {
                // Add new attack
                var attack = new Attack((int)numAttackBonus.Value, txtAttackName.Text, cboAttackTableName.Text, (int)numAttackSizeAdj.Value);
                creature.CombatStatistics.Attacks.AttackList.Add(attack);
            }
            ResetAttacksAdd();
            LoadAttacks();


            isModified = true;
            UpdateTitle();
        }

        private void btnRemoveAttack_Click(object sender, EventArgs e)
        {
            if (lstAttacks.SelectedIndex >= 0)
            {
                creature.CombatStatistics.Attacks.AttackList.RemoveAt(lstAttacks.SelectedIndex);
                ResetAttacksAdd();
                LoadAttacks();
                isModified = true;
                UpdateTitle();
                btnAddAttack.Text = "Add";
            }
        }


        private void ResetAttacksAdd()
        {
            btnAddAttack.Text = "Add";
            cboAttackTableName.Text = "";
            cboAttackTableName.SelectedIndex = -1;
            txtAttackName.Clear();
            numAttackBonus.Value = 0;
            numAttackSizeAdj.Value = 0;
        }
        #endregion

        #region Defensive Modifications
        // Defensive Modifications


        private void lstDefensiveModifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load the selected attack details into the form controls
            if (lstDefensiveModifications.SelectedIndex >= 0)
            {
                var defMod = creature.CombatStatistics.DefensiveModifications.Modifications[lstDefensiveModifications.SelectedIndex];
                txtDefModConcept.Text= defMod.Concept;
                numDefModBonus.Value = defMod.BonusOrPenalty;
                btnAddDefensiveModification.Text = "Update";
            }
        }

        private void btnAddDefensiveModification_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDefModConcept.Text))
            {
                MessageBox.Show("Please enter a concept.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnAddDefensiveModification.Text == "Update" && lstDefensiveModifications.SelectedIndex >= 0)
            {
                // Update existing attack
                var defence = creature.CombatStatistics.DefensiveModifications.Modifications[lstDefensiveModifications.SelectedIndex];
                defence.Concept = txtDefModConcept.Text;
                defence.BonusOrPenalty = (int)numDefModBonus.Value;
            }
            else
            { 

                var mod = new DefensiveModification((int)numDefModBonus.Value, txtDefModConcept.Text);
                creature.CombatStatistics.DefensiveModifications.Modifications.Add(mod);
            }
            LoadDefensiveModifications();
            ResetDefensiveMod();
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

        private void ResetDefensiveMod()
        {
            txtDefModConcept.Text = "";
            numDefModBonus.Value = 5;
            btnAddDefensiveModification.Text = "Add";
        }
        #endregion

        #region Skills

        private void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSkills.SelectedIndex >= 0)
            {
                var skill = creature.ManeuverSkills.Skills[lstSkills.SelectedIndex];
                txtSkillName.Text = skill.Name;
                txtSkillTableName.Text = skill.TableName;
                numSkillRanks.Value = skill.Ranks;
                numSkillBonus.Value = skill.Bonus;
                btnAddSkill.Text = "Update";
            }
        }
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
                ResetSkillAdd();
                isModified = true;
                UpdateTitle();
            }
        }


        private void ResetSkillAdd()
        {
            txtSkillName.Text = "";
            txtSkillTableName.Text = "";
            numSkillRanks.Value = 0;
            numSkillBonus.Value = 0;
            btnAddSkill.Text = "Add";
        }
        #endregion



        #region Menu Handlers
        private void menuNew_Click(object sender, EventArgs e)
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
            //LoadCreatureToForm();

            txtSplash.Visible = false;
            tabControl.Visible = true;
        }

        private void menuLoad_Click(object sender, EventArgs e)
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
                    //MessageBox.Show("File loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtSplash.Visible = false;
                    tabControl.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            if (creature == null)
            {
                MessageBox.Show("There is no creature to save. Create or load a creature first.", "No Creature", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveCreature();
        }

        private void menuExit_Click(object sender, EventArgs e) {

            if (isModified) {
                DialogResult result = MessageBox.Show(
                    "Unsaved changes will be lost.",
                    "Confirm close",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;
            }

            Close();
        }





        #endregion


    }
}
