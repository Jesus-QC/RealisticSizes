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

        float randScale;
        float fatScale;

        private static float RandomFloatBetween(float minValue, float maxValue)
        {
            var next = random.Next();
            return minValue + (next * (maxValue - minValue));
        }

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player == null) return;
            else
            {
                if (plugin.Config.FunMode)
                {
                    randScale = RandomFloatBetween(0.85f, 1.03f);
                    fatScale = RandomFloatBetween(0.8f, 1.12f);
                }
                if (!plugin.Config.FunMode)
                {
                    randScale = RandomFloatBetween(0.9f, 1.03f);
                    fatScale = RandomFloatBetween(0.9f, 1.12f);
                }
                switch (ev.NewRole)
                {
                    case RoleType.Spectator:
                    case RoleType.Tutorial:
                        SetPlayerScale(ev.Player.GameObject, 1, 1, 1);
                        return;
                    case RoleType.ClassD:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.ClassDMinHeight, plugin.Config.ClassDMaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.ClassDMinWidth, plugin.Config.ClassDMaxWidth);
                        }
                        return;
                    case RoleType.Scientist:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.ScientistMinHeight, plugin.Config.ScientistMaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.ScientistMinWidth, plugin.Config.ScientistMaxWidth);
                        }
                        return;
                    case RoleType.FacilityGuard:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.FacilityGuardMinHeight, plugin.Config.FacilityGuardMaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.FacilityGuardMinWidth, plugin.Config.FacilityGuardMaxWidth);
                        }
                        return;
                    case RoleType.NtfCadet:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.NTFCadetMinHeight, plugin.Config.NTFCadetMaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.NTFCadetMinWidth, plugin.Config.NTFCadetMaxWidth);
                        }
                        return;
                    case RoleType.NtfLieutenant:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.NTFLieutenantMinHeight, plugin.Config.NTFLieutenantMaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.NTFLieutenantMinWidth, plugin.Config.NTFLieutenantMaxWidth);
                        }
                        return;
                    case RoleType.NtfCommander:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.CommanderMinHeight, plugin.Config.CommanderMaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.CommanderMinWidth, plugin.Config.CommanderMaxWidth);
                        }
                        return;
                    case RoleType.ChaosInsurgency:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.ChaosInsurgencyMinHeight, plugin.Config.ChaosInsurgencyMaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.ChaosInsurgencyMinWidth, plugin.Config.ChaosInsurgencyMaxWidth);
                        }
                        return;
                    case RoleType.Scp049:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.Scp049MinHeight, plugin.Config.Scp049MaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.Scp049MinWidth, plugin.Config.Scp049MaxWidth);
                        }
                        return;
                    case RoleType.Scp0492:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.Scp0492MinHeight, plugin.Config.Scp0492MaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.Scp0492MinWidth, plugin.Config.Scp0492MaxWidth);
                        }
                        return;
                    case RoleType.Scp096:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.Scp096MinHeight, plugin.Config.Scp096MaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.Scp096MinWidth, plugin.Config.Scp096MaxWidth);
                        }
                        return;
                    case RoleType.Scp106:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.Scp106MinHeight, plugin.Config.Scp106MaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.Scp106MinWidth, plugin.Config.Scp106MaxWidth);
                        }
                        return;
                    case RoleType.Scp173:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.Scp173MinHeight, plugin.Config.Scp173MaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.Scp173MinWidth, plugin.Config.Scp173MaxWidth);
                        }
                        return;
                    case RoleType.Scp93953:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.Scp93953MinHeight, plugin.Config.Scp93953MaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.Scp93953MinWidth, plugin.Config.Scp93953MaxWidth);
                        }
                        return;
                    case RoleType.Scp93989:
                        if (plugin.Config.ManualSizes)
                        {
                            randScale = RandomFloatBetween(plugin.Config.Scp93989MinHeight, plugin.Config.Scp93989MaxHeight);
                            fatScale = RandomFloatBetween(plugin.Config.Scp93989MinWidth, plugin.Config.Scp93989MaxWidth);
                        }
                        return;
                }
                SetPlayerScale(ev.Player.GameObject, fatScale, randScale, randScale);
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