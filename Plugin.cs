using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp096;
using System;

namespace _096_Warning
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "096 Warning";
        public override string Author => "Naleśnior";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 5, 1);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Scp096.AddingTarget += OnAddingTarget;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp096.AddingTarget -= OnAddingTarget;
            base.OnDisabled();
        }

        private void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.Target.ShowHint(Config.WarningMessage, 5);
        }
    }
}
