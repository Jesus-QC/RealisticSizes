using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Mirror;
using System;
using System.Text.RegularExpressions;
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
            if (ev.Player != null)
            {
                MEC.Timing.CallDelayed(0.4f, () =>
                {
                    try
                    {
                        if (plugin.Config.FunMode)
                        {
                            randScale = RandomFloatBetween(0.5f, 1.15f);
                            fatScale = RandomFloatBetween(0.5f, 1.15f);
                        }
                        else if (!plugin.Config.FunMode)
                        {
                            randScale = RandomFloatBetween(0.9f, 1.1f);
                            fatScale = RandomFloatBetween(0.9f, 1.1f);
                        }

                        if (plugin.Config.ManualSizes && plugin.Config.a.ContainsKey(ev.NewRole))
                        {
                            var match = Regex.Match(plugin.Config.a[ev.NewRole], "(.*):(.*)::(.*):(.*)");
                            randScale = RandomFloatBetween(float.Parse(match.Groups[1].ToString()), float.Parse(match.Groups[3].ToString()));
                            fatScale = RandomFloatBetween(float.Parse(match.Groups[0].ToString()), float.Parse(match.Groups[2].ToString()));
                        }
                        SpawnPlayer(ev.Player, randScale, fatScale);
                    }
                    catch (Exception e)
                    {
                        Log.Error("Realistic sizes: " + e);
                    }
                });
            }
        }
        
        public void SpawnPlayer(Player ply, float Scale1, float Scale2)
        {
            try
            {
                NetworkIdentity identity = ply.GameObject.GetComponent<NetworkIdentity>();
                ply.GameObject.transform.localScale = new Vector3(1 * Scale1, 1 * Scale2, 1 * Scale2);

                ObjectDestroyMessage destroyMessage = new ObjectDestroyMessage();
                destroyMessage.netId = identity.netId;

                foreach (GameObject player in PlayerManager.players)
                {
                    NetworkConnection playerCon = player.GetComponent<NetworkIdentity>().connectionToClient;
                    if (player != ply.GameObject)
                        playerCon.Send(destroyMessage, 0);

                    object[] parameters = new object[] { identity, playerCon };
                    typeof(NetworkServer).InvokeStaticMethod("SendSpawnMessage", parameters);
                }
            }
            catch (Exception e)
            {
                Log.Info($"Set Scale error: {e}");
            }
        }
    }
}