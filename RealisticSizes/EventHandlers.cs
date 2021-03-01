using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using Mirror;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace RealisticSizes.Handlers
{
    public class EventHandlers
    {
        public RealisticSizes plugin;
        public EventHandlers(RealisticSizes plugin) => this.plugin = plugin;

        float randScale;
        float fatScale;

        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player != null)
            {
                Timing.CallDelayed(plugin.Config.IsAntiLagEnabled && Player.List.Count() > plugin.Config.AntiLagMinplayers ? UnityEngine.Random.Range(0.4f, 5f) : 0.4f, () =>
                {
                    try
                    {
                        if (plugin.Config.ActiveMode == Config.Mode.Fun)
                        {
                            randScale = UnityEngine.Random.Range(0.5f, 1.15f);
                            fatScale = UnityEngine.Random.Range(0.5f, 1.15f);
                        }
                        else if (plugin.Config.ActiveMode == Config.Mode.Roleplay)
                        {
                            randScale = UnityEngine.Random.Range(0.9f, 1.1f);
                            fatScale = UnityEngine.Random.Range(0.9f, 1.1f);
                        }
                        else if (plugin.Config.ActiveMode == Config.Mode.Manual && plugin.Config.manualSizes.ContainsKey(ev.NewRole))
                        {
                            var match = Regex.Match(plugin.Config.manualSizes[ev.NewRole], "(.*):(.*)::(.*):(.*)");
                            randScale = UnityEngine.Random.Range(float.Parse(match.Groups[2].ToString()), float.Parse(match.Groups[4].ToString()));
                            fatScale = UnityEngine.Random.Range(float.Parse(match.Groups[1].ToString()), float.Parse(match.Groups[3].ToString()));
                        }
                        if (plugin.Config.AllowUnproportionalValues)
                        {
                            fatScale = randScale;
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
                ply.GameObject.transform.localScale = new Vector3(1 * Scale2, 1 * Scale1, 1 * Scale2);

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