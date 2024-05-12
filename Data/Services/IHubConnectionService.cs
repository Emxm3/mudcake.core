using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudCake.core.Data.Services
{
    public interface IHubConnectionService : IDataService
    {
        HubConnection Get<THub>() where THub : Hub;
    }
}
