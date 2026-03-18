using System.Drawing.Imaging;
using System.Xml.Serialization;

namespace ERA_CreatureEdit.Models
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

        [XmlElement("SpellLists")]
        public SpellLists SpellLists { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Avatar")]
        public string AvatarTxt { get; set; }

        [XmlIgnore]
        public Image AvatarImage
        {
            get
            {
                if (string.IsNullOrEmpty(AvatarTxt))
                    return null;
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(AvatarTxt);
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
                    AvatarTxt = "";
                }
                else
                {
                    Image thisImg = value;
                    ImageFormat fmt= ImageFormat.Jpeg;
                    using (var ms = new MemoryStream())
                    {
                        value.Save(ms, fmt);   //was value.RawFormat but that was causing some issues with certain formats, so just save as jpeg for now
                        AvatarTxt = Convert.ToBase64String(ms.ToArray());
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
            SpellLists = new SpellLists();
            //set some nominal base values for the creature
            Description = "";
            AvatarTxt = "";

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
    public class SpellLists
    {
        [XmlElement("Skill")]
        public List<Skill> Spells { get; set; }

        public SpellLists()
        {
            Spells = new List<Skill>();
        }
    }
}