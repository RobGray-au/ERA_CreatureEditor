using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    [XmlRoot("Creature")]
    public class Creature
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("Category")]
        public string Category { get; set; }

        [XmlElement("LevelStatistics")]
        public LevelStatistics LevelStatistics { get; set; }

        [XmlElement("MovementStatistics")]
        public MovementStatistics MovementStatistics { get; set; }

        [XmlElement("CombatStatistics")]
        public CombatStatistics CombatStatistics { get; set; }

        [XmlElement("ManeuverSkills")]
        public ManeuverSkills ManeuverSkills { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        public Creature()
        {
            Name = "New Creature";
            Category = "";
            LevelStatistics = new LevelStatistics();
            MovementStatistics = new MovementStatistics();
            CombatStatistics = new CombatStatistics();
            ManeuverSkills = new ManeuverSkills();
            Description = "";
        }
    }

    public class ManeuverSkills
    {
        [XmlElement("Skill")]
        public List<Skill> Skills { get; set; }

        public ManeuverSkills()
        {
            Skills = new List<Skill>();
        }
    }
}