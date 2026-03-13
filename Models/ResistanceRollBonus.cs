using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    public class ResistanceRollBonus
    {
        [XmlAttribute("concept")]
        public string Concept { get; set; }

        [XmlAttribute("totalBonus")]
        public int TotalBonus { get; set; }

        public ResistanceRollBonus()
        {
            Concept = "";
            TotalBonus = 0;
        }

        public ResistanceRollBonus(string concept, int bonus)
        {
            Concept = concept;
            TotalBonus = bonus;
        }

        public override string ToString()
        {
            return $"{Concept}: {TotalBonus}";
        }
    }
}