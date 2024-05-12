using MudCake.core.Data.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudCake.core.Data.Hubs.Clients
{
    public interface ISiteConfigClient
    {
        Task Update(ISiteConfig siteConfig);
    }
}
