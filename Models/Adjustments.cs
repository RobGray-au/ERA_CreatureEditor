using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ERA_CreatureEdit.Models
{
    internal class Adjustments
    {
        public List<AdjustmentType> AdjustmentsHP;
        public List<AdjustmentType> AdjustmentsCon ; 
        public List<AdjustmentType> AdjustmentsLevel;
        
        public Adjustments()
        {
            AdjustmentsHP = new List<AdjustmentType>();
            AdjustmentsCon = new List<AdjustmentType>();
            AdjustmentsLevel = new List<AdjustmentType>();
            LoadAdjustments();
        }
        public void LoadAdjustments()
        {
            using (StreamReader r = new StreamReader("AdjustCreatureHPLevel.json"))
            {
                string json = r.ReadToEnd();
                AdjustmentsHP = JsonSerializer.Deserialize<List<AdjustmentType>>(json);
            }
            using (StreamReader r = new StreamReader("AdjustCreatureConstitution.json"))
            {
                string json = r.ReadToEnd();
                AdjustmentsCon = JsonSerializer.Deserialize<List<AdjustmentType>>(json);
            }
            using (StreamReader r = new StreamReader("AdjustCreatureLevel.json"))
            {
                string json = r.ReadToEnd();
                AdjustmentsLevel = JsonSerializer.Deserialize<List<AdjustmentType>>(json);
            }
        }

        /// <summary>
        /// get the value for adjstment based on the name of the adjustment, the roll and the creature class. Returns -1 if not found.
        /// </summary>
        /// <param name="adjustmentName">HP, Level, Con</param>
        /// <param name="roll"></param>
        /// <param name="creatureClass"></param>
        /// <returns></returns>
        public int FindAdjustmentValue(string adjustmentName, int roll,string creatureClass)
            {
            if (AdjustmentsLevel.Count == 0)     LoadAdjustments();
            if(adjustmentName == null) return -1;
            List <AdjustmentType> objects;
            switch (adjustmentName)
            {
                case "HP":
                    objects = AdjustmentsHP;
                    break;
                case "Level":
                    objects = AdjustmentsLevel;
                 break;
 
                case "Con":
                    objects= AdjustmentsCon;
                    break;
                    
                default:
                    objects = AdjustmentsLevel;
                    break;
            }

            var foundObj = objects.FirstOrDefault(o => roll <= o.RollLimit);
            if (foundObj != null)
            {
                // Found object!
                switch (creatureClass)
                    
                {
                    case "A":
                        return foundObj.A;
                        case "B":   
                            return foundObj.B;
                        case "C":
                        return foundObj.C;  
                        case "D":
                        return foundObj.D;
                        case "E":
                        return foundObj.E;
                        case "F":
                        return foundObj.F;
                        case "G":   
                        return foundObj.G;
                        default:   
                        return foundObj.B;

                }

            }
            return -1;
        }
    }
}
