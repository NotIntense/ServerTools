using Exiled.API.Features;
using System;
using Exiled.API.Enums;
using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace ServerTools
{

    
    public class ServerTools : Plugin<Config>
    {
        public void OnWaitingForPlayers()
        {
            Log.Info(message: "SeverTools is running");
        }

        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
        }


        private Handlers.Player player;
        private Handlers.Server server;

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            server = new Handlers.Server();

            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Player.Dying += player.OnKilled;
            Player.TriggeringTesla += player.TeslaTrigger;
        }

        public void UnRegisterEvents()
        {
            server = null;
            player = null;

            Server.WaitingForPlayers -= server.OnWaitingForPlayers;
            Player.Dying -= player.OnKilled;
        }

    }








}
