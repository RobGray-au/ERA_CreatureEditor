using CreatureXmlEditor.Models;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CreatureXmlEditor.Utilities
{
    public class XmlHelper
    {
        private static readonly XmlSerializer CreatureSerializer = new XmlSerializer(typeof(Creature));

        public static Creature LoadFromFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("filePath is required.", nameof(filePath));

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");

            var settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Prohibit,
                IgnoreComments = true,
                IgnoreWhitespace = true
            };

            //TestMain();
            //case insensitive fix

            string xml = File.ReadAllText(filePath);
            XDocument doc = XDocument.Parse(xml);
            if (doc == null || doc.Root == null)
            {
                throw new InvalidDataException("Invalid Creature XML format.");
            }
            LowercaseAttributes(doc.Root);


            using (var reader1 = doc.CreateReader())
            {
                var serializer = new XmlSerializer(typeof(Creature));
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                var creatr = (Creature)serializer.Deserialize(reader1);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (creatr == null)
                {
                    throw new InvalidDataException("Deserialization of XML resulted in null.");
                }
                return creatr;
            }

        }

        /// <summary>
        /// fix for porely formed existing creature files
        /// </summary>
        /// <param name="element"></param>
        static void LowercaseAttributes(XElement element)
        {
            if (element.Parent != null)
            {
                // Copy attributes first to avoid modifying while iterating
                var attributes = element.Attributes().ToList();

                foreach (var attr in attributes)
                {
                    string name = attr.Name.LocalName;

                    if (!string.IsNullOrEmpty(name) && char.IsUpper(name[0]))
                    {
                        string newName = char.ToLower(name[0]) + name.Substring(1);
                        string value = attr.Value;

                        // Remove old attribute and add new one
                        attr.Remove();
                        element.SetAttributeValue(newName, value);
                    }
                }
            }


            // Recurse into children
            foreach (var child in element.Elements())
            {
                LowercaseAttributes(child);
            }
        }

        public static void SaveToFile(Creature creature, string filePath)
        {
            if (creature == null) throw new ArgumentNullException(nameof(creature));
            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException("filePath is required.", nameof(filePath));

            var settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true,
                Encoding = new UTF8Encoding(false)
            };

            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            using (var writer = XmlWriter.Create(fs, settings))
            {
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);
                CreatureSerializer.Serialize(writer, creature, namespaces);
            }
        }




        static void TestMain()
        {
            string xml = @"<Creature Name=""Onig"">
    <Category>SoD Demons</Category>
    <LevelStatistics AverageLevel=""3"" />
    <MovementStatistics BaseMovement=""10"" attackQuickness=""0"" />
    <CombatStatistics ArmorType=""1"" DefensiveBonus=""0"" BaseHits=""60"">
        <ResistanceRollBonuses>
            <ResistanceRollBonus concept=""Channeling"" totalBonus=""5"" />
            <ResistanceRollBonus concept=""Essence"" totalBonus=""5"" />
            <ResistanceRollBonus concept=""Mentalism"" totalBonus=""5"" />
            <ResistanceRollBonus concept=""Physical"" totalBonus=""5"" />
            <ResistanceRollBonus concept=""Fear"" totalBonus=""0"" />
        </ResistanceRollBonuses>
        <Attacks>
            <Attack Bonus=""50"" TableName=""Bite"" Name=""Bite"" sizeAdjustment=""0"" />
        </Attacks>
    </CombatStatistics>
</Creature>";

            var doc = XDocument.Parse(xml);
            if (doc.Root == null) return;
            LowercaseAttributeNames(doc.Root);

            Console.WriteLine(doc.ToString());
        }

        static void LowercaseAttributeNames(XElement element)
        {
            // Copy attributes first to avoid modifying while iterating
            if (element.Parent != null)
            {
                var attributes = element.Attributes().ToList();

                foreach (var attr in attributes)
                {
                    string name = attr.Name.LocalName;

                    if (!string.IsNullOrEmpty(name) && char.IsUpper(name[0]))
                    {
                        string newName = char.ToLower(name[0]) + name.Substring(1);
                        string value = attr.Value;

                        // Remove old attribute and add new one
                        attr.Remove();
                        element.SetAttributeValue(newName, value);
                    }
                }
            }
            // Recurse into children
            foreach (var child in element.Elements())
            {
                LowercaseAttributeNames(child);
            }
        }
    }


}
