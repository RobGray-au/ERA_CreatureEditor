using CreatureXmlEditor.Models;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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
                //XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                //namespaces.Add(string.Empty, string.Empty);

                // Configure XmlWriterSettings to omit XML declaration
                var settings = new XmlWriterSettings
                {
                    Indent = true,                // Pretty-print
                    OmitXmlDeclaration = true,    // No <?xml ... ?> declaration
                    Encoding = new UTF8Encoding(false) // UTF-8 without BOM
                };

                // Serialize to string without DTD or XML declaration
                using (var stringWriter = new StringWriter())
                using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    serializer.Serialize(xmlWriter, creature);
                    string xmlOutput = stringWriter.ToString();

                    Console.WriteLine("Serialized XML (no DTD, no declaration):");
                    Console.WriteLine(xmlOutput);
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