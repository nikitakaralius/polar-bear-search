using Core.Api;
using Core.IO;
using Core.Search;
using Core.Substitutes;
using Microsoft.Extensions.Configuration;

namespace Core.Extensions;

internal static class BootExtensions
{
    internal static Uri RemoteServer(this IConfiguration configuration) => 
        new(configuration["Api:Uri"]);

    internal static IHighlightSearch Search(this Uri remoteServer) => 
        new ServerBearSearching(remoteServer);
    
    internal static IHighlightSearch FakeSuccessSearch(this Uri remoteServer) => 
        new FakeSuccessSearch();

    internal static IHighlightSearch FakeFailureSearch(this Uri remoteServer) => 
        new FakeFailureSearch();

    internal static IDialogFilter DialogFilter(this IConfiguration configuration) => 
        new ConfigurationDialogFilter(configuration);
}