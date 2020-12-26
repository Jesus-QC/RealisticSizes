using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Mirror;
using System;
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
            if (ev.Player == null) { return; }
            else
            {
                switch (ev.NewRole)
                {
                    case RoleType.Spectator:
                    case RoleType.Tutorial:
                        SetPlayerScale(ev.Player.GameObject, 1, 1, 1);
                        return;
                    case RoleType.ClassD:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.ClassDMinHeight, plugin.Config.ClassDMaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.ClassDMinWidth, plugin.Config.ClassDMaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scientist:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.ScientistMinHeight, plugin.Config.ScientistMaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.ScientistMinWidth, plugin.Config.ScientistMaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        else
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, 0.5f, 0.5f, 0.5f);
                            }
                            else
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.FacilityGuard:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.FacilityGuardMinHeight, plugin.Config.FacilityGuardMaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.FacilityGuardMinWidth, plugin.Config.FacilityGuardMaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.NtfCadet:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.NTFCadetMinHeight, plugin.Config.NTFCadetMaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.NTFCadetMinWidth, plugin.Config.NTFCadetMaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.NtfLieutenant:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.NTFLieutenantMinHeight, plugin.Config.NTFLieutenantMaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.NTFLieutenantMinWidth, plugin.Config.NTFLieutenantMaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.NtfCommander:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.CommanderMinHeight, plugin.Config.CommanderMaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.CommanderMinWidth, plugin.Config.CommanderMaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.ChaosInsurgency:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.ChaosInsurgencyMinHeight, plugin.Config.ChaosInsurgencyMaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.ChaosInsurgencyMinWidth, plugin.Config.ChaosInsurgencyMaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scp049:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.Scp049MinHeight, plugin.Config.Scp049MaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.Scp049MinWidth, plugin.Config.Scp049MaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scp0492:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.Scp0492MinHeight, plugin.Config.Scp0492MaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.Scp0492MinWidth, plugin.Config.Scp0492MaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scp096:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.Scp096MinHeight, plugin.Config.Scp096MaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.Scp096MinWidth, plugin.Config.Scp096MaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scp106:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.Scp106MinHeight, plugin.Config.Scp106MaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.Scp106MinWidth, plugin.Config.Scp106MaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scp173:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.Scp173MinHeight, plugin.Config.Scp173MaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.Scp173MinWidth, plugin.Config.Scp173MaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scp93953:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.Scp93953MinHeight, plugin.Config.Scp93953MaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.Scp93953MinWidth, plugin.Config.Scp93953MaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                    case RoleType.Scp93989:
                        if (plugin.Config.ManualSizes)
                        {
                            double randScale = RandomNumberBetween(plugin.Config.Scp93989MinHeight, plugin.Config.Scp93989MaxHeight);
                            double fatScale = RandomNumberBetween(plugin.Config.Scp93989MinWidth, plugin.Config.Scp93989MaxWidth);
                            SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                        }
                        if (!plugin.Config.ManualSizes)
                        {
                            if (plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.85, 1.03);
                                double fatScale = RandomNumberBetween(0.8, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                            if (!plugin.Config.FunMode)
                            {
                                double randScale = RandomNumberBetween(0.9, 1.03);
                                double fatScale = RandomNumberBetween(0.9, 1.12);
                                SetPlayerScale(ev.Player.GameObject, (float)fatScale, (float)randScale, (float)randScale);
                            }
                        }
                        return;
                }
            }
        }
        public static void SetPlayerScale(GameObject target, float x, float y, float z)
        {
            try
            {

                NetworkIdentity identity = target.GetComponent<NetworkIdentity>();
                target.transform.localScale = new Vector3(1 * x, 1 * y, 1 * z);

                ObjectDestroyMessage destroyMessage = new ObjectDestroyMessage
                {
                    netId = identity.netId
                };

                foreach (GameObject player in PlayerManager.players)
                {
                    if (player == target)
                        continue;

                    NetworkConnection playerCon = player.GetComponent<NetworkIdentity>().connectionToClient;
                    playerCon.Send(destroyMessage, 0);

                    object[] parameters = new object[] { identity, playerCon };
                    typeof(NetworkServer).InvokeStaticMethod("SendSpawnMessage", parameters);
                }
            }
            catch (Exception e)
            {
                Log.Info($"RealisticSizes error in setting the scale of a player: {e}");
            }
        }
    }
}