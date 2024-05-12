using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudCake.core.Data.Services;
using System.Text.Json;

namespace MudCake.core.Data.Site
{
    public interface ISiteConfig : IDataService
    {
        string AppName { get; set; }
        MarkupString AppNameMarkup { get; set; }
        string? Connectionstring { get; set; }
        bool IsDarkTheme { get; set; }
        JsonSerializerOptions JsonSerializerOptions { get; set; }
        string? SwaggerUri { get; }
        public MudTheme? Theme { get; set; }
    }
}