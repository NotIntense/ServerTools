using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.Events.EventArgs;



namespace ServerTools.Handlers
{
    class Server
    {
        

        public void OnWaitingForPlayers()
        {
            Log.Info(message: "SeverTools is running");
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
