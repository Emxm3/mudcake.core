using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using MudCake.core.SignalR.Hubs;

namespace MudCake.core.Data.Services
{
    public interface IToastService : IToastClient, IDataService
    {
        event Func<HubConnection, string>? OnConnectionRequested;
        Task Connect();

        Task SendOthers(string message, Severity severity = Severity.Normal, string key = "");

        Task SendSelf(string message, Severity severity = Severity.Normal, string key = "");
    }
}