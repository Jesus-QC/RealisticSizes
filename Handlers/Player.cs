using Exiled.Events.EventArgs;
using UnityEngine;

namespace RealisticSizes.Handlers
{
    class Player
    {
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
                double randScale = RandomNumberBetween(0.9, 1.11);
                double fatScale = RandomNumberBetween(0.8, 1.12);
                ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
            }
            if (ev.NewRole == RoleType.Scientist)
            {
                double randScale = RandomNumberBetween(0.9, 1.11);
                double fatScale = RandomNumberBetween(0.8, 1.12);
                ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
            }
            if (ev.NewRole == RoleType.FacilityGuard)
            {
                double randScale = RandomNumberBetween(0.9, 1.11);
                double fatScale = RandomNumberBetween(0.8, 1.12);
                ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
            }
            if (ev.NewRole == RoleType.NtfCadet)
            {
                double randScale = RandomNumberBetween(0.9, 1.11);
                double fatScale = RandomNumberBetween(0.8, 1.12);
                ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
            }
            if (ev.NewRole == RoleType.NtfLieutenant)
            {
                double randScale = RandomNumberBetween(0.9, 1.11);
                double fatScale = RandomNumberBetween(0.8, 1.12);
                ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
            }
            if (ev.NewRole == RoleType.NtfCommander)
            {
                double randScale = RandomNumberBetween(0.9, 1.11);
                double fatScale = RandomNumberBetween(0.8, 1.12);
                ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
            }
            if (ev.NewRole == RoleType.ChaosInsurgency)
            {
                double randScale = RandomNumberBetween(0.9, 1.11);
                double fatScale = RandomNumberBetween(0.8, 1.12);
                ev.Player.Scale = new Vector3((float)fatScale, (float)randScale, (float)randScale);
            }
        }
        public void OnPlayerDying(DyingEventArgs ev)
        {
            ev.Target.Scale = new Vector3(1, 1, 1);
        }
    }
}
