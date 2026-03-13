using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    public class DefensiveModification
    {
        [XmlAttribute("bonusOrPenalty")]
        public int BonusOrPenalty { get; set; }

        [XmlAttribute("concept")]
        public string Concept { get; set; }

        public DefensiveModification()
        {
            BonusOrPenalty = 0;
            Concept = "";
        }

        public DefensiveModification(int bonus, string concept)
        {
            BonusOrPenalty = bonus;
            Concept = concept;
        }

        public override string ToString()
        {
            return $"{Concept}: {BonusOrPenalty}";
        }
    }
}