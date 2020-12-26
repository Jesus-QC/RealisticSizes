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

        [Description("Manually set sizes for all humans? This will disable FunMode and RPMode")]
        public bool ManualSizes { get; set; } = false;
        [Description("Maximun height and depth size (Not recommended more than 1.03 if you want to pass trought all doors)")]
        public float ClassDMaxHeight { get; set; } = 1.03f;
        public float ScientistMaxHeight { get; set; } = 1.03f;
        public float FacilityGuardMaxHeight { get; set; } = 1.03f;
        public float NTFCadetMaxHeight { get; set; } = 1.03f;
        public float NTFLieutenantMaxHeight { get; set; } = 1.03f;
        public float CommanderMaxHeight { get; set; } = 1.03f;
        public float ChaosInsurgencyMaxHeight { get; set; } = 1.03f;
        public float Scp049MaxHeight { get; set; } = 1.03f;
        public float Scp0492MaxHeight { get; set; } = 1.03f;
        public float Scp096MaxHeight { get; set; } = 1.03f;
        public float Scp106MaxHeight { get; set; } = 1.03f;
        public float Scp173MaxHeight { get; set; } = 1.03f;
        public float Scp93953MaxHeight { get; set; } = 1.03f;
        public float Scp93989MaxHeight { get; set; } = 1.03f;
        [Description("Minimun height and depth size (Recomended 0.9 for RP servers)")]
        public float ClassDMinHeight { get; set; } = 0.85f;
        public float ScientistMinHeight { get; set; } = 0.85f;
        public float FacilityGuardMinHeight { get; set; } = 0.85f;
        public float NTFCadetMinHeight { get; set; } = 0.85f;
        public float NTFLieutenantMinHeight { get; set; } = 0.85f;
        public float CommanderMinHeight { get; set; } = 0.85f;
        public float ChaosInsurgencyMinHeight { get; set; } = 0.85f;
        public float Scp049MinHeight { get; set; } = 0.85f;
        public float Scp0492MinHeight { get; set; } = 0.85f;
        public float Scp096MinHeight { get; set; } = 0.85f;
        public float Scp106MinHeight { get; set; } = 0.85f;
        public float Scp173MinHeight { get; set; } = 0.85f;
        public float Scp93953MinHeight { get; set; } = 0.85f;
        public float Scp93989MinHeight { get; set; } = 0.85f;
        [Description("Maximun width size (Not recommended more than 1.12 if you want to pass trought all doors)")]
        public float ClassDMaxWidth { get; set; } = 1.12f;
        public float ScientistMaxWidth { get; set; } = 1.12f;
        public float FacilityGuardMaxWidth { get; set; } = 1.12f;
        public float NTFCadetMaxWidth { get; set; } = 1.12f;
        public float NTFLieutenantMaxWidth { get; set; } = 1.12f;
        public float CommanderMaxWidth { get; set; } = 1.12f;
        public float ChaosInsurgencyMaxWidth { get; set; } = 1.12f;
        public float Scp049MaxWidth { get; set; } = 1.12f;
        public float Scp0492MaxWidth { get; set; } = 1.12f;
        public float Scp096MaxWidth { get; set; } = 1.12f;
        public float Scp106MaxWidth { get; set; } = 1.12f;
        public float Scp173MaxWidth { get; set; } = 1.12f;
        public float Scp93953MaxWidth { get; set; } = 1.12f;
        public float Scp93989MaxWidth { get; set; } = 1.12f;
        [Description("Minimun width size (Recommended 0.9 for RP servers")]
        public float ClassDMinWidth { get; set; } = 1.12f;
        public float ScientistMinWidth { get; set; } = 1.12f;
        public float FacilityGuardMinWidth { get; set; } = 1.12f;
        public float NTFCadetMinWidth { get; set; } = 1.12f;
        public float NTFLieutenantMinWidth { get; set; } = 1.12f;
        public float CommanderMinWidth { get; set; } = 1.12f;
        public float ChaosInsurgencyMinWidth { get; set; } = 1.12f;
        public float Scp049MinWidth { get; set; } = 1.12f;
        public float Scp0492MinWidth { get; set; } = 1.12f;
        public float Scp096MinWidth { get; set; } = 1.12f;
        public float Scp106MinWidth { get; set; } = 1.12f;
        public float Scp173MinWidth { get; set; } = 1.12f;
        public float Scp93953MinWidth { get; set; } = 1.12f;
        public float Scp93989MinWidth { get; set; } = 1.12f;
    }
}