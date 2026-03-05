using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureXmlEditor.Models
{
    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AttackType
    {
        public string WeaponName { get; set; }
        public string TableName { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
    }

    public class AttackModels
    {
        public List<AttackType> AttackTypes { get; set; }
    }
}
