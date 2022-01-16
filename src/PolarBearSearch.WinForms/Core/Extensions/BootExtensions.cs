using Core.Api;
using Core.Search;
using Microsoft.Extensions.Configuration;

namespace Core.Extensions;

internal static class BootExtensions
{
    internal static Uri RemoteServer(this IConfiguration configuration) => 
        new(configuration["Api:Uri"]);

    internal static IHighlightSearch Search(this Uri remoteServer) => 
        new ServerBearSearching(remoteServer);
}