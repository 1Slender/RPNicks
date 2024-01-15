
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

namespace RPNicks
{
    public class Main : Plugin<Config>
    {
        public static Main Plugin { get; private set; }
        public override string Author { get; } = "ShoulHate";
        public override string Name { get; } = "RPNicks";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 7, 0);

        private Random random = new Random();

        public override void OnEnabled()
        {
            Plugin = this;

            Exiled.Events.Handlers.Player.Spawned += OnSpawned;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= OnSpawned;

            base.OnDisabled();
        }

        private void OnSpawned(SpawnedEventArgs ev)
        {
            if (ev.Player == null || !ev.Player.IsHuman) return;

            if (ev.Player.Role.Type == PlayerRoles.RoleTypeId.ClassD)
            {
                ev.Player.DisplayNickname = $"D-{random.Next(999)}";
            }
            else
            {
                ev.Player.DisplayNickname = $"{Config.names[random.Next(Config.names.Count)]} {Config.surnames[random.Next(Config.surnames.Count)]}";
            }
        }
    }
}
