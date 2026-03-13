namespace CreatureXmlEditor.Models
{

    public class JsonModels
    {
        public required List<AttackType> AttackTypes { get; set; }

        public required List<ResistanceType> ResistanceTypes { get; set; }
    }

    // add this helper DTOs
    //public class ResistanceRoot { public List<ResistanceType> ResitanceTypes { get; set; } }
    //public class AttackRoot { public List<AttackType> AttackTypes { get; set; } }



    public class AttackType
    {
        public string? WeaponName { get; set; }
        public string? TableName { get; set; }
        public string? Class { get; set; }
        public string? Description { get; set; }
    }


    public class ResistanceType
    {
        public string? ResistanceName { get; set; }
        public string? Concept { get; set; }
        public string? Class { get; set; }
    }

}
