using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ERA_CreatureEdit
{
    public partial class ConfigEditor : Form
    {
        private XmlDocument xmlDoc;
        private string configFilePath;
        private string creaturePath;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ConfigFilePath { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public  string CreaturePath { get; set; }


        public ConfigEditor()
        {
            InitializeComponent();
            this.Text = "ERA Configuration Editor";
            this.Size = new System.Drawing.Size(600, 400);
        }


        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
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
                xmlDoc = new XmlDocument();
                xmlDoc.Load(ConfigFilePath);

                // Display XML content
                richTextBoxXml.Text = FormatXml(xmlDoc.OuterXml);

                // Extract and display creature path
                XmlNode node = xmlDoc.SelectSingleNode("//add[@key='Default ERA Creature File Path']");
                if (node != null)
                {
                    textBoxCreaturePath.Text = node.Attributes["value"]?.Value ?? "";
                }
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
                    // Update XML in memory
                    UpdateXmlPath(selectedPath);
                }
            }
        }

        private void UpdateXmlPath(string newPath)
        {
            if (xmlDoc == null) return;

            XmlNode node = xmlDoc.SelectSingleNode("//add[@key='Default ERA Creature File Path']");
            if (node != null)
            {
                node.Attributes["value"].Value = newPath;
                richTextBoxXml.Text = FormatXml(xmlDoc.OuterXml);            }
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
                // Save current XML content
                xmlDoc.Save(ConfigFilePath);
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

        private string FormatXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            System.IO.StringWriter sw = new System.IO.StringWriter();
            XmlTextWriter writer = new XmlTextWriter(sw);
            writer.Formatting = System.Xml.Formatting.Indented;
            writer.Indentation = 4;
            doc.WriteContentTo(writer);

            return sw.ToString();
        }

        private void ConfigEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
