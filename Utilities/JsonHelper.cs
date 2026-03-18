using ERA_CreatureEdit.Models;
using System.Text.Json;

namespace ERA_CreatureEdit.Utilities
{
    public static class JsonHelper
    {
        private static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public static List<ResistanceType> LoadResistances(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                return new List<ResistanceType>();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<ResistanceType>>(json, DefaultOptions) ?? new List<ResistanceType>();
        }

        public static List<AttackType> LoadAttacks(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                return new List<AttackType>();

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<AttackType>>(json, DefaultOptions) ?? new List<AttackType>();
        }

        static void SaveAppSettings(string filePath, AppSettings updatedSettings)
        {
            try
            {
                // Read the whole JSON file into a dynamic object
                var json = File.ReadAllText(filePath);

                AppSettings jsonObj = JsonSerializer.Deserialize<AppSettings>(json, DefaultOptions) ?? new AppSettings();
                //dynamic jsonObj = JsonConvert.DeserializeObject(json);

                // Update only the AppSettings section
                jsonObj.ApplicationName = updatedSettings.ApplicationName;
                jsonObj.AvatarGreyscale= updatedSettings.AvatarGreyscale;
                jsonObj.ERA_CreatureFolder = updatedSettings.ERA_CreatureFolder;

                //jsonObj["AppSettings"]["ApplicationName"] = updatedSettings.ApplicationName;
                //jsonObj["AppSettings"]["MaxItems"] = updatedSettings.MaxItems;
                //jsonObj["AppSettings"]["EnableLogging"] = updatedSettings.EnableLogging;

                // Write back to file with formatting
                //string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                string output = JsonSerializer.Serialize(jsonObj, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving settings: {ex.Message}");
            }
        }
    }
}
