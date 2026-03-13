using System.Xml.Serialization;

namespace CreatureXmlEditor.Models
{
    public class MovementStatistics
    {
        [XmlAttribute("baseMovement")]
        public int BaseMovement { get; set; }

        [XmlAttribute("attackQuickness")]
        public int AttackQuickness { get; set; }

        public MovementStatistics()
        {
            BaseMovement = 20;
            AttackQuickness = 5;
        }
    }
}