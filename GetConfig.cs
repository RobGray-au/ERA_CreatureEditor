using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using static System.Windows.Forms.Design.AxImporter;

namespace GetConfig
{
    public class ConfigurationManager
    {
        private IConfiguration AppSettings ;
        public string configFileName = "appsettings.json";  // default file, can be overridden by constructor

        public ConfigurationManager()
        {
            AppSettings = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(configFileName, optional: false, reloadOnChange: true)
                    .Build();
        }
        public ConfigurationManager(string jsonPath)
        {
            configFileName = jsonPath;
            AppSettings = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(jsonPath, optional: false, reloadOnChange: true)
                    .Build();
        }

        public ConfigurationManager(IConfiguration configuration)
        {
            AppSettings = configuration;
            //but what about the json file path? we need it for writing to the file, so we can either:
        }



        ///examples
        ///string value1 = ConfigurationManager.AppSetting["GrandParent_Key:Parent_Key:Child_Key"];
        /// <summary>
        /// examples
        /// Value2 = ConfigurationManager.AppSetting["Parent_Key:Child_Key"];
        ///string value3 = ConfigurationManager.AppSetting["Child_Key"];
        ///
        #region get settings
        internal string GetAppSetting(string sectionPathKey, string childKey, string baseValue= "")
        {
            string fullPathKey = $"{sectionPathKey}:{childKey}";
            try
            {
                return AppSettings[fullPathKey] ?? baseValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading app settings | {0}", ex.Message);
                return string.Empty;
            }
        }

        internal int GetAppSetting(string sectionPathKey, string childKey, int baseValue=0)
        {
            string fullPathKey = $"{sectionPathKey}:{childKey}";
            int _returnValue = 0;
            try
            {
                if (!int.TryParse(AppSettings[fullPathKey] , out _returnValue))
                    _returnValue = baseValue; // default value;
                return _returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading app settings | {0}", ex.Message);
                return -9999;
            }
        }

        internal bool GetAppSetting(string sectionPathKey, string childKey, bool baseValue = false)
        {
            string fullPathKey = $"{sectionPathKey}:{childKey}";
            bool _returnValue = baseValue;
            try
            {
                if (!bool.TryParse(AppSettings[fullPathKey], out _returnValue))
                    _returnValue = baseValue; // default value;
                return _returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading app settings | {0}", ex.Message);
                return false;
            }
        }

        #endregion


        #region Update Settings
        // Source - https://stackoverflow.com/a/66888043
        // Posted by Kuklinski
        // Retrieved 2026-03-16, License - CC BY-SA 4.0


        public void AddOrUpdateAppSetting<T>(string sectionPathKey, T value)
        {
            try
            {
                var filePath = Path.Combine(System.AppContext.BaseDirectory, configFileName);
                string json = File.ReadAllText(filePath);

                // Parse into a mutable JsonObject (System.Text.Json.Nodes)
                var rootNode = System.Text.Json.Nodes.JsonNode.Parse(json)?.AsObject() ?? new System.Text.Json.Nodes.JsonObject();

                SetValueRecursively(sectionPathKey, rootNode, value);

                string output = rootNode.ToJsonString(new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, output);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing app settings | {0}", ex.Message);
            }
        }

        private static void SetValueRecursively<T>(string sectionPathKey, System.Text.Json.Nodes.JsonObject jsonObj, T value)
        {
            // split the string at the first ':' character
            var remainingSections = sectionPathKey.Split(":", 2);

            var currentSection = remainingSections[0];
            if (remainingSections.Length > 1)
            {
                // continue with the process, moving down the tree
                var nextSection = remainingSections[1];

                // Get or create the next object node
                if (!jsonObj.TryGetPropertyValue(currentSection, out var child) || child == null || child is not System.Text.Json.Nodes.JsonObject)
                {
                    var newObj = new System.Text.Json.Nodes.JsonObject();
                    jsonObj[currentSection] = newObj;
                    child = newObj;
                }

                SetValueRecursively(nextSection, (System.Text.Json.Nodes.JsonObject)child!, value);
            }
            else
            {
                // we've got to the end of the tree, set the value (creates JsonValue)
                jsonObj[currentSection] = System.Text.Json.Nodes.JsonValue.Create(value);
            }
        }

        #endregion
    }


}
