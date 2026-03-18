using System.Xml.Serialization;

namespace ERA_CreatureEdit.Models
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