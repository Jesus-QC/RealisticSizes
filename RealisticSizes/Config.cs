using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace RealisticSizes
{
    public sealed class Config : IConfig
    {
        public enum Mode
        {
            Fun,
            Roleplay,
            Manual,
        }

        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("The mode enabled (Fun, Roleplay or Manual)")]
        public Mode ActiveMode { get; set; } = Mode.Fun;
        [Description("This will enable antilag, changing sizes in different time to avoid lag.")]
        public bool IsAntiLagEnabled { get; set; } = true;
        [Description("Minimum ammount of players in the server to enable AntiLag, this only will work if \"is_anti_lag_enabled\" is true")]
        public int AntiLagMinplayers { get; set; } = 5;
        [Description("This will allow players to have different values in each axis (1.2x, 0.5y, 1.4z), if this is false all axis will have the same value (1.2x, 1.2y, 1.2z)")]
        public bool AllowUnproportionalValues { get; set; } = true;
        [Description("Only if mode is Manual. Size configurer (minX:minY::maxX:maxY) X and Z will be the same value, add your roles!")]
        public Dictionary<RoleType, string> manualSizes { get; set; } = new Dictionary<RoleType, string>
        {
            {
                RoleType.ClassD,
                "0.5:0.5::1.15:1.15"
            },
            {
                RoleType.Scientist,
                "0.5:0.5::1.15:1.15"
            },
        };
    }
}