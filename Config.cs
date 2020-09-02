using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RealisticSizes
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
    }
}