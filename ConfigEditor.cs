using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ERA_CreatureEdit
{
    public partial class ConfigEditor : Form
    {
        private XmlDocument xmlDoc;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ConfigFilePath { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CreaturePath { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AvatarGreyscale { get; set; }


        private JsonObject jsonConfig;

        public ConfigEditor()
        {
            InitializeComponent();
            this.Text = "ERA Creature Editor Settings";
            this.Size = new System.Drawing.Size(600, 400);
            //LoadConfigFile();
        }


        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "*.json";
                openFileDialog.Title = "Select Configuration File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ConfigFilePath = openFileDialog.FileName;
                    textBoxFilePath.Text = ConfigFilePath;
                    LoadConfigFile();
                }
            }
        }

        private void LoadConfigFile()
        {
            try
            {
                // Load JSON as a mutable object
                var jsonConfig = JsonNode.Parse(File.ReadAllText(ConfigFilePath))!.AsObject();

                // Display XML content
                richTextBoxXml.Text = jsonConfig.ToString();

                var Config = new GetConfig.ConfigurationManager(ConfigFilePath); //load basic & default configuration 
                textBoxFilePath.Text = ConfigFilePath;
                textBoxCreaturePath.Text = Config.GetAppSetting("AppSettings","ERA_CreatureFolder", @"C:\ERA\RMC\Configuration\Creatures");
                checkBoxSaveAvatar_Grayescale.Checked = Config.GetAppSetting("AppSettings","AvatarGreyscale", true);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBrowseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the Default ERA Creature File Path";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    textBoxCreaturePath.Text = selectedPath;
                    CreaturePath = selectedPath;

                }
            }
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConfigFilePath))
            {
                MessageBox.Show("No configuration file loaded.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Save current content
                var Config = new GetConfig.ConfigurationManager(ConfigFilePath); //load basic & default configuration 

                Config.AddOrUpdateAppSetting(string.Join(":", "AppSettings", "ERA_CreatureFolder"), CreaturePath);
                Config.AddOrUpdateAppSetting(string.Join(":", "AppSettings", "UseGreyscaleAvatar"), AvatarGreyscale);

                MessageBox.Show("Configuration saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ConfigFilePath) && File.Exists(ConfigFilePath))
            {
                LoadConfigFile();
            }
        }


        private void ConfigEditor_Load(object sender, EventArgs e)
        {
            LoadConfigFile();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxSaveAvatar_Grayescale_CheckedChanged(object sender, EventArgs e)
        {
            AvatarGreyscale = checkBoxSaveAvatar_Grayescale.Checked;
        }
    }
}
