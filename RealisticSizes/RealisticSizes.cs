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

        public override void OnEnabled()
        {
            base.OnEnabled();

            EventHandlers = new EventHandlers(this);

            Exiled.Events.Handlers.Player.ChangingRole += EventHandlers.OnChangingRole;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Player.ChangingRole -= EventHandlers.OnChangingRole;

            EventHandlers = null;
        }
    }
}