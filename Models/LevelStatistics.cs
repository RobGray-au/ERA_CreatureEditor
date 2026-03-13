using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    public class LevelStatistics
    {
        [XmlAttribute("averageLevel")]
        public int AverageLevel { get; set; }

        public LevelStatistics()
        {
            AverageLevel = 1;
        }
    }
}