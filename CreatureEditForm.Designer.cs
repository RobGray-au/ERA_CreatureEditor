using System.Windows.Forms;

namespace CreatureXmlEditor
{
    partial class CreatureEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatureEditForm));
            mainMenu1 = new MenuStrip();
            toolStripMenuItemNew = new ToolStripMenuItem();
            toolStripMenuItemLoad = new ToolStripMenuItem();
            toolStripMenuItemSave = new ToolStripMenuItem();
            toolStripMenuItemSaveAs = new ToolStripMenuItem();
            toolStripMenuItemQuit = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            lblAttackName = new Label();
            lblAttackTableName = new Label();
            txtAttackName = new TextBox();
            lblAttackBonus = new Label();
            numAttackBonus = new NumericUpDown();
            lblAttackSizeAdj = new Label();
            numAttackSizeAdj = new NumericUpDown();
            btnAddAttack = new Button();
            lstAttacks = new ListBox();
            btnRemoveAttack = new Button();
            tabSkills = new TabPage();
            grpSkills = new GroupBox();
            lblSkillName = new Label();
            txtSkillName = new TextBox();
            lblSkillTableName = new Label();
            txtSkillTableName = new TextBox();
            lblSkillRanks = new Label();
            numSkillRanks = new NumericUpDown();
            lblSkillBonus = new Label();
            numSkillBonus = new NumericUpDown();
            btnAddSkill = new Button();
            lstSkills = new ListBox();
            btnRemoveSkill = new Button();
            tabCombat = new TabPage();
            grpAttacks = new GroupBox();
            cboAttackTableName = new ComboBox();
            tabLevelResist = new TabPage();
            pictureBox1 = new PictureBox();
            grpResist = new GroupBox();
            cboResistConcept = new ComboBox();
            lblResistConcept = new Label();
            lblResistBonus = new Label();
            numResistBonus = new NumericUpDown();
            btnAddResistanceRollBonus = new Button();
            lstResistanceRollBonuses = new ListBox();
            btnRemoveResistanceRollBonus = new Button();
            lblBaseHits = new Label();
            numBaseHits = new NumericUpDown();
            lblAverageLevel = new Label();
            numAverageLevel = new NumericUpDown();
            lblBaseMovement = new Label();
            numBaseMovement = new NumericUpDown();
            lblAttackQuickness = new Label();
            numAttackQuickness = new NumericUpDown();
            tabBasicInfo = new TabPage();
            lblCreatureName = new Label();
            txtCreatureName = new TextBox();
            txtCategory = new TextBox();
            txtDescription = new TextBox();
            lblCategory = new Label();
            lblDescription = new Label();
            tabControl = new TabControl();
            tabDefence = new TabPage();
            lblArmorType = new Label();
            numArmorType = new NumericUpDown();
            lblDefensiveBonus = new Label();
            numDefensiveBonus = new NumericUpDown();
            grpDefMod = new GroupBox();
            btnRemoveDefensiveModification = new Button();
            lblDefModConcept = new Label();
            txtDefModConcept = new TextBox();
            lblDefModBonus = new Label();
            numDefModBonus = new NumericUpDown();
            btnAddDefensiveModification = new Button();
            lstDefensiveModifications = new ListBox();
            txtSplash = new TextBox();
            toolTip1 = new ToolTip(components);
            mainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAttackBonus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAttackSizeAdj).BeginInit();
            tabSkills.SuspendLayout();
            grpSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSkillRanks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSkillBonus).BeginInit();
            tabCombat.SuspendLayout();
            grpAttacks.SuspendLayout();
            tabLevelResist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpResist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numResistBonus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBaseHits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAverageLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBaseMovement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAttackQuickness).BeginInit();
            tabBasicInfo.SuspendLayout();
            tabControl.SuspendLayout();
            tabDefence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numArmorType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDefensiveBonus).BeginInit();
            grpDefMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDefModBonus).BeginInit();
            SuspendLayout();
            // 
            // mainMenu1
            // 
            mainMenu1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemNew, toolStripMenuItemLoad, toolStripMenuItemSave, toolStripMenuItemSaveAs, toolStripMenuItemQuit });
            mainMenu1.Location = new Point(0, 0);
            mainMenu1.Name = "mainMenu1";
            mainMenu1.Padding = new Padding(7, 2, 0, 2);
            mainMenu1.Size = new Size(765, 24);
            mainMenu1.TabIndex = 3;
            // 
            // toolStripMenuItemNew
            // 
            toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            toolStripMenuItemNew.Size = new Size(43, 20);
            toolStripMenuItemNew.Text = "New";
            toolStripMenuItemNew.Click += menuNew_Click;
            // 
            // toolStripMenuItemLoad
            // 
            toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            toolStripMenuItemLoad.Size = new Size(45, 20);
            toolStripMenuItemLoad.Text = "Load";
            toolStripMenuItemLoad.Click += menuLoad_Click;
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.Size = new Size(43, 20);
            toolStripMenuItemSave.Text = "Save";
            toolStripMenuItemSave.Click += menuSave_Click;
            // 
            // toolStripMenuItemSaveAs
            // 
            toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            toolStripMenuItemSaveAs.Size = new Size(56, 20);
            toolStripMenuItemSaveAs.Text = "SaveAs";
            toolStripMenuItemSaveAs.Click += menuSaveAs_Click;
            // 
            // toolStripMenuItemQuit
            // 
            toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            toolStripMenuItemQuit.Size = new Size(37, 20);
            toolStripMenuItemQuit.Text = "Exit";
            toolStripMenuItemQuit.Click += menuExit_Click;
            // 
            // tabControl1
            // 
            tabControl1.CausesValidation = false;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 10;
            // 
            // lblAttackName
            // 
            lblAttackName.AutoSize = true;
            lblAttackName.Location = new Point(435, 27);
            lblAttackName.Margin = new Padding(4, 0, 4, 0);
            lblAttackName.Name = "lblAttackName";
            lblAttackName.Size = new Size(56, 20);
            lblAttackName.TabIndex = 0;
            lblAttackName.Text = "Name:";
            // 
            // lblAttackTableName
            // 
            lblAttackTableName.AutoSize = true;
            lblAttackTableName.Location = new Point(18, 31);
            lblAttackTableName.Margin = new Padding(4, 0, 4, 0);
            lblAttackTableName.Name = "lblAttackTableName";
            lblAttackTableName.Size = new Size(53, 20);
            lblAttackTableName.TabIndex = 2;
            lblAttackTableName.Text = "Table:";
            // 
            // txtAttackName
            // 
            txtAttackName.Location = new Point(507, 23);
            txtAttackName.Margin = new Padding(4, 3, 4, 3);
            txtAttackName.Name = "txtAttackName";
            txtAttackName.Size = new Size(207, 27);
            txtAttackName.TabIndex = 3;
            toolTip1.SetToolTip(txtAttackName, "special name of weapon");
            // 
            // lblAttackBonus
            // 
            lblAttackBonus.AutoSize = true;
            lblAttackBonus.Location = new Point(12, 63);
            lblAttackBonus.Margin = new Padding(4, 0, 4, 0);
            lblAttackBonus.Name = "lblAttackBonus";
            lblAttackBonus.Size = new Size(58, 20);
            lblAttackBonus.TabIndex = 4;
            lblAttackBonus.Text = "Bonus:";
            // 
            // numAttackBonus
            // 
            numAttackBonus.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numAttackBonus.Location = new Point(86, 59);
            numAttackBonus.Margin = new Padding(4, 3, 4, 3);
            numAttackBonus.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numAttackBonus.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numAttackBonus.Name = "numAttackBonus";
            numAttackBonus.Size = new Size(117, 27);
            numAttackBonus.TabIndex = 5;
            numAttackBonus.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAttackSizeAdj
            // 
            lblAttackSizeAdj.AutoSize = true;
            lblAttackSizeAdj.Location = new Point(281, 66);
            lblAttackSizeAdj.Margin = new Padding(4, 0, 4, 0);
            lblAttackSizeAdj.Name = "lblAttackSizeAdj";
            lblAttackSizeAdj.Size = new Size(94, 20);
            lblAttackSizeAdj.TabIndex = 6;
            lblAttackSizeAdj.Text = "Size Adjust:";
            // 
            // numAttackSizeAdj
            // 
            numAttackSizeAdj.Location = new Point(398, 61);
            numAttackSizeAdj.Margin = new Padding(4, 3, 4, 3);
            numAttackSizeAdj.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numAttackSizeAdj.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
            numAttackSizeAdj.Name = "numAttackSizeAdj";
            numAttackSizeAdj.Size = new Size(85, 27);
            numAttackSizeAdj.TabIndex = 7;
            numAttackSizeAdj.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddAttack
            // 
            btnAddAttack.Location = new Point(573, 58);
            btnAddAttack.Margin = new Padding(4, 3, 4, 3);
            btnAddAttack.Name = "btnAddAttack";
            btnAddAttack.Size = new Size(88, 31);
            btnAddAttack.TabIndex = 8;
            btnAddAttack.Text = "Add";
            btnAddAttack.UseVisualStyleBackColor = true;
            btnAddAttack.Click += btnAddAttack_Click;
            // 
            // lstAttacks
            // 
            lstAttacks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAttacks.FormattingEnabled = true;
            lstAttacks.Location = new Point(12, 104);
            lstAttacks.Margin = new Padding(4, 3, 4, 3);
            lstAttacks.Name = "lstAttacks";
            lstAttacks.Size = new Size(685, 184);
            lstAttacks.TabIndex = 9;
            lstAttacks.SelectedIndexChanged += lstAttacks_SelectedIndexChanged;
            // 
            // btnRemoveAttack
            // 
            btnRemoveAttack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveAttack.Location = new Point(607, 298);
            btnRemoveAttack.Margin = new Padding(4, 3, 4, 3);
            btnRemoveAttack.Name = "btnRemoveAttack";
            btnRemoveAttack.Size = new Size(107, 43);
            btnRemoveAttack.TabIndex = 10;
            btnRemoveAttack.Text = "Remove";
            btnRemoveAttack.UseVisualStyleBackColor = true;
            btnRemoveAttack.Click += btnRemoveAttack_Click;
            // 
            // tabSkills
            // 
            tabSkills.AutoScroll = true;
            tabSkills.BackColor = Color.PaleGreen;
            tabSkills.Controls.Add(grpSkills);
            tabSkills.Location = new Point(4, 29);
            tabSkills.Margin = new Padding(4, 3, 4, 3);
            tabSkills.Name = "tabSkills";
            tabSkills.Padding = new Padding(12);
            tabSkills.Size = new Size(757, 379);
            tabSkills.TabIndex = 3;
            tabSkills.Text = "Skills";
            // 
            // grpSkills
            // 
            grpSkills.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpSkills.Controls.Add(lblSkillName);
            grpSkills.Controls.Add(txtSkillName);
            grpSkills.Controls.Add(lblSkillTableName);
            grpSkills.Controls.Add(txtSkillTableName);
            grpSkills.Controls.Add(lblSkillRanks);
            grpSkills.Controls.Add(numSkillRanks);
            grpSkills.Controls.Add(lblSkillBonus);
            grpSkills.Controls.Add(numSkillBonus);
            grpSkills.Controls.Add(btnAddSkill);
            grpSkills.Controls.Add(lstSkills);
            grpSkills.Controls.Add(btnRemoveSkill);
            grpSkills.Location = new Point(11, 3);
            grpSkills.Margin = new Padding(4, 3, 4, 3);
            grpSkills.Name = "grpSkills";
            grpSkills.Padding = new Padding(4, 3, 4, 3);
            grpSkills.Size = new Size(702, 368);
            grpSkills.TabIndex = 0;
            grpSkills.TabStop = false;
            grpSkills.Text = "Maneuver Skills";
            grpSkills.Enter += grpSkills_Enter;
            // 
            // lblSkillName
            // 
            lblSkillName.AutoSize = true;
            lblSkillName.Location = new Point(12, 29);
            lblSkillName.Margin = new Padding(4, 0, 4, 0);
            lblSkillName.Name = "lblSkillName";
            lblSkillName.Size = new Size(56, 20);
            lblSkillName.TabIndex = 0;
            lblSkillName.Text = "Name:";
            // 
            // txtSkillName
            // 
            txtSkillName.Location = new Point(85, 25);
            txtSkillName.Margin = new Padding(4, 3, 4, 3);
            txtSkillName.Name = "txtSkillName";
            txtSkillName.Size = new Size(193, 27);
            txtSkillName.TabIndex = 1;
            toolTip1.SetToolTip(txtSkillName, "freeform entry");
            // 
            // lblSkillTableName
            // 
            lblSkillTableName.AutoSize = true;
            lblSkillTableName.Location = new Point(310, 29);
            lblSkillTableName.Margin = new Padding(4, 0, 4, 0);
            lblSkillTableName.Name = "lblSkillTableName";
            lblSkillTableName.Size = new Size(53, 20);
            lblSkillTableName.TabIndex = 2;
            lblSkillTableName.Text = "Table:";
            // 
            // txtSkillTableName
            // 
            txtSkillTableName.Location = new Point(379, 25);
            txtSkillTableName.Margin = new Padding(4, 3, 4, 3);
            txtSkillTableName.Name = "txtSkillTableName";
            txtSkillTableName.Size = new Size(199, 27);
            txtSkillTableName.TabIndex = 3;
            toolTip1.SetToolTip(txtSkillTableName, "freeform entry for now");
            // 
            // lblSkillRanks
            // 
            lblSkillRanks.AutoSize = true;
            lblSkillRanks.Location = new Point(12, 63);
            lblSkillRanks.Margin = new Padding(4, 0, 4, 0);
            lblSkillRanks.Name = "lblSkillRanks";
            lblSkillRanks.Size = new Size(57, 20);
            lblSkillRanks.TabIndex = 4;
            lblSkillRanks.Text = "Ranks:";
            // 
            // numSkillRanks
            // 
            numSkillRanks.Location = new Point(85, 61);
            numSkillRanks.Margin = new Padding(4, 3, 4, 3);
            numSkillRanks.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numSkillRanks.Name = "numSkillRanks";
            numSkillRanks.Size = new Size(117, 27);
            numSkillRanks.TabIndex = 5;
            numSkillRanks.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSkillBonus
            // 
            lblSkillBonus.AutoSize = true;
            lblSkillBonus.Location = new Point(328, 68);
            lblSkillBonus.Margin = new Padding(4, 0, 4, 0);
            lblSkillBonus.Name = "lblSkillBonus";
            lblSkillBonus.Size = new Size(58, 20);
            lblSkillBonus.TabIndex = 6;
            lblSkillBonus.Text = "Bonus:";
            // 
            // numSkillBonus
            // 
            numSkillBonus.Location = new Point(402, 63);
            numSkillBonus.Margin = new Padding(4, 3, 4, 3);
            numSkillBonus.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numSkillBonus.Minimum = new decimal(new int[] { 20, 0, 0, int.MinValue });
            numSkillBonus.Name = "numSkillBonus";
            numSkillBonus.Size = new Size(117, 27);
            numSkillBonus.TabIndex = 7;
            numSkillBonus.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddSkill
            // 
            btnAddSkill.Location = new Point(541, 59);
            btnAddSkill.Margin = new Padding(4, 3, 4, 3);
            btnAddSkill.Name = "btnAddSkill";
            btnAddSkill.Size = new Size(88, 33);
            btnAddSkill.TabIndex = 8;
            btnAddSkill.Text = "Add";
            btnAddSkill.UseVisualStyleBackColor = true;
            btnAddSkill.Click += BtnAddSkill_Click;
            // 
            // lstSkills
            // 
            lstSkills.FormattingEnabled = true;
            lstSkills.Location = new Point(16, 99);
            lstSkills.Margin = new Padding(4, 3, 4, 3);
            lstSkills.Name = "lstSkills";
            lstSkills.Size = new Size(638, 204);
            lstSkills.TabIndex = 9;
            lstSkills.SelectedIndexChanged += lstSkills_SelectedIndexChanged;
            // 
            // btnRemoveSkill
            // 
            btnRemoveSkill.Location = new Point(541, 320);
            btnRemoveSkill.Margin = new Padding(4, 3, 4, 3);
            btnRemoveSkill.Name = "btnRemoveSkill";
            btnRemoveSkill.Size = new Size(104, 39);
            btnRemoveSkill.TabIndex = 10;
            btnRemoveSkill.Text = "Remove";
            btnRemoveSkill.UseVisualStyleBackColor = true;
            btnRemoveSkill.Click += BtnRemoveSkill_Click;
            // 
            // tabCombat
            // 
            tabCombat.AutoScroll = true;
            tabCombat.BackColor = Color.MistyRose;
            tabCombat.Controls.Add(grpAttacks);
            tabCombat.Location = new Point(4, 29);
            tabCombat.Margin = new Padding(4, 3, 4, 3);
            tabCombat.Name = "tabCombat";
            tabCombat.Padding = new Padding(12);
            tabCombat.Size = new Size(757, 379);
            tabCombat.TabIndex = 2;
            tabCombat.Text = "Combat";
            tabCombat.Enter += tabCombat_Enter;
            // 
            // grpAttacks
            // 
            grpAttacks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAttacks.Controls.Add(cboAttackTableName);
            grpAttacks.Controls.Add(lblAttackName);
            grpAttacks.Controls.Add(lblAttackTableName);
            grpAttacks.Controls.Add(txtAttackName);
            grpAttacks.Controls.Add(lblAttackBonus);
            grpAttacks.Controls.Add(numAttackBonus);
            grpAttacks.Controls.Add(lblAttackSizeAdj);
            grpAttacks.Controls.Add(numAttackSizeAdj);
            grpAttacks.Controls.Add(btnAddAttack);
            grpAttacks.Controls.Add(lstAttacks);
            grpAttacks.Controls.Add(btnRemoveAttack);
            grpAttacks.Location = new Point(12, 17);
            grpAttacks.Margin = new Padding(4, 3, 4, 3);
            grpAttacks.Name = "grpAttacks";
            grpAttacks.Padding = new Padding(4, 3, 4, 3);
            grpAttacks.Size = new Size(728, 347);
            grpAttacks.TabIndex = 0;
            grpAttacks.TabStop = false;
            grpAttacks.Text = "Attacks";
            // 
            // cboAttackTableName
            // 
            cboAttackTableName.DisplayMember = "TblName";
            cboAttackTableName.FormattingEnabled = true;
            cboAttackTableName.Location = new Point(86, 20);
            cboAttackTableName.Margin = new Padding(4, 3, 4, 3);
            cboAttackTableName.Name = "cboAttackTableName";
            cboAttackTableName.Size = new Size(283, 28);
            cboAttackTableName.TabIndex = 11;
            toolTip1.SetToolTip(cboAttackTableName, "select from list of attack tables ( JSON file )\r\ncan be free text also");
            cboAttackTableName.ValueMember = "WeapName";
            cboAttackTableName.SelectedIndexChanged += cboAttackTableName_SelectedIndexChanged;
            // 
            // tabLevelResist
            // 
            tabLevelResist.BackColor = SystemColors.ActiveCaption;
            tabLevelResist.Controls.Add(pictureBox1);
            tabLevelResist.Controls.Add(grpResist);
            tabLevelResist.Controls.Add(lblBaseHits);
            tabLevelResist.Controls.Add(numBaseHits);
            tabLevelResist.Controls.Add(lblAverageLevel);
            tabLevelResist.Controls.Add(numAverageLevel);
            tabLevelResist.Controls.Add(lblBaseMovement);
            tabLevelResist.Controls.Add(numBaseMovement);
            tabLevelResist.Controls.Add(lblAttackQuickness);
            tabLevelResist.Controls.Add(numAttackQuickness);
            tabLevelResist.Location = new Point(4, 29);
            tabLevelResist.Margin = new Padding(4, 3, 4, 3);
            tabLevelResist.Name = "tabLevelResist";
            tabLevelResist.Size = new Size(757, 379);
            tabLevelResist.TabIndex = 1;
            tabLevelResist.Text = "Level & Character";
            tabLevelResist.Click += tabLevelCharacter_Click;
            tabLevelResist.Enter += tabLevelCharacter_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(259, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Randomize level based on RMCo2");
            // 
            // grpResist
            // 
            grpResist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpResist.Controls.Add(cboResistConcept);
            grpResist.Controls.Add(lblResistConcept);
            grpResist.Controls.Add(lblResistBonus);
            grpResist.Controls.Add(numResistBonus);
            grpResist.Controls.Add(btnAddResistanceRollBonus);
            grpResist.Controls.Add(lstResistanceRollBonuses);
            grpResist.Controls.Add(btnRemoveResistanceRollBonus);
            grpResist.Location = new Point(13, 126);
            grpResist.Margin = new Padding(4, 3, 4, 3);
            grpResist.Name = "grpResist";
            grpResist.Padding = new Padding(4, 3, 4, 3);
            grpResist.Size = new Size(705, 239);
            grpResist.TabIndex = 12;
            grpResist.TabStop = false;
            grpResist.Text = "Resistance Roll Bonuses";
            // 
            // cboResistConcept
            // 
            cboResistConcept.DisplayMember = "ResistanceName";
            cboResistConcept.FormattingEnabled = true;
            cboResistConcept.Location = new Point(103, 24);
            cboResistConcept.Margin = new Padding(4, 3, 4, 3);
            cboResistConcept.Name = "cboResistConcept";
            cboResistConcept.Size = new Size(226, 28);
            cboResistConcept.TabIndex = 7;
            cboResistConcept.ValueMember = "Concept";
            // 
            // lblResistConcept
            // 
            lblResistConcept.AutoSize = true;
            lblResistConcept.Location = new Point(12, 29);
            lblResistConcept.Margin = new Padding(4, 0, 4, 0);
            lblResistConcept.Name = "lblResistConcept";
            lblResistConcept.Size = new Size(72, 20);
            lblResistConcept.TabIndex = 0;
            lblResistConcept.Text = "Concept:";
            // 
            // lblResistBonus
            // 
            lblResistBonus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResistBonus.AutoSize = true;
            lblResistBonus.Location = new Point(390, 25);
            lblResistBonus.Margin = new Padding(4, 0, 4, 0);
            lblResistBonus.Name = "lblResistBonus";
            lblResistBonus.Size = new Size(58, 20);
            lblResistBonus.TabIndex = 2;
            lblResistBonus.Text = "Bonus:";
            // 
            // numResistBonus
            // 
            numResistBonus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numResistBonus.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numResistBonus.Location = new Point(464, 23);
            numResistBonus.Margin = new Padding(4, 3, 4, 3);
            numResistBonus.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numResistBonus.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numResistBonus.Name = "numResistBonus";
            numResistBonus.Size = new Size(61, 27);
            numResistBonus.TabIndex = 3;
            numResistBonus.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddResistanceRollBonus
            // 
            btnAddResistanceRollBonus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddResistanceRollBonus.Location = new Point(553, 24);
            btnAddResistanceRollBonus.Margin = new Padding(4, 3, 4, 3);
            btnAddResistanceRollBonus.Name = "btnAddResistanceRollBonus";
            btnAddResistanceRollBonus.Size = new Size(88, 30);
            btnAddResistanceRollBonus.TabIndex = 4;
            btnAddResistanceRollBonus.Text = "Add";
            btnAddResistanceRollBonus.UseVisualStyleBackColor = true;
            btnAddResistanceRollBonus.Click += btnAddResistanceRollBonus_Click;
            // 
            // lstResistanceRollBonuses
            // 
            lstResistanceRollBonuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstResistanceRollBonuses.FormattingEnabled = true;
            lstResistanceRollBonuses.Location = new Point(12, 58);
            lstResistanceRollBonuses.Margin = new Padding(4, 3, 4, 3);
            lstResistanceRollBonuses.Name = "lstResistanceRollBonuses";
            lstResistanceRollBonuses.Size = new Size(661, 124);
            lstResistanceRollBonuses.TabIndex = 5;
            lstResistanceRollBonuses.SelectedIndexChanged += lstResistanceRollBonuses_SelectedIndexChanged;
            // 
            // btnRemoveResistanceRollBonus
            // 
            btnRemoveResistanceRollBonus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveResistanceRollBonus.Location = new Point(533, 192);
            btnRemoveResistanceRollBonus.Margin = new Padding(4, 3, 4, 3);
            btnRemoveResistanceRollBonus.Name = "btnRemoveResistanceRollBonus";
            btnRemoveResistanceRollBonus.Size = new Size(128, 40);
            btnRemoveResistanceRollBonus.TabIndex = 6;
            btnRemoveResistanceRollBonus.Text = "Remove";
            btnRemoveResistanceRollBonus.UseVisualStyleBackColor = true;
            btnRemoveResistanceRollBonus.Click += btnRemoveResistanceRollBonus_Click;
            // 
            // lblBaseHits
            // 
            lblBaseHits.AutoSize = true;
            lblBaseHits.Location = new Point(342, 16);
            lblBaseHits.Margin = new Padding(4, 0, 4, 0);
            lblBaseHits.Name = "lblBaseHits";
            lblBaseHits.Size = new Size(80, 20);
            lblBaseHits.TabIndex = 10;
            lblBaseHits.Text = "Base Hits:";
            // 
            // numBaseHits
            // 
            numBaseHits.Location = new Point(458, 14);
            numBaseHits.Margin = new Padding(4, 3, 4, 3);
            numBaseHits.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numBaseHits.Name = "numBaseHits";
            numBaseHits.Size = new Size(117, 27);
            numBaseHits.TabIndex = 11;
            numBaseHits.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAverageLevel
            // 
            lblAverageLevel.AutoSize = true;
            lblAverageLevel.Location = new Point(9, 14);
            lblAverageLevel.Margin = new Padding(4, 0, 4, 0);
            lblAverageLevel.Name = "lblAverageLevel";
            lblAverageLevel.Size = new Size(117, 20);
            lblAverageLevel.TabIndex = 0;
            lblAverageLevel.Text = "Average Level:";
            // 
            // numAverageLevel
            // 
            numAverageLevel.Location = new Point(153, 12);
            numAverageLevel.Margin = new Padding(4, 3, 4, 3);
            numAverageLevel.Name = "numAverageLevel";
            numAverageLevel.Size = new Size(88, 27);
            numAverageLevel.TabIndex = 0;
            numAverageLevel.TextAlign = HorizontalAlignment.Center;
            numAverageLevel.ValueChanged += NumericChanged_Handler;
            // 
            // lblBaseMovement
            // 
            lblBaseMovement.AutoSize = true;
            lblBaseMovement.Location = new Point(9, 46);
            lblBaseMovement.Margin = new Padding(4, 0, 4, 0);
            lblBaseMovement.Name = "lblBaseMovement";
            lblBaseMovement.Size = new Size(127, 20);
            lblBaseMovement.TabIndex = 0;
            lblBaseMovement.Text = "Base Movement:";
            // 
            // numBaseMovement
            // 
            numBaseMovement.Location = new Point(163, 44);
            numBaseMovement.Margin = new Padding(4, 3, 4, 3);
            numBaseMovement.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numBaseMovement.Name = "numBaseMovement";
            numBaseMovement.Size = new Size(86, 27);
            numBaseMovement.TabIndex = 0;
            numBaseMovement.TextAlign = HorizontalAlignment.Center;
            numBaseMovement.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numBaseMovement.ValueChanged += NumericChanged_Handler;
            // 
            // lblAttackQuickness
            // 
            lblAttackQuickness.AutoSize = true;
            lblAttackQuickness.Location = new Point(9, 82);
            lblAttackQuickness.Margin = new Padding(4, 0, 4, 0);
            lblAttackQuickness.Name = "lblAttackQuickness";
            lblAttackQuickness.Size = new Size(138, 20);
            lblAttackQuickness.TabIndex = 0;
            lblAttackQuickness.Text = "Attack Quickness:";
            // 
            // numAttackQuickness
            // 
            numAttackQuickness.Location = new Point(177, 80);
            numAttackQuickness.Margin = new Padding(4, 3, 4, 3);
            numAttackQuickness.Minimum = new decimal(new int[] { 20, 0, 0, int.MinValue });
            numAttackQuickness.Name = "numAttackQuickness";
            numAttackQuickness.Size = new Size(85, 27);
            numAttackQuickness.TabIndex = 0;
            numAttackQuickness.TextAlign = HorizontalAlignment.Center;
            numAttackQuickness.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numAttackQuickness.ValueChanged += NumericChanged_Handler;
            // 
            // tabBasicInfo
            // 
            tabBasicInfo.BackColor = Color.RosyBrown;
            tabBasicInfo.Controls.Add(lblCreatureName);
            tabBasicInfo.Controls.Add(txtCreatureName);
            tabBasicInfo.Controls.Add(txtCategory);
            tabBasicInfo.Controls.Add(txtDescription);
            tabBasicInfo.Controls.Add(lblCategory);
            tabBasicInfo.Controls.Add(lblDescription);
            tabBasicInfo.Location = new Point(4, 29);
            tabBasicInfo.Margin = new Padding(4, 3, 4, 3);
            tabBasicInfo.Name = "tabBasicInfo";
            tabBasicInfo.Padding = new Padding(12);
            tabBasicInfo.Size = new Size(757, 379);
            tabBasicInfo.TabIndex = 0;
            tabBasicInfo.Text = "Basic Info";
            // 
            // lblCreatureName
            // 
            lblCreatureName.AutoSize = true;
            lblCreatureName.Location = new Point(23, 29);
            lblCreatureName.Margin = new Padding(4, 0, 4, 0);
            lblCreatureName.Name = "lblCreatureName";
            lblCreatureName.Size = new Size(122, 20);
            lblCreatureName.TabIndex = 0;
            lblCreatureName.Text = "Creature Name:";
            // 
            // txtCreatureName
            // 
            txtCreatureName.Location = new Point(183, 25);
            txtCreatureName.Margin = new Padding(4, 3, 4, 3);
            txtCreatureName.Name = "txtCreatureName";
            txtCreatureName.Size = new Size(349, 27);
            txtCreatureName.TabIndex = 1;
            txtCreatureName.WordWrap = false;
            txtCreatureName.TextChanged += TextChanged_Handler;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(121, 68);
            txtCategory.Margin = new Padding(4, 3, 4, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(349, 27);
            txtCategory.TabIndex = 3;
            txtCategory.TextChanged += TextChanged_Handler;
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = true;
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(142, 106);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(579, 230);
            txtDescription.TabIndex = 5;
            txtDescription.TextChanged += TextChanged_Handler;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 69);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(23, 110);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabBasicInfo);
            tabControl.Controls.Add(tabLevelResist);
            tabControl.Controls.Add(tabCombat);
            tabControl.Controls.Add(tabDefence);
            tabControl.Controls.Add(tabSkills);
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.HotTrack = true;
            tabControl.Location = new Point(0, 24);
            tabControl.Margin = new Padding(4, 3, 4, 3);
            tabControl.MinimumSize = new Size(12, 127);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(765, 412);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 0;
            tabControl.DrawItem += tabControl_DrawItem;
            // 
            // tabDefence
            // 
            tabDefence.BackColor = Color.Gainsboro;
            tabDefence.Controls.Add(lblArmorType);
            tabDefence.Controls.Add(numArmorType);
            tabDefence.Controls.Add(lblDefensiveBonus);
            tabDefence.Controls.Add(numDefensiveBonus);
            tabDefence.Controls.Add(grpDefMod);
            tabDefence.Location = new Point(4, 29);
            tabDefence.Margin = new Padding(4, 3, 4, 3);
            tabDefence.Name = "tabDefence";
            tabDefence.Padding = new Padding(4, 3, 4, 3);
            tabDefence.Size = new Size(757, 379);
            tabDefence.TabIndex = 4;
            tabDefence.Text = "Defence";
            // 
            // lblArmorType
            // 
            lblArmorType.AutoSize = true;
            lblArmorType.Location = new Point(21, 47);
            lblArmorType.Margin = new Padding(4, 0, 4, 0);
            lblArmorType.Name = "lblArmorType";
            lblArmorType.Size = new Size(101, 20);
            lblArmorType.TabIndex = 10;
            lblArmorType.Text = "Armor Type:";
            // 
            // numArmorType
            // 
            numArmorType.Location = new Point(146, 47);
            numArmorType.Margin = new Padding(4, 3, 4, 3);
            numArmorType.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numArmorType.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numArmorType.Name = "numArmorType";
            numArmorType.Size = new Size(78, 27);
            numArmorType.TabIndex = 11;
            numArmorType.TextAlign = HorizontalAlignment.Center;
            numArmorType.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDefensiveBonus
            // 
            lblDefensiveBonus.AutoSize = true;
            lblDefensiveBonus.Location = new Point(21, 13);
            lblDefensiveBonus.Margin = new Padding(4, 0, 4, 0);
            lblDefensiveBonus.Name = "lblDefensiveBonus";
            lblDefensiveBonus.Size = new Size(133, 20);
            lblDefensiveBonus.TabIndex = 12;
            lblDefensiveBonus.Text = "Defensive Bonus:";
            // 
            // numDefensiveBonus
            // 
            numDefensiveBonus.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numDefensiveBonus.Location = new Point(183, 13);
            numDefensiveBonus.Margin = new Padding(4, 3, 4, 3);
            numDefensiveBonus.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numDefensiveBonus.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numDefensiveBonus.Name = "numDefensiveBonus";
            numDefensiveBonus.Size = new Size(117, 27);
            numDefensiveBonus.TabIndex = 13;
            numDefensiveBonus.TextAlign = HorizontalAlignment.Center;
            // 
            // grpDefMod
            // 
            grpDefMod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDefMod.Controls.Add(btnRemoveDefensiveModification);
            grpDefMod.Controls.Add(lblDefModConcept);
            grpDefMod.Controls.Add(txtDefModConcept);
            grpDefMod.Controls.Add(lblDefModBonus);
            grpDefMod.Controls.Add(numDefModBonus);
            grpDefMod.Controls.Add(btnAddDefensiveModification);
            grpDefMod.Controls.Add(lstDefensiveModifications);
            grpDefMod.Location = new Point(9, 80);
            grpDefMod.Margin = new Padding(4, 3, 4, 3);
            grpDefMod.Name = "grpDefMod";
            grpDefMod.Padding = new Padding(4, 3, 4, 3);
            grpDefMod.Size = new Size(707, 291);
            grpDefMod.TabIndex = 1;
            grpDefMod.TabStop = false;
            grpDefMod.Text = "Defensive Modifications";
            // 
            // btnRemoveDefensiveModification
            // 
            btnRemoveDefensiveModification.Location = new Point(531, 242);
            btnRemoveDefensiveModification.Margin = new Padding(4, 3, 4, 3);
            btnRemoveDefensiveModification.Name = "btnRemoveDefensiveModification";
            btnRemoveDefensiveModification.Size = new Size(154, 43);
            btnRemoveDefensiveModification.TabIndex = 7;
            btnRemoveDefensiveModification.Text = "Remove";
            btnRemoveDefensiveModification.UseVisualStyleBackColor = true;
            btnRemoveDefensiveModification.Click += BtnRemoveDefensiveModification_Click;
            // 
            // lblDefModConcept
            // 
            lblDefModConcept.AutoSize = true;
            lblDefModConcept.Location = new Point(12, 29);
            lblDefModConcept.Margin = new Padding(4, 0, 4, 0);
            lblDefModConcept.Name = "lblDefModConcept";
            lblDefModConcept.Size = new Size(72, 20);
            lblDefModConcept.TabIndex = 0;
            lblDefModConcept.Text = "Concept:";
            // 
            // txtDefModConcept
            // 
            txtDefModConcept.Location = new Point(103, 24);
            txtDefModConcept.Margin = new Padding(4, 3, 4, 3);
            txtDefModConcept.Name = "txtDefModConcept";
            txtDefModConcept.Size = new Size(209, 27);
            txtDefModConcept.TabIndex = 1;
            toolTip1.SetToolTip(txtDefModConcept, "free text entry. eg Normal Shield. Helm");
            // 
            // lblDefModBonus
            // 
            lblDefModBonus.AutoSize = true;
            lblDefModBonus.Location = new Point(320, 29);
            lblDefModBonus.Margin = new Padding(4, 0, 4, 0);
            lblDefModBonus.Name = "lblDefModBonus";
            lblDefModBonus.Size = new Size(58, 20);
            lblDefModBonus.TabIndex = 2;
            lblDefModBonus.Text = "Bonus:";
            // 
            // numDefModBonus
            // 
            numDefModBonus.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numDefModBonus.Location = new Point(394, 25);
            numDefModBonus.Margin = new Padding(4, 3, 4, 3);
            numDefModBonus.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numDefModBonus.Minimum = new decimal(new int[] { 25, 0, 0, int.MinValue });
            numDefModBonus.Name = "numDefModBonus";
            numDefModBonus.Size = new Size(117, 27);
            numDefModBonus.TabIndex = 3;
            numDefModBonus.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddDefensiveModification
            // 
            btnAddDefensiveModification.Location = new Point(518, 27);
            btnAddDefensiveModification.Margin = new Padding(4, 3, 4, 3);
            btnAddDefensiveModification.Name = "btnAddDefensiveModification";
            btnAddDefensiveModification.Size = new Size(88, 30);
            btnAddDefensiveModification.TabIndex = 4;
            btnAddDefensiveModification.Text = "Add";
            btnAddDefensiveModification.UseVisualStyleBackColor = true;
            btnAddDefensiveModification.Click += btnAddDefensiveModification_Click;
            // 
            // lstDefensiveModifications
            // 
            lstDefensiveModifications.FormattingEnabled = true;
            lstDefensiveModifications.Location = new Point(16, 63);
            lstDefensiveModifications.Margin = new Padding(4, 3, 4, 3);
            lstDefensiveModifications.Name = "lstDefensiveModifications";
            lstDefensiveModifications.Size = new Size(683, 164);
            lstDefensiveModifications.TabIndex = 5;
            lstDefensiveModifications.SelectedIndexChanged += lstDefensiveModifications_SelectedIndexChanged;
            // 
            // txtSplash
            // 
            txtSplash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSplash.BackColor = Color.Snow;
            txtSplash.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSplash.Location = new Point(15, 344);
            txtSplash.Margin = new Padding(4, 3, 4, 3);
            txtSplash.Multiline = true;
            txtSplash.Name = "txtSplash";
            txtSplash.ReadOnly = true;
            txtSplash.Size = new Size(500, 302);
            txtSplash.TabIndex = 2;
            txtSplash.Text = resources.GetString("txtSplash.Text");
            txtSplash.TextAlign = HorizontalAlignment.Center;
            // 
            // CreatureEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 436);
            Controls.Add(tabControl);
            Controls.Add(txtSplash);
            Controls.Add(mainMenu1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenu1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CreatureEditForm";
            Text = "CreatureEditForm";
            mainMenu1.ResumeLayout(false);
            mainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAttackBonus).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAttackSizeAdj).EndInit();
            tabSkills.ResumeLayout(false);
            grpSkills.ResumeLayout(false);
            grpSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSkillRanks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSkillBonus).EndInit();
            tabCombat.ResumeLayout(false);
            grpAttacks.ResumeLayout(false);
            grpAttacks.PerformLayout();
            tabLevelResist.ResumeLayout(false);
            tabLevelResist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpResist.ResumeLayout(false);
            grpResist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numResistBonus).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBaseHits).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAverageLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBaseMovement).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAttackQuickness).EndInit();
            tabBasicInfo.ResumeLayout(false);
            tabBasicInfo.PerformLayout();
            tabControl.ResumeLayout(false);
            tabDefence.ResumeLayout(false);
            tabDefence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numArmorType).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDefensiveBonus).EndInit();
            grpDefMod.ResumeLayout(false);
            grpDefMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDefModBonus).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu1;

        // Tab Controls
        private System.Windows.Forms.TabControl tabControl1;

        // Attacks
        private System.Windows.Forms.Label lblAttackName;
        private System.Windows.Forms.Label lblAttackTableName;
        private System.Windows.Forms.TextBox txtAttackName;
        private System.Windows.Forms.Label lblAttackBonus;
        private System.Windows.Forms.NumericUpDown numAttackBonus;
        private System.Windows.Forms.Label lblAttackSizeAdj;
        private System.Windows.Forms.NumericUpDown numAttackSizeAdj;
        private System.Windows.Forms.Button btnAddAttack;
        private System.Windows.Forms.ListBox lstAttacks;
        private System.Windows.Forms.Button btnRemoveAttack;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.GroupBox grpSkills;
        private System.Windows.Forms.Label lblSkillName;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.Label lblSkillTableName;
        private System.Windows.Forms.TextBox txtSkillTableName;
        private System.Windows.Forms.Label lblSkillRanks;
        private System.Windows.Forms.NumericUpDown numSkillRanks;
        private System.Windows.Forms.Label lblSkillBonus;
        private System.Windows.Forms.NumericUpDown numSkillBonus;
        private System.Windows.Forms.Button btnAddSkill;
        private System.Windows.Forms.ListBox lstSkills;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.TabPage tabCombat;
        private System.Windows.Forms.TabPage tabLevelResist;
        private System.Windows.Forms.Label lblAverageLevel;
        private System.Windows.Forms.NumericUpDown numAverageLevel;
        private System.Windows.Forms.Label lblBaseMovement;
        private System.Windows.Forms.NumericUpDown numBaseMovement;
        private System.Windows.Forms.Label lblAttackQuickness;
        private System.Windows.Forms.NumericUpDown numAttackQuickness;
        private System.Windows.Forms.TabPage tabBasicInfo;
        private System.Windows.Forms.Label lblCreatureName;
        private System.Windows.Forms.TextBox txtCreatureName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblBaseHits;
        private System.Windows.Forms.NumericUpDown numBaseHits;
        private System.Windows.Forms.TabPage tabDefence;
        private System.Windows.Forms.Label lblArmorType;
        private System.Windows.Forms.NumericUpDown numArmorType;
        private System.Windows.Forms.Label lblDefensiveBonus;
        private System.Windows.Forms.NumericUpDown numDefensiveBonus;
        private System.Windows.Forms.GroupBox grpDefMod;
        private System.Windows.Forms.Label lblDefModConcept;
        private System.Windows.Forms.TextBox txtDefModConcept;
        private System.Windows.Forms.Label lblDefModBonus;
        private System.Windows.Forms.NumericUpDown numDefModBonus;
        private System.Windows.Forms.Button btnAddDefensiveModification;
        private System.Windows.Forms.ListBox lstDefensiveModifications;
        private System.Windows.Forms.GroupBox grpResist;
        private System.Windows.Forms.Label lblResistConcept;
        private System.Windows.Forms.Label lblResistBonus;
        private System.Windows.Forms.NumericUpDown numResistBonus;
        private System.Windows.Forms.Button btnAddResistanceRollBonus;
        private System.Windows.Forms.ListBox lstResistanceRollBonuses;
        private System.Windows.Forms.Button btnRemoveResistanceRollBonus;
        private System.Windows.Forms.GroupBox grpAttacks;
        
        private System.Windows.Forms.ComboBox cboResistConcept;
        private System.Windows.Forms.ComboBox cboAttackTableName;
        private System.Windows.Forms.TextBox txtSplash;
        private System.Windows.Forms.Button btnRemoveDefensiveModification;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private ToolStripMenuItem toolStripMenuItemNew;
        private ToolStripMenuItem toolStripMenuItemLoad;
        private ToolStripMenuItem toolStripMenuItemSave;
        private ToolStripMenuItem toolStripMenuItemSaveAs;
        private ToolStripMenuItem toolStripMenuItemQuit;
    }
}
