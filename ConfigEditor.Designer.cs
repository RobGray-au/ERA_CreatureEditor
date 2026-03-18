namespace ERA_CreatureEdit
{
    partial class ConfigEditor
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
            labelCurrentPath = new Label();
            textBoxFilePath = new TextBox();
            buttonOpenFile = new Button();
            labelCreaturePath = new Label();
            textBoxCreaturePath = new TextBox();
            buttonBrowseFolder = new Button();
            labelXmlContent = new Label();
            richTextBoxXml = new RichTextBox();
            buttonSave = new Button();
            buttonRefresh = new Button();
            butClose = new Button();
            SuspendLayout();
            // 
            // labelCurrentPath
            // 
            labelCurrentPath.AutoSize = true;
            labelCurrentPath.Location = new Point(10, 10);
            labelCurrentPath.Name = "labelCurrentPath";
            labelCurrentPath.Size = new Size(98, 15);
            labelCurrentPath.TabIndex = 0;
            labelCurrentPath.Text = "Current File Path:";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilePath.Location = new Point(10, 30);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(360, 23);
            textBoxFilePath.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonOpenFile.Location = new Point(395, 29);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(100, 23);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Open Config File";
            buttonOpenFile.Click += ButtonOpenFile_Click;
            // 
            // labelCreaturePath
            // 
            labelCreaturePath.AutoSize = true;
            labelCreaturePath.Location = new Point(10, 70);
            labelCreaturePath.Name = "labelCreaturePath";
            labelCreaturePath.Size = new Size(168, 15);
            labelCreaturePath.TabIndex = 3;
            labelCreaturePath.Text = "Default ERA Creature File Path:";
            // 
            // textBoxCreaturePath
            // 
            textBoxCreaturePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCreaturePath.Location = new Point(10, 90);
            textBoxCreaturePath.Name = "textBoxCreaturePath";
            textBoxCreaturePath.Size = new Size(360, 23);
            textBoxCreaturePath.TabIndex = 4;
            // 
            // buttonBrowseFolder
            // 
            buttonBrowseFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonBrowseFolder.Location = new Point(395, 90);
            buttonBrowseFolder.Name = "buttonBrowseFolder";
            buttonBrowseFolder.Size = new Size(100, 23);
            buttonBrowseFolder.TabIndex = 5;
            buttonBrowseFolder.Text = "Browse...";
            buttonBrowseFolder.Click += ButtonBrowseFolder_Click;
            // 
            // labelXmlContent
            // 
            labelXmlContent.AutoSize = true;
            labelXmlContent.Location = new Point(10, 130);
            labelXmlContent.Name = "labelXmlContent";
            labelXmlContent.Size = new Size(80, 15);
            labelXmlContent.TabIndex = 6;
            labelXmlContent.Text = "XML Content:";
            // 
            // richTextBoxXml
            // 
            richTextBoxXml.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxXml.Enabled = false;
            richTextBoxXml.Font = new Font("Courier New", 9F);
            richTextBoxXml.Location = new Point(10, 150);
            richTextBoxXml.Name = "richTextBoxXml";
            richTextBoxXml.Size = new Size(428, 180);
            richTextBoxXml.TabIndex = 7;
            richTextBoxXml.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Location = new Point(10, 340);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 23);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save Changes";
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRefresh.Location = new Point(120, 340);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(100, 23);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // butClose
            // 
            butClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            butClose.Location = new Point(437, 340);
            butClose.Name = "butClose";
            butClose.Size = new Size(58, 23);
            butClose.TabIndex = 10;
            butClose.Text = "Close";
            // 
            // ConfigEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 375);
            Controls.Add(butClose);
            Controls.Add(labelCurrentPath);
            Controls.Add(textBoxFilePath);
            Controls.Add(buttonOpenFile);
            Controls.Add(labelCreaturePath);
            Controls.Add(textBoxCreaturePath);
            Controls.Add(buttonBrowseFolder);
            Controls.Add(labelXmlContent);
            Controls.Add(richTextBoxXml);
            Controls.Add(buttonSave);
            Controls.Add(buttonRefresh);
            Name = "ConfigEditor";
            Text = "ConfigEditor";
            Load += ConfigEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelCurrentPath;
        private TextBox textBoxFilePath;
        private Button buttonOpenFile;
        private Label labelCreaturePath;
        private TextBox textBoxCreaturePath;
        private Button buttonBrowseFolder;
        private Label labelXmlContent;
        private RichTextBox richTextBoxXml;
        private Button buttonSave;
        private Button buttonRefresh;
        private Button butClose;
    }

    #endregion
    
}