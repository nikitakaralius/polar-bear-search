using Microsoft.Extensions.Configuration;

namespace Core.IO;

public class ConfigurationDialogFilter : IDialogFilter
{
    public ConfigurationDialogFilter(IConfiguration configuration)
    {
        IConfiguration configuration1 = configuration;
        OfOpen = configuration1["Filter:Open"];
        OfSave = configuration1["Filter:Save"];
    }

    public string OfOpen { get; }
    public string OfSave { get; }
}