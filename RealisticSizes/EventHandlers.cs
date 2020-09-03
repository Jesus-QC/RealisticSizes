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
            if (ev.NewRole == RoleType.ClassD || ev.NewRole == RoleType.Scientist || ev.NewRole == RoleType.FacilityGuard || ev.NewRole == RoleType.NtfCadet || ev.NewRole == RoleType.NtfLieutenant || ev.NewRole == RoleType.NtfCommander || ev.NewRole == RoleType.ChaosInsurgency) // You might be able to use ev.player.team but this will do for now, if you want config size for each team then use a dictonary with the roles as keys
            {
                if (plugin.Config.FunMode)
                {
                    if (plugin.Config.ManualSizes)
                    {
                        double randScale = RandomNumberBetween(plugin.Config.MinHeight, plugin.Config.MaxHeight);
                        double fatScale = RandomNumberBetween(plugin.Config.MinWidth, plugin.Config.MaxWidth);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.ManualSizes)
                    {
                        double randScale = RandomNumberBetween(0.85, 1.03);
                        double fatScale = RandomNumberBetween(0.8, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
                if (!plugin.Config.FunMode)
                {
                    if (plugin.Config.ManualSizes)
                    {
                        double randScale = RandomNumberBetween(plugin.Config.MinHeight, plugin.Config.MaxHeight);
                        double fatScale = RandomNumberBetween(plugin.Config.MinWidth, plugin.Config.MaxWidth);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                    if (!plugin.Config.ManualSizes)
                    {
                        double randScale = RandomNumberBetween(0.9, 1.03);
                        double fatScale = RandomNumberBetween(0.9, 1.12);
                        ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
                    }
                }
            }
            if (ev.NewRole == RoleType.Tutorial)
            {
                ev.Player.Scale = new Vector3(1, 1, 1);
            }
        }
    }
}