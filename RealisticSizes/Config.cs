using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RealisticSizes
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Fun mode enabled? set this to false to prevent unrealistic sizes (better for RP)")]
        public bool FunMode { get; set; } = true;

        [Description("Manually set sizes for all humans?")]
        public bool ManualSizes { get; set; } = false;
        [Description("Maximun height and depth size (Not recommended more than 1.03 if you want to pass trought all doors)")]
        public float MaxHeight { get; set; } = 1.03f;
        [Description("Minimun height and depth size (Recomended 0.9 for RP servers)")]
        public float MinHeight { get; set; } = 0.85f;
        [Description("Maximun width size (Not recommended more than 1.12 if you want to pass trought all doors)")]
        public float MaxWidth { get; set; } = 1.12f;
        [Description("Minimun width size (Recommended 0.9 for RP servers")]
        public float MinWidth { get; set; } = 0.8f;
    }
}