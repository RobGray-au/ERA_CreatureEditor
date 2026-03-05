using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    public class Attack
    {
        [XmlAttribute("bonus")]
        public int Bonus { get; set; }

        [XmlAttribute("tableName")]
        public string TableName { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("sizeAdjustment")]
        public int SizeAdjustment { get; set; }

        public Attack()
        {
            Bonus = 0;
            TableName = "";
            Name = "";
            SizeAdjustment = 0;
        }

        public Attack(int bonus, string tableName, string name, int sizeAdjustment = 0)
        {
            Bonus = bonus;
            TableName = tableName;
            Name = name;
            SizeAdjustment = sizeAdjustment;
        }

        public override string ToString()
        {
            return $"{Name} (Bonus: {Bonus})";
        }
    }
}