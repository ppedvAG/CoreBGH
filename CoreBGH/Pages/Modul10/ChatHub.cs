using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBGH.Pages.Modul10
{
    public class ChatHub:Hub
    {
        public void Sende(string Nachricht)
        {
            Clients.All.SendAsync("ClientPush", Nachricht);
        }
    }
}
