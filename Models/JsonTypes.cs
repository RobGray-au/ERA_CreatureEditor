using System.Xml.Linq;

namespace ERA_CreatureEdit.Models
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

    public class SpellListType
    {
        public string? ListName { get; set; }
        public string? SourceRealm { get; set; }


        public override string ToString()
        {
            return $"{ListName} [{SourceRealm}]";
        }

        public static SpellListType ConvertToSpellListType(string? txtInput)
        {
            var spellListType = new SpellListType
            {
                ListName = "Default Spell List",
                SourceRealm = "Unknown"
            };
            // You can add logic here to populate the spellListType based on the contents of spellLists
            // For example, you could concatenate the names of the spells into the ListName or SourceRealm

            if (string.IsNullOrWhiteSpace(txtInput))
                throw new ArgumentException("Input cannot be empty.");

            int startBracket = txtInput.IndexOf('[');
            int endBracket = txtInput.IndexOf(']');

            if (startBracket < 5 || endBracket <= startBracket + 1)
                throw new FormatException("Invalid format. Expected format:  Name [realm]");

            string realmPart = txtInput.Substring(startBracket + 1, endBracket - startBracket - 1);
            string namePart = txtInput.Substring(0, startBracket -1).Trim();
            if (string.IsNullOrEmpty(namePart))
                throw new FormatException("Name cannot be empty.");

            spellListType.SourceRealm = realmPart;
            spellListType.ListName = namePart;

            return spellListType;
        }
    }


    public class AdjustmentType
    {
        //"RollLimit": 99,        "A": 1,        "B": 2,        "C": 3,        "D": 5,        "E": 8,        "F": 10,        "G": 12,        "H": 15
        public int RollLimit { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }

    }
}
