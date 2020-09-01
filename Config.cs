using Exiled.API.Interfaces;

namespace RealisticSizes
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}