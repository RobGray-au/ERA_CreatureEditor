using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERA_CreatureEdit.Models
{
    public class AppSettings
    {
        public string ApplicationName { get; set; } = "ERA Creature Edit";
        public string ERA_CreatureFolder { get; set; } = string.Empty;
        public bool AvatarGreyscale { get; set; }
    }

    public static class AppConfig
    {
        

    }
}
