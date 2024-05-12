using MudBlazor;

namespace MudCake.core.SignalR.Hubs
{
    public interface IToastClient
    {
        /// <summary>
        /// Sends a toast to all clients
        /// </summary>
        /// <param name="message"></param>
        /// <param name="severity"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        Task Send(string message, Severity severity = Severity.Normal, string key = "");

    }
}