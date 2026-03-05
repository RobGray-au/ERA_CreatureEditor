using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using CreatureXmlEditor.Models;

namespace CreatureXmlEditor.Utilities
{
    public class XmlHelper
    {
        public static Creature LoadFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"File not found: {filePath}");

                XmlSerializer serializer = new XmlSerializer(typeof(Creature));
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return (Creature)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading XML file: {ex.Message}", ex);
            }
        }

        public static void SaveToFile(Creature creature, string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Creature));
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, creature, namespaces);
                }

                // Format the XML with proper indentation
                FormatXmlFile(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving XML file: {ex.Message}", ex);
            }
        }

        private static void FormatXmlFile(string filePath)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    doc.Save(writer);
                }
            }
            catch { /* Formatting is optional */ }
        }
    }
}