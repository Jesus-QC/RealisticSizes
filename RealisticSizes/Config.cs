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
        public float ClassDMaxHeight { get; set; } = 1.03f;
        public float ScientistMaxHeight { get; set; } = 1.03f;
        public float FacilityGuardMaxHeight { get; set; } = 1.03f;
        public float NTFCadetMaxHeight { get; set; } = 1.03f;
        public float NTFLieutenantMaxHeight { get; set; } = 1.03f;
        public float CommanderMaxHeight { get; set; } = 1.03f;
        public float ChaosInsurgencyMaxHeight { get; set; } = 1.03f;
        [Description("Minimun height and depth size (Recomended 0.9 for RP servers)")]
        public float ClassDMinHeight { get; set; } = 0.85f;
        public float ScientistMinHeight { get; set; } = 0.85f;
        public float FacilityGuardMinHeight { get; set; } = 0.85f;
        public float NTFCadetMinHeight { get; set; } = 0.85f;
        public float NTFLieutenantMinHeight { get; set; } = 0.85f;
        public float CommanderMinHeight { get; set; } = 0.85f;
        public float ChaosInsurgencyMinHeight { get; set; } = 0.85f;
        [Description("Maximun width size (Not recommended more than 1.12 if you want to pass trought all doors)")]
        public float ClassDMaxWidth { get; set; } = 1.12f;
        public float ScientistMaxWidth { get; set; } = 1.12f;
        public float FacilityGuardMaxWidth { get; set; } = 1.12f;
        public float NTFCadetMaxWidth { get; set; } = 1.12f;
        public float NTFLieutenantMaxWidth { get; set; } = 1.12f;
        public float CommanderMaxWidth { get; set; } = 1.12f;
        public float ChaosInsurgencyMaxWidth { get; set; } = 1.12f;
        [Description("Minimun width size (Recommended 0.9 for RP servers")]
        public float ClassDMinWidth { get; set; } = 1.12f;
        public float ScientistMinWidth { get; set; } = 1.12f;
        public float FacilityGuardMinWidth { get; set; } = 1.12f;
        public float NTFCadetMinWidth { get; set; } = 1.12f;
        public float NTFLieutenantMinWidth { get; set; } = 1.12f;
        public float CommanderMinWidth { get; set; } = 1.12f;
        public float ChaosInsurgencyMinWidth { get; set; } = 1.12f;
    }
}