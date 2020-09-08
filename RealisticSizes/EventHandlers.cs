using Exiled.Events.EventArgs;
using UnityEngine;

namespace RealisticSizes.Handlers
{
    public class EventHandlers
    {
        public RealisticSizes plugin;
        public EventHandlers(RealisticSizes plugin) => this.plugin = plugin;

        private static readonly System.Random random = new System.Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole == RoleType.ClassD)
            {
                if (plugin.Config.ManualSizes)
                {
                    double randScale = RandomNumberBetween(plugin.Config.ClassDMinHeight, plugin.Config.ClassDMaxHeight);
                    double fatScale = RandomNumberBetween(plugin.Config.ClassDMinWidth, plugin.Config.ClassDMaxWidth);
                    ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                }
                if (!plugin.Config.ManualSizes)
                {
                    if (plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.Scientist)
            {
                if (plugin.Config.ManualSizes)
                {
                    double randScale = RandomNumberBetween(plugin.Config.ScientistMinHeight, plugin.Config.ScientistMaxHeight);
                    double fatScale = RandomNumberBetween(plugin.Config.ScientistMinWidth, plugin.Config.ScientistMaxWidth);
                    ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                }
                if (!plugin.Config.ManualSizes)
                {
                    if (plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.FacilityGuard)
            {
                if (plugin.Config.ManualSizes)
                {
                    double randScale = RandomNumberBetween(plugin.Config.FacilityGuardMinHeight, plugin.Config.FacilityGuardMaxHeight);
                    double fatScale = RandomNumberBetween(plugin.Config.FacilityGuardMinWidth, plugin.Config.FacilityGuardMaxWidth);
                    ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                }
                if (!plugin.Config.ManualSizes)
                {
                    if (plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.NtfCadet)
            {
                if (plugin.Config.ManualSizes)
                {
                    double randScale = RandomNumberBetween(plugin.Config.NTFCadetMinHeight, plugin.Config.NTFCadetMaxHeight);
                    double fatScale = RandomNumberBetween(plugin.Config.NTFCadetMinWidth, plugin.Config.NTFCadetMaxWidth);
                    ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                }
                if (!plugin.Config.ManualSizes)
                {
                    if (plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.NtfLieutenant)
            {
                if (plugin.Config.ManualSizes)
                {
                    double randScale = RandomNumberBetween(plugin.Config.NTFLieutenantMinHeight, plugin.Config.NTFLieutenantMaxHeight);
                    double fatScale = RandomNumberBetween(plugin.Config.NTFLieutenantMinWidth, plugin.Config.NTFLieutenantMaxWidth);
                    ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                }
                if (!plugin.Config.ManualSizes)
                {
                    if (plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.NtfCommander)
            {
                if (plugin.Config.ManualSizes)
                {
                    double randScale = RandomNumberBetween(plugin.Config.CommanderMinHeight, plugin.Config.CommanderMaxHeight);
                    double fatScale = RandomNumberBetween(plugin.Config.CommanderMinWidth, plugin.Config.CommanderMaxWidth);
                    ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                }
                if (!plugin.Config.ManualSizes)
                {
                    if (plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.ChaosInsurgency)
            {
                if (plugin.Config.ManualSizes)
                {
                    double randScale = RandomNumberBetween(plugin.Config.ChaosInsurgencyMinHeight, plugin.Config.ChaosInsurgencyMaxHeight);
                    double fatScale = RandomNumberBetween(plugin.Config.ChaosInsurgencyMinWidth, plugin.Config.ChaosInsurgencyMaxWidth);
                    ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                }
                if (!plugin.Config.ManualSizes)
                {
                    if (plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.FunMode)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.Spectator)
            {
                ev.Player.Scale = new Vector3(1, 1, 1);
            }
        }
    }
}