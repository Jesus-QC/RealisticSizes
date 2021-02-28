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