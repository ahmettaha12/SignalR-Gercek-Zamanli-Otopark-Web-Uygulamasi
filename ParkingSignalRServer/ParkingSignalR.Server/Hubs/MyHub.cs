using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSignalR.Server.Hubs
{
    public class MyHub:Hub
    {

        public async Task SendDataAsync(string Floor)
        {

            await Clients.All.SendAsync("receiveData", Floor);
        }
    }
}
