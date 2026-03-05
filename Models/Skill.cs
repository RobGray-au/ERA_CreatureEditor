using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    public class Skill
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("tableName")]
        public string TableName { get; set; }

        [XmlAttribute("ranks")]
        public int Ranks { get; set; }

        [XmlAttribute("bonus")]
        public int Bonus { get; set; }

        public Skill()
        {
            Name = "";
            TableName = "";
            Ranks = 0;
            Bonus = 0;
        }

        public Skill(string name, string tableName, int ranks, int bonus)
        {
            Name = name;
            TableName = tableName;
            Ranks = ranks;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return $"{Name} (Ranks: {Ranks}, Bonus: {Bonus})";
        }
    }
}