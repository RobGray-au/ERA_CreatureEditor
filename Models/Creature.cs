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

        [XmlElement("Avatar")]
        public string Avatar { get; set; }

        public Image AvatarImage
        {
            get
            {
                if (string.IsNullOrEmpty(Avatar))
                    return null;
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(Avatar);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        return Image.FromStream(ms);
                    }
                }
                catch
                {
                    return null; // Return null if the string is not a valid Base64 image
                }
            }
            set
            {
                if (value == null)
                {
                    Avatar = "";
                }
                else
                {
                    using (var ms = new MemoryStream())
                    {
                        value.Save(ms, value.RawFormat);
                        Avatar = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        public Creature()
        {
            Name = "New Creature";
            Category = "";
            LevelStatistics = new LevelStatistics();
            MovementStatistics = new MovementStatistics();
            CombatStatistics = new CombatStatistics();
            ManeuverSkills = new ManeuverSkills();
            //set some nominal base values for the creature
            Description = "";
            Avatar = "";

            LevelStatistics.AverageLevel = 3;
            CombatStatistics.ArmorType = 3;
            CombatStatistics.BaseHits = 30;
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