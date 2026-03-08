namespace CreatureXmlEditor
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            //this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasicInfo = new System.Windows.Forms.TabPage();
            this.tabLevelMovement = new System.Windows.Forms.TabPage();
            this.tabCombat = new System.Windows.Forms.TabPage();
            this.tabSkills = new System.Windows.Forms.TabPage();

            // Controls for Basic Info Tab
            this.lblCreatureName = new System.Windows.Forms.Label();
            this.txtCreatureName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();

            // Controls for Level & Movement Tab
            this.lblAverageLevel = new System.Windows.Forms.Label();
            this.numAverageLevel = new System.Windows.Forms.NumericUpDown();
            this.lblBaseMovement = new System.Windows.Forms.Label();
            this.numBaseMovement = new System.Windows.Forms.NumericUpDown();
            this.lblAttackQuickness = new System.Windows.Forms.Label();
            this.numAttackQuickness = new System.Windows.Forms.NumericUpDown();

            // Controls for Combat Tab
            this.lblArmorType = new System.Windows.Forms.Label();
            this.numArmorType = new System.Windows.Forms.NumericUpDown();
            this.lblDefensiveBonus = new System.Windows.Forms.Label();
            this.numDefensiveBonus = new System.Windows.Forms.NumericUpDown();
            this.lblBaseHits = new System.Windows.Forms.Label();
            this.numBaseHits = new System.Windows.Forms.NumericUpDown();

            // Defensive Modifications
            this.lblDefModConcept = new System.Windows.Forms.Label();
            this.txtDefModConcept = new System.Windows.Forms.TextBox();
            this.lblDefModBonus = new System.Windows.Forms.Label();
            this.numDefModBonus = new System.Windows.Forms.NumericUpDown();
            this.btnAddDefensiveModification = new System.Windows.Forms.Button();
            this.lstDefensiveModifications = new System.Windows.Forms.ListBox();
            this.btnRemoveDefensiveModification = new System.Windows.Forms.Button();

            // Resistance Roll Bonuses
            this.lblResistConcept = new System.Windows.Forms.Label();
            this.txtResistConcept = new System.Windows.Forms.TextBox();
            this.lblResistBonus = new System.Windows.Forms.Label();
            this.numResistBonus = new System.Windows.Forms.NumericUpDown();
            this.btnAddResistanceRollBonus = new System.Windows.Forms.Button();
            this.lstResistanceRollBonuses = new System.Windows.Forms.ListBox();
            this.btnRemoveResistanceRollBonus = new System.Windows.Forms.Button();

            // Attacks
            this.lblAttackName = new System.Windows.Forms.Label();
            this.txtAttackName = new System.Windows.Forms.TextBox();
            this.lblAttackTableName = new System.Windows.Forms.Label();
            this.txtAttackTableName = new System.Windows.Forms.TextBox();
            this.lblAttackBonus = new System.Windows.Forms.Label();
            this.numAttackBonus = new System.Windows.Forms.NumericUpDown();
            this.lblAttackSizeAdj = new System.Windows.Forms.Label();
            this.numAttackSizeAdj = new System.Windows.Forms.NumericUpDown();
            this.btnAddAttack = new System.Windows.Forms.Button();
            this.lstAttacks = new System.Windows.Forms.ListBox();
            this.btnRemoveAttack = new System.Windows.Forms.Button();

            // Skills
            this.lblSkillName = new System.Windows.Forms.Label();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.lblSkillTableName = new System.Windows.Forms.Label();
            this.txtSkillTableName = new System.Windows.Forms.TextBox();
            this.lblSkillRanks = new System.Windows.Forms.Label();
            this.numSkillRanks = new System.Windows.Forms.NumericUpDown();
            this.lblSkillBonus = new System.Windows.Forms.Label();
            this.numSkillBonus = new System.Windows.Forms.NumericUpDown();
            this.btnAddSkill = new System.Windows.Forms.Button();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.btnRemoveSkill = new System.Windows.Forms.Button();

/*            ((System.ComponentModel.ISupportInitialize)(this.numAverageLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackQuickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensiveBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefModBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResistBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackSizeAdj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillRanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillBonus)).BeginInit();

            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBasicInfo.SuspendLayout();
            this.tabLevelMovement.SuspendLayout();
            this.tabCombat.SuspendLayout();
            this.tabSkills.SuspendLayout();
            this.SuspendLayout();
*/
            // ===== MENU STRIP =====
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // File Menu
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";

            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.BtnNew_Click);

            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.BtnOpen_Click);

            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.BtnSave_Click);

            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.BtnSaveAs_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);

            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            

            // ===== TAB CONTROL =====
            this.tabControl1.Controls.Add(this.tabBasicInfo);
            this.tabControl1.Controls.Add(this.tabLevelMovement);
            this.tabControl1.Controls.Add(this.tabCombat);
            this.tabControl1.Controls.Add(this.tabSkills);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 576);
            this.tabControl1.TabIndex = 1;

            // ===== TAB 1: BASIC INFO =====
            this.tabBasicInfo.Location = new System.Drawing.Point(4, 22);
            this.tabBasicInfo.Name = "tabBasicInfo";
            this.tabBasicInfo.Padding = new System.Windows.Forms.Padding(10);
            this.tabBasicInfo.Size = new System.Drawing.Size(992, 550);
            this.tabBasicInfo.TabIndex = 0;
            this.tabBasicInfo.Text = "Basic Info";
            this.tabBasicInfo.UseVisualStyleBackColor = true;

            // Creature Name
            this.lblCreatureName.AutoSize = true;
            this.lblCreatureName.Location = new System.Drawing.Point(20, 25);
            this.lblCreatureName.Name = "lblCreatureName";
            this.lblCreatureName.Size = new System.Drawing.Size(87, 13);
            this.lblCreatureName.TabIndex = 0;
            this.lblCreatureName.Text = "Creature Name:";
            this.tabBasicInfo.Controls.Add(this.lblCreatureName);

            this.txtCreatureName.Location = new System.Drawing.Point(120, 22);
            this.txtCreatureName.Name = "txtCreatureName";
            this.txtCreatureName.Size = new System.Drawing.Size(300, 20);
            this.txtCreatureName.TabIndex = 1;
            this.txtCreatureName.TextChanged += new System.EventHandler(this.TextChanged_Handler);
            this.tabBasicInfo.Controls.Add(this.txtCreatureName);

            // Category
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            this.tabBasicInfo.Controls.Add(this.lblCategory);

            this.txtCategory.Location = new System.Drawing.Point(120, 57);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(300, 20);
            this.txtCategory.TabIndex = 3;
            this.txtCategory.TextChanged += new System.EventHandler(this.TextChanged_Handler);
            this.tabBasicInfo.Controls.Add(this.txtCategory);

            // Description
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            this.tabBasicInfo.Controls.Add(this.lblDescription);

            this.txtDescription.Location = new System.Drawing.Point(120, 95);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(600, 200);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Multiline = true;
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.TextChanged += new System.EventHandler(this.TextChanged_Handler);
            this.tabBasicInfo.Controls.Add(this.txtDescription);

            // ===== TAB 2: LEVEL & MOVEMENT =====
            this.tabLevelMovement.Location = new System.Drawing.Point(4, 22);
            this.tabLevelMovement.Name = "tabLevelMovement";
            this.tabLevelMovement.Padding = new System.Windows.Forms.Padding(10);
            this.tabLevelMovement.Size = new System.Drawing.Size(992, 550);
            this.tabLevelMovement.TabIndex = 1;
            this.tabLevelMovement.Text = "Level & Movement";
            this.tabLevelMovement.UseVisualStyleBackColor = true;

            // Average Level
            this.lblAverageLevel.AutoSize = true;
            this.lblAverageLevel.Location = new System.Drawing.Point(20, 25);
            this.lblAverageLevel.Name = "lblAverageLevel";
            this.lblAverageLevel.Size = new System.Drawing.Size(81, 13);
            this.lblAverageLevel.TabIndex = 0;
            this.lblAverageLevel.Text = "Average Level:";
            this.tabLevelMovement.Controls.Add(this.lblAverageLevel);

            this.numAverageLevel.Location = new System.Drawing.Point(120, 22);
            this.numAverageLevel.Name = "numAverageLevel";
            this.numAverageLevel.Size = new System.Drawing.Size(100, 20);
            this.numAverageLevel.TabIndex = 1;
            this.numAverageLevel.ValueChanged += new System.EventHandler(this.NumericChanged_Handler);
            this.tabLevelMovement.Controls.Add(this.numAverageLevel);

            // Base Movement
            this.lblBaseMovement.AutoSize = true;
            this.lblBaseMovement.Location = new System.Drawing.Point(20, 70);
            this.lblBaseMovement.Name = "lblBaseMovement";
            this.lblBaseMovement.Size = new System.Drawing.Size(89, 13);
            this.lblBaseMovement.TabIndex = 2;
            this.lblBaseMovement.Text = "Base Movement:";
            this.tabLevelMovement.Controls.Add(this.lblBaseMovement);

            this.numBaseMovement.Location = new System.Drawing.Point(120, 67);
            this.numBaseMovement.Name = "numBaseMovement";
            this.numBaseMovement.Size = new System.Drawing.Size(100, 20);
            this.numBaseMovement.TabIndex = 3;
            this.numBaseMovement.Value = 20;
            this.numBaseMovement.ValueChanged += new System.EventHandler(this.NumericChanged_Handler);
            this.tabLevelMovement.Controls.Add(this.numBaseMovement);

            // Attack Quickness
            this.lblAttackQuickness.AutoSize = true;
            this.lblAttackQuickness.Location = new System.Drawing.Point(20, 115);
            this.lblAttackQuickness.Name = "lblAttackQuickness";
            this.lblAttackQuickness.Size = new System.Drawing.Size(94, 13);
            this.lblAttackQuickness.TabIndex = 4;
            this.lblAttackQuickness.Text = "Attack Quickness:";
            this.tabLevelMovement.Controls.Add(this.lblAttackQuickness);

            this.numAttackQuickness.Location = new System.Drawing.Point(120, 112);
            this.numAttackQuickness.Name = "numAttackQuickness";
            this.numAttackQuickness.Size = new System.Drawing.Size(100, 20);
            this.numAttackQuickness.TabIndex = 5;
            this.numAttackQuickness.Value = 5;
            this.numAttackQuickness.ValueChanged += new System.EventHandler(this.NumericChanged_Handler);
            this.tabLevelMovement.Controls.Add(this.numAttackQuickness);

            // ===== TAB 3: COMBAT =====
            this.tabCombat.AutoScroll = true;
            this.tabCombat.Location = new System.Drawing.Point(4, 22);
            this.tabCombat.Name = "tabCombat";
            this.tabCombat.Padding = new System.Windows.Forms.Padding(10);
            this.tabCombat.Size = new System.Drawing.Size(992, 550);
            this.tabCombat.TabIndex = 2;
            this.tabCombat.Text = "Combat";
            this.tabCombat.UseVisualStyleBackColor = true;

            int combatYPos = 10;

            // Armor Type
            this.lblArmorType.AutoSize = true;
            this.lblArmorType.Location = new System.Drawing.Point(20, combatYPos + 5);
            this.lblArmorType.Name = "lblArmorType";
            this.lblArmorType.Size = new System.Drawing.Size(67, 13);
            this.lblArmorType.TabIndex = 0;
            this.lblArmorType.Text = "Armor Type:";
            this.tabCombat.Controls.Add(this.lblArmorType);

            this.numArmorType.Location = new System.Drawing.Point(120, combatYPos + 2);
            this.numArmorType.Name = "numArmorType";
            this.numArmorType.Size = new System.Drawing.Size(100, 20);
            this.numArmorType.TabIndex = 1;
            this.numArmorType.ValueChanged += new System.EventHandler(this.NumericChanged_Handler);
            this.tabCombat.Controls.Add(this.numArmorType);

            combatYPos += 35;

            // Defensive Bonus
            this.lblDefensiveBonus.AutoSize = true;
            this.lblDefensiveBonus.Location = new System.Drawing.Point(20, combatYPos + 5);
            this.lblDefensiveBonus.Name = "lblDefensiveBonus";
            this.lblDefensiveBonus.Size = new System.Drawing.Size(90, 13);
            this.lblDefensiveBonus.TabIndex = 2;
            this.lblDefensiveBonus.Text = "Defensive Bonus:";
            this.tabCombat.Controls.Add(this.lblDefensiveBonus);

            this.numDefensiveBonus.Location = new System.Drawing.Point(120, combatYPos + 2);
            this.numDefensiveBonus.Name = "numDefensiveBonus";
            this.numDefensiveBonus.Size = new System.Drawing.Size(100, 20);
            this.numDefensiveBonus.TabIndex = 3;
            this.numDefensiveBonus.ValueChanged += new System.EventHandler(this.NumericChanged_Handler);
            this.tabCombat.Controls.Add(this.numDefensiveBonus);

            combatYPos += 35;

            // Base Hits
            this.lblBaseHits.AutoSize = true;
            this.lblBaseHits.Location = new System.Drawing.Point(20, combatYPos + 5);
            this.lblBaseHits.Name = "lblBaseHits";
            this.lblBaseHits.Size = new System.Drawing.Size(61, 13);
            this.lblBaseHits.TabIndex = 4;
            this.lblBaseHits.Text = "Base Hits:";
            this.tabCombat.Controls.Add(this.lblBaseHits);

            this.numBaseHits.Location = new System.Drawing.Point(120, combatYPos + 2);
            this.numBaseHits.Name = "numBaseHits";
            this.numBaseHits.Size = new System.Drawing.Size(100, 20);
            this.numBaseHits.TabIndex = 5;
            this.numBaseHits.ValueChanged += new System.EventHandler(this.NumericChanged_Handler);
            this.tabCombat.Controls.Add(this.numBaseHits);

            combatYPos += 50;

            // ===== DEFENSIVE MODIFICATIONS =====
            System.Windows.Forms.GroupBox grpDefMod = new System.Windows.Forms.GroupBox();
            grpDefMod.Text = "Defensive Modifications";
            grpDefMod.Location = new System.Drawing.Point(10, combatYPos);
            grpDefMod.Size = new System.Drawing.Size(960, 180);
            this.tabCombat.Controls.Add(grpDefMod);

            this.lblDefModConcept.AutoSize = true;
            this.lblDefModConcept.Location = new System.Drawing.Point(10, 25);
            this.lblDefModConcept.Name = "lblDefModConcept";
            this.lblDefModConcept.Size = new System.Drawing.Size(56, 13);
            this.lblDefModConcept.TabIndex = 0;
            this.lblDefModConcept.Text = "Concept:";
            grpDefMod.Controls.Add(this.lblDefModConcept);

            this.txtDefModConcept.Location = new System.Drawing.Point(75, 22);
            this.txtDefModConcept.Name = "txtDefModConcept";
            this.txtDefModConcept.Size = new System.Drawing.Size(150, 20);
            this.txtDefModConcept.TabIndex = 1;
            grpDefMod.Controls.Add(this.txtDefModConcept);

            this.lblDefModBonus.AutoSize = true;
            this.lblDefModBonus.Location = new System.Drawing.Point(235, 25);
            this.lblDefModBonus.Name = "lblDefModBonus";
            this.lblDefModBonus.Size = new System.Drawing.Size(41, 13);
            this.lblDefModBonus.TabIndex = 2;
            this.lblDefModBonus.Text = "Bonus:";
            grpDefMod.Controls.Add(this.lblDefModBonus);

            this.numDefModBonus.Location = new System.Drawing.Point(285, 22);
            this.numDefModBonus.Name = "numDefModBonus";
            this.numDefModBonus.Size = new System.Drawing.Size(100, 20);
            this.numDefModBonus.TabIndex = 3;
            grpDefMod.Controls.Add(this.numDefModBonus);

            this.btnAddDefensiveModification.Location = new System.Drawing.Point(395, 22);
            this.btnAddDefensiveModification.Name = "btnAddDefensiveModification";
            this.btnAddDefensiveModification.Size = new System.Drawing.Size(75, 23);
            this.btnAddDefensiveModification.TabIndex = 4;
            this.btnAddDefensiveModification.Text = "Add";
            this.btnAddDefensiveModification.UseVisualStyleBackColor = true;
            this.btnAddDefensiveModification.Click += new System.EventHandler(this.btnAddDefensiveModification_Click);
            grpDefMod.Controls.Add(this.btnAddDefensiveModification);

            this.lstDefensiveModifications.FormattingEnabled = true;
            this.lstDefensiveModifications.Location = new System.Drawing.Point(10, 50);
            this.lstDefensiveModifications.Name = "lstDefensiveModifications";
            this.lstDefensiveModifications.Size = new System.Drawing.Size(460, 95);
            this.lstDefensiveModifications.TabIndex = 5;
            grpDefMod.Controls.Add(this.lstDefensiveModifications);

            this.btnRemoveDefensiveModification.Location = new System.Drawing.Point(395, 152);
            this.btnRemoveDefensiveModification.Name = "btnRemoveDefensiveModification";
            this.btnRemoveDefensiveModification.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDefensiveModification.TabIndex = 6;
            this.btnRemoveDefensiveModification.Text = "Remove";
            this.btnRemoveDefensiveModification.UseVisualStyleBackColor = true;
            this.btnRemoveDefensiveModification.Click += new System.EventHandler(this.BtnRemoveDefensiveModification_Click);
            grpDefMod.Controls.Add(this.btnRemoveDefensiveModification);

            combatYPos += 200;

            // ===== RESISTANCE ROLL BONUSES =====
            System.Windows.Forms.GroupBox grpResist = new System.Windows.Forms.GroupBox();
            grpResist.Text = "Resistance Roll Bonuses";
            grpResist.Location = new System.Drawing.Point(10, combatYPos);
            grpResist.Size = new System.Drawing.Size(960, 180);
            this.tabCombat.Controls.Add(grpResist);

            this.lblResistConcept.AutoSize = true;
            this.lblResistConcept.Location = new System.Drawing.Point(10, 25);
            this.lblResistConcept.Name = "lblResistConcept";
            this.lblResistConcept.Size = new System.Drawing.Size(56, 13);
            this.lblResistConcept.TabIndex = 0;
            this.lblResistConcept.Text = "Concept:";
            grpResist.Controls.Add(this.lblResistConcept);

            this.txtResistConcept.Location = new System.Drawing.Point(75, 22);
            this.txtResistConcept.Name = "txtResistConcept";
            this.txtResistConcept.Size = new System.Drawing.Size(150, 20);
            this.txtResistConcept.TabIndex = 1;
            grpResist.Controls.Add(this.txtResistConcept);

            this.lblResistBonus.AutoSize = true;
            this.lblResistBonus.Location = new System.Drawing.Point(235, 25);
            this.lblResistBonus.Name = "lblResistBonus";
            this.lblResistBonus.Size = new System.Drawing.Size(41, 13);
            this.lblResistBonus.TabIndex = 2;
            this.lblResistBonus.Text = "Bonus:";
            grpResist.Controls.Add(this.lblResistBonus);

            this.numResistBonus.Location = new System.Drawing.Point(285, 22);
            this.numResistBonus.Name = "numResistBonus";
            this.numResistBonus.Size = new System.Drawing.Size(100, 20);
            this.numResistBonus.TabIndex = 3;
            grpResist.Controls.Add(this.numResistBonus);

            this.btnAddResistanceRollBonus.Location = new System.Drawing.Point(395, 22);
            this.btnAddResistanceRollBonus.Name = "btnAddResistanceRollBonus";
            this.btnAddResistanceRollBonus.Size = new System.Drawing.Size(75, 23);
            this.btnAddResistanceRollBonus.TabIndex = 4;
            this.btnAddResistanceRollBonus.Text = "Add";
            this.btnAddResistanceRollBonus.UseVisualStyleBackColor = true;
            this.btnAddResistanceRollBonus.Click += new System.EventHandler(this.BtnAddResistanceRollBonus_Click);
            grpResist.Controls.Add(this.btnAddResistanceRollBonus);

            this.lstResistanceRollBonuses.FormattingEnabled = true;
            this.lstResistanceRollBonuses.Location = new System.Drawing.Point(10, 50);
            this.lstResistanceRollBonuses.Name = "lstResistanceRollBonuses";
            this.lstResistanceRollBonuses.Size = new System.Drawing.Size(460, 95);
            this.lstResistanceRollBonuses.TabIndex = 5;
            grpResist.Controls.Add(this.lstResistanceRollBonuses);

            this.btnRemoveResistanceRollBonus.Location = new System.Drawing.Point(395, 152);
            this.btnRemoveResistanceRollBonus.Name = "btnRemoveResistanceRollBonus";
            this.btnRemoveResistanceRollBonus.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveResistanceRollBonus.TabIndex = 6;
            this.btnRemoveResistanceRollBonus.Text = "Remove";
            this.btnRemoveResistanceRollBonus.UseVisualStyleBackColor = true;
            this.btnRemoveResistanceRollBonus.Click += new System.EventHandler(this.BtnRemoveResistanceRollBonus_Click);
            grpResist.Controls.Add(this.btnRemoveResistanceRollBonus);

            combatYPos += 200;

            // ===== ATTACKS =====
            System.Windows.Forms.GroupBox grpAttacks = new System.Windows.Forms.GroupBox();
            grpAttacks.Text = "Attacks";
            grpAttacks.Location = new System.Drawing.Point(10, combatYPos);
            grpAttacks.Size = new System.Drawing.Size(960, 250);
            this.tabCombat.Controls.Add(grpAttacks);

            this.lblAttackName.AutoSize = true;
            this.lblAttackName.Location = new System.Drawing.Point(10, 25);
            this.lblAttackName.Name = "lblAttackName";
            this.lblAttackName.Size = new System.Drawing.Size(38, 13);
            this.lblAttackName.TabIndex = 0;
            this.lblAttackName.Text = "Name:";
            grpAttacks.Controls.Add(this.lblAttackName);

            this.txtAttackName.Location = new System.Drawing.Point(60, 22);
            this.txtAttackName.Name = "txtAttackName";
            this.txtAttackName.Size = new System.Drawing.Size(150, 20);
            this.txtAttackName.TabIndex = 1;
            grpAttacks.Controls.Add(this.txtAttackName);

            this.lblAttackTableName.AutoSize = true;
            this.lblAttackTableName.Location = new System.Drawing.Point(220, 25);
            this.lblAttackTableName.Name = "lblAttackTableName";
            this.lblAttackTableName.Size = new System.Drawing.Size(38, 13);
            this.lblAttackTableName.TabIndex = 2;
            this.lblAttackTableName.Text = "Table:";
            grpAttacks.Controls.Add(this.lblAttackTableName);

            this.txtAttackTableName.Location = new System.Drawing.Point(265, 22);
            this.txtAttackTableName.Name = "txtAttackTableName";
            this.txtAttackTableName.Size = new System.Drawing.Size(120, 20);
            this.txtAttackTableName.TabIndex = 3;
            grpAttacks.Controls.Add(this.txtAttackTableName);

            this.lblAttackBonus.AutoSize = true;
            this.lblAttackBonus.Location = new System.Drawing.Point(10, 55);
            this.lblAttackBonus.Name = "lblAttackBonus";
            this.lblAttackBonus.Size = new System.Drawing.Size(41, 13);
            this.lblAttackBonus.TabIndex = 4;
            this.lblAttackBonus.Text = "Bonus:";
            grpAttacks.Controls.Add(this.lblAttackBonus);

            this.numAttackBonus.Location = new System.Drawing.Point(60, 52);
            this.numAttackBonus.Name = "numAttackBonus";
            this.numAttackBonus.Size = new System.Drawing.Size(100, 20);
            this.numAttackBonus.TabIndex = 5;
            grpAttacks.Controls.Add(this.numAttackBonus);

            this.lblAttackSizeAdj.AutoSize = true;
            this.lblAttackSizeAdj.Location = new System.Drawing.Point(170, 55);
            this.lblAttackSizeAdj.Name = "lblAttackSizeAdj";
            this.lblAttackSizeAdj.Size = new System.Drawing.Size(68, 13);
            this.lblAttackSizeAdj.TabIndex = 6;
            this.lblAttackSizeAdj.Text = "Size Adjust:";
            grpAttacks.Controls.Add(this.lblAttackSizeAdj);

            this.numAttackSizeAdj.Location = new System.Drawing.Point(245, 52);
            this.numAttackSizeAdj.Name = "numAttackSizeAdj";
            this.numAttackSizeAdj.Size = new System.Drawing.Size(100, 20);
            this.numAttackSizeAdj.TabIndex = 7;
            grpAttacks.Controls.Add(this.numAttackSizeAdj);

            this.btnAddAttack.Location = new System.Drawing.Point(395, 37);
            this.btnAddAttack.Name = "btnAddAttack";
            this.btnAddAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAddAttack.TabIndex = 8;
            this.btnAddAttack.Text = "Add";
            this.btnAddAttack.UseVisualStyleBackColor = true;
            this.btnAddAttack.Click += new System.EventHandler(this.BtnAddAttack_Click);
            grpAttacks.Controls.Add(this.btnAddAttack);

            this.lstAttacks.FormattingEnabled = true;
            this.lstAttacks.Location = new System.Drawing.Point(10, 80);
            this.lstAttacks.Name = "lstAttacks";
            this.lstAttacks.Size = new System.Drawing.Size(460, 134);
            this.lstAttacks.TabIndex = 9;
            grpAttacks.Controls.Add(this.lstAttacks);

            this.btnRemoveAttack.Location = new System.Drawing.Point(395, 220);
            this.btnRemoveAttack.Name = "btnRemoveAttack";
            this.btnRemoveAttack.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAttack.TabIndex = 10;
            this.btnRemoveAttack.Text = "Remove";
            this.btnRemoveAttack.UseVisualStyleBackColor = true;
            this.btnRemoveAttack.Click += new System.EventHandler(this.BtnRemoveAttack_Click);
            grpAttacks.Controls.Add(this.btnRemoveAttack);

            // ===== TAB 4: SKILLS =====
            this.tabSkills.AutoScroll = true;
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(10);
            this.tabSkills.Size = new System.Drawing.Size(992, 550);
            this.tabSkills.TabIndex = 3;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;

            System.Windows.Forms.GroupBox grpSkills = new System.Windows.Forms.GroupBox();
            grpSkills.Text = "Maneuver Skills";
            grpSkills.Location = new System.Drawing.Point(10, 10);
            grpSkills.Size = new System.Drawing.Size(960, 300);
            this.tabSkills.Controls.Add(grpSkills);

            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Location = new System.Drawing.Point(10, 25);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(38, 13);
            this.lblSkillName.TabIndex = 0;
            this.lblSkillName.Text = "Name:";
            grpSkills.Controls.Add(this.lblSkillName);

            this.txtSkillName.Location = new System.Drawing.Point(60, 22);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(150, 20);
            this.txtSkillName.TabIndex = 1;
            grpSkills.Controls.Add(this.txtSkillName);

            this.lblSkillTableName.AutoSize = true;
            this.lblSkillTableName.Location = new System.Drawing.Point(220, 25);
            this.lblSkillTableName.Name = "lblSkillTableName";
            this.lblSkillTableName.Size = new System.Drawing.Size(38, 13);
            this.lblSkillTableName.TabIndex = 2;
            this.lblSkillTableName.Text = "Table:";
            grpSkills.Controls.Add(this.lblSkillTableName);

            this.txtSkillTableName.Location = new System.Drawing.Point(265, 22);
            this.txtSkillTableName.Name = "txtSkillTableName";
            this.txtSkillTableName.Size = new System.Drawing.Size(120, 20);
            this.txtSkillTableName.TabIndex = 3;
            grpSkills.Controls.Add(this.txtSkillTableName);

            this.lblSkillRanks.AutoSize = true;
            this.lblSkillRanks.Location = new System.Drawing.Point(10, 55);
            this.lblSkillRanks.Name = "lblSkillRanks";
            this.lblSkillRanks.Size = new System.Drawing.Size(41, 13);
            this.lblSkillRanks.TabIndex = 4;
            this.lblSkillRanks.Text = "Ranks:";
            grpSkills.Controls.Add(this.lblSkillRanks);

            this.numSkillRanks.Location = new System.Drawing.Point(60, 52);
            this.numSkillRanks.Name = "numSkillRanks";
            this.numSkillRanks.Size = new System.Drawing.Size(100, 20);
            this.numSkillRanks.TabIndex = 5;
            grpSkills.Controls.Add(this.numSkillRanks);

            this.lblSkillBonus.AutoSize = true;
            this.lblSkillBonus.Location = new System.Drawing.Point(170, 55);
            this.lblSkillBonus.Name = "lblSkillBonus";
            this.lblSkillBonus.Size = new System.Drawing.Size(41, 13);
            this.lblSkillBonus.TabIndex = 6;
            this.lblSkillBonus.Text = "Bonus:";
            grpSkills.Controls.Add(this.lblSkillBonus);

            this.numSkillBonus.Location = new System.Drawing.Point(220, 52);
            this.numSkillBonus.Name = "numSkillBonus";
            this.numSkillBonus.Size = new System.Drawing.Size(100, 20);
            this.numSkillBonus.TabIndex = 7;
            grpSkills.Controls.Add(this.numSkillBonus);

            this.btnAddSkill.Location = new System.Drawing.Point(395, 37);
            this.btnAddSkill.Name = "btnAddSkill";
            this.btnAddSkill.Size = new System.Drawing.Size(75, 23);
            this.btnAddSkill.TabIndex = 8;
            this.btnAddSkill.Text = "Add";
            this.btnAddSkill.UseVisualStyleBackColor = true;
            this.btnAddSkill.Click += new System.EventHandler(this.BtnAddSkill_Click);
            grpSkills.Controls.Add(this.btnAddSkill);

            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.Location = new System.Drawing.Point(10, 80);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(460, 180);
            this.lstSkills.TabIndex = 9;
            grpSkills.Controls.Add(this.lstSkills);

            this.btnRemoveSkill.Location = new System.Drawing.Point(395, 260);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSkill.TabIndex = 10;
            this.btnRemoveSkill.Text = "Remove";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.BtnRemoveSkill_Click);
            grpSkills.Controls.Add(this.btnRemoveSkill);

            // ===== MAIN FORM =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Creature XML Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);

/*            ((System.ComponentModel.ISupportInitialize)(this.numAverageLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackQuickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArmorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensiveBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefModBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResistBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackSizeAdj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillRanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkillBonus)).EndInit();
*/
/*            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBasicInfo.ResumeLayout(false);
            this.tabBasicInfo.PerformLayout();
            this.tabLevelMovement.ResumeLayout(false);
            this.tabLevelMovement.PerformLayout();
            this.tabCombat.ResumeLayout(false);
            this.tabCombat.PerformLayout();
            this.tabSkills.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();*/
        }

        // Menu Strip Controls
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        // Tab Controls
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasicInfo;
        private System.Windows.Forms.TabPage tabLevelMovement;
        private System.Windows.Forms.TabPage tabCombat;
        private System.Windows.Forms.TabPage tabSkills;

        // Basic Info Controls
        private System.Windows.Forms.Label lblCreatureName;
        private System.Windows.Forms.TextBox txtCreatureName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;

        // Level & Movement Controls
        private System.Windows.Forms.Label lblAverageLevel;
        private System.Windows.Forms.NumericUpDown numAverageLevel;
        private System.Windows.Forms.Label lblBaseMovement;
        private System.Windows.Forms.NumericUpDown numBaseMovement;
        private System.Windows.Forms.Label lblAttackQuickness;
        private System.Windows.Forms.NumericUpDown numAttackQuickness;

        // Combat Controls
        private System.Windows.Forms.Label lblArmorType;
        private System.Windows.Forms.NumericUpDown numArmorType;
        private System.Windows.Forms.Label lblDefensiveBonus;
        private System.Windows.Forms.NumericUpDown numDefensiveBonus;
        private System.Windows.Forms.Label lblBaseHits;
        private System.Windows.Forms.NumericUpDown numBaseHits;

        // Defensive Modifications
        private System.Windows.Forms.Label lblDefModConcept;
        private System.Windows.Forms.TextBox txtDefModConcept;
        private System.Windows.Forms.Label lblDefModBonus;
        private System.Windows.Forms.NumericUpDown numDefModBonus;
        private System.Windows.Forms.Button btnAddDefensiveModification;
        private System.Windows.Forms.ListBox lstDefensiveModifications;
        private System.Windows.Forms.Button btnRemoveDefensiveModification;

        // Resistance Roll Bonuses
        private System.Windows.Forms.Label lblResistConcept;
        private System.Windows.Forms.TextBox txtResistConcept;
        private System.Windows.Forms.Label lblResistBonus;
        private System.Windows.Forms.NumericUpDown numResistBonus;
        private System.Windows.Forms.Button btnAddResistanceRollBonus;
        private System.Windows.Forms.ListBox lstResistanceRollBonuses;
        private System.Windows.Forms.Button btnRemoveResistanceRollBonus;

        // Attacks
        private System.Windows.Forms.Label lblAttackName;
        private System.Windows.Forms.TextBox txtAttackName;
        private System.Windows.Forms.Label lblAttackTableName;
        private System.Windows.Forms.TextBox txtAttackTableName;
        private System.Windows.Forms.Label lblAttackBonus;
        private System.Windows.Forms.NumericUpDown numAttackBonus;
        private System.Windows.Forms.Label lblAttackSizeAdj;
        private System.Windows.Forms.NumericUpDown numAttackSizeAdj;
        private System.Windows.Forms.Button btnAddAttack;
        private System.Windows.Forms.ListBox lstAttacks;
        private System.Windows.Forms.Button btnRemoveAttack;

        // Skills
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
    }
}