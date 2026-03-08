using CreatureXmlEditor.Models;
using System;
using System.IO;
using System.Text;
using System.Xml;
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

            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = XmlReader.Create(fs, settings))
            {
                return (Creature)CreatureSerializer.Deserialize(reader);
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

    }
}