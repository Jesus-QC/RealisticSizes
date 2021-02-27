using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace RealisticSizes
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Fun mode enabled? set this to false to prevent unrealistic sizes (better for RP)")]
        public bool FunMode { get; set; } = true;

        [Description("Manually set sizes for all humans? This will disable FunMode and RPMode")]
        public bool ManualSizes { get; set; } = false;

        [Description("Manual size configurer (minX:minY::maxX:maxY) X and Z are the same values, add your roles!")]
        public Dictionary<RoleType, string> a = new Dictionary<RoleType, string>
        {
            {
                RoleType.ClassD,
                "0.5:0.5::1.15:1.15"
            },
        };
    }
}