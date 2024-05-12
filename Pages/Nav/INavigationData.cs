using Microsoft.AspNetCore.Components.Routing;

namespace MudCake.core.Pages.Nav
{
    public interface INavigationData
    {
        string Href { get; }
        NavLinkMatch Match { get;  }
        string Icon { get;  }
        string Title { get;  }
        string Text { get;  }
    }
}
