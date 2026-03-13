using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CreatureXmlEditor.Models
{
    //CreatureModels myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AttackType
    {
        public string WeaponName { get; set; }
        public string TableName { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
    }
    

    public class ResistanceType
    {
        [JsonPropertyName("ResistanceName")]
        public string Name { get; set; }
        public string Concept{ get; set; }
        public string Class { get; set; }
    }

    public class CreatureModels
    {
        public List<AttackType> AttackTypes { get; set; }

        public List<ResistanceType> ResistanceTypes { get; set; }
    }
}
