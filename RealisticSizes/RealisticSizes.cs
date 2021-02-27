using Exiled.API.Features;
using RealisticSizes.Handlers;
using System;

namespace RealisticSizes
{
    public class RealisticSizes : Plugin<Config>
    {
        private EventHandlers EventHandlers;

        public override string Name { get; } = "RealisticSizes";
        public override string Author { get; } = "JesusQC with <3";
        public override string Prefix { get; } = "RealisticSizes";
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 33);
        public override Version Version { get; } = new Version(3, 2, 1);

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