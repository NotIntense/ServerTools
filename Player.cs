using System;
using Exiled.Events.EventArgs;
using Exiled.API.Extensions;
using Exiled.API.Enums;
using Exiled.API.Features;


namespace ServerTools.Handlers
{
    class Player
    {
        public void OnKilled(DyingEventArgs ev)
        {
            if (ev.Killer.Id != (ev.Target.Id))
            {
                if (ev.Killer.IsScp && (ev.Target.IsNTF))
                {
                    return;
                }
                if (ev.Killer.IsNTF && (ev.Target.IsScp))
                {
                    return;
                }

                if (ev.Killer.IsNTF && (ev.Target.IsTutorial))
                {
                    return;
                }
                if (ev.Killer.IsTutorial && (ev.Target.IsNTF))
                {
                    return;
                }
                if (ev.Killer.IsCHI && (ev.Target.IsScp))
                {
                    return;
                }
                if (ev.Killer.IsScp && (ev.Target.IsCHI))
                {
                    return;
                }
;
                if (ev.Killer.IsCHI == (ev.Target.IsCHI))
                {
                    Map.Broadcast(duration: 5, message: $"{ev.Killer.Nickname} has teamkilled {ev.Target.Nickname}");
                    Log.Info(message: $"{ev.Killer.Nickname} with an IP of {ev.Killer.IPAddress} and an ID of {ev.Killer.Id} has teamkilled {ev.Target.Nickname}");
                }
                else;
                {
                    return;
                }

                if (ev.Killer.IsNTF == (ev.Target.IsNTF))
                {
                    Map.Broadcast(duration: 5, message: $"{ev.Killer.Nickname} has teamkilled {ev.Target.Nickname}");
                    Log.Info(message: $"{ev.Killer.Nickname} with an IP of {ev.Killer.IPAddress} and an ID of {ev.Killer.Id} has teamkilled {ev.Target.Nickname}");
                }
                else;
                {
                    return;
                }
              


            }
            
        }

        public void TeslaTrigger(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.IsNTF)
            {
                ev.IsTriggerable = false;
            }
        }

        

        

    }
}
