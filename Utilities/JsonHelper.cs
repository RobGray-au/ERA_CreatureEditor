
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CreatureXmlEditor.Models;

namespace CreatureXmlEditor.Utilities
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
    }
}
