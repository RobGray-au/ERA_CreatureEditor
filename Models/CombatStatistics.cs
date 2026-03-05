using System.Collections.Generic;
using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    public class CombatStatistics
    {
        [XmlAttribute("armorType")]
        public int ArmorType { get; set; }

        [XmlAttribute("defensiveBonus")]
        public int DefensiveBonus { get; set; }

        [XmlAttribute("baseHits")]
        public int BaseHits { get; set; }

        [XmlElement("DefensiveModifications")]
        public DefensiveModifications DefensiveModifications { get; set; }

        [XmlElement("ResistanceRollBonuses")]
        public ResistanceRollBonuses ResistanceRollBonuses { get; set; }

        [XmlElement("Attacks")]
        public Attacks Attacks { get; set; }

        public CombatStatistics()
        {
            ArmorType = 0;
            DefensiveBonus = 0;
            BaseHits = 0;
            DefensiveModifications = new DefensiveModifications();
            ResistanceRollBonuses = new ResistanceRollBonuses();
            Attacks = new Attacks();
        }
    }

    public class DefensiveModifications
    {
        [XmlElement("DefensiveModification")]
        public List<DefensiveModification> Modifications { get; set; }

        public DefensiveModifications()
        {
            Modifications = new List<DefensiveModification>();
        }
    }

    public class ResistanceRollBonuses
    {
        [XmlElement("ResistanceRollBonus")]
        public List<ResistanceRollBonus> Bonuses { get; set; }

        public ResistanceRollBonuses()
        {
            Bonuses = new List<ResistanceRollBonus>();
        }
    }

    public class Attacks
    {
        [XmlElement("Attack")]
        public List<Attack> AttackList { get; set; }

        public Attacks()
        {
            AttackList = new List<Attack>();
        }
    }
}