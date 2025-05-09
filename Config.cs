using Exiled.API.Interfaces;

namespace _096_Warning
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string WarningMessage { get; set; } = "Warning! You are looked on scp 096!";
    }
}
