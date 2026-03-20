using System.Xml.Serialization;

namespace ERA_CreatureEdit.Models
{
    public class MovementStatistics
    {
        [XmlAttribute("baseMovement")]
        public int BaseMovement { get; set; }

        [XmlAttribute("attackQuickness")]
        public string AttackQuickness { get; set; }

        [XmlIgnore]
        public int QuicknessBonus 
        { 
            get
            {
                if (int.TryParse(AttackQuickness, out int value))
                    return value;
                switch (AttackQuickness.Trim().ToUpper())
                {
                    case "IN":
                        return -10;  //Quickness=5
                    case "CR":
                        return -5;  //Quickness=10
                    case "VS":
                        return -5;  //Quickness=20
                    case "SL":
                        return 0;  //Quickness=50
                    case "MD":
                        return +5;  //Quickness=85
                    case "MF":
                        return +15;  //Quickness=97
                    case "FA":
                        return +30;  //Quickness=101
                    case "VF":
                        return +40;  //Quickness=110
                    case "BF":
                        return +50;  //Quickness=120
                    default:
                        return 0;

                }

            }
            set
            {
                AttackQuickness = value.ToString();
            }
        }

        

        public MovementStatistics()
        {
            BaseMovement = 20;
            QuicknessBonus = 5;
        }
    }
}