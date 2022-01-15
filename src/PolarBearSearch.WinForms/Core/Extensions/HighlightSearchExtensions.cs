using Core.Search;

namespace Core.Extensions;

public static class HighlightSearchExtensions
{
    public static async Task<ImageSearchResult> SearchOnAsync(this IHighlightSearch search, string imagePath) => 
        await search.SearchOnAsync(await File.ReadAllBytesAsync(imagePath));
}