using System.Xml.Serialization;

namespace ERA_CreatureEdit.Models
{
    public class LevelStatistics
    {
        [XmlAttribute("averageLevel")]
        public int AverageLevel { get; set; }

        [XmlAttribute("levelCode")] 
        public string? LevelCode { get; set; }

        public LevelStatistics()
        {
            AverageLevel = 3;
            LevelCode = "C";
        }


    }
}