using Exiled.API.Features;
using RealisticSizes.Handlers;
using System;

namespace RealisticSizes
{
    public class RealisticSizes : Plugin<Config>
    {
        private EventHandlers EventHandlers;

        public override string Name { get; } = "RealisticSizes";
        public override string Author { get; } = "JesusQC";
        public override string Prefix { get; } = "RealisticSizes";
        public override Version RequiredExiledVersion { get; } = new Version(2, 6, 0);
        public override Version Version { get; } = new Version(3, 1, 5);

        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers(this);

            Exiled.Events.Handlers.Player.ChangingRole += EventHandlers.OnChangingRole;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= EventHandlers.OnChangingRole;

            EventHandlers = null;
            base.OnDisabled();
        }
    }
}