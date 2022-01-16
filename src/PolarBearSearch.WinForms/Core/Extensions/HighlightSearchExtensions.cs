using Core.Common;
using Core.Search;

namespace Core.Extensions;

public static class HighlightSearchExtensions
{
    public static async Task<Maybe<Image>> BearOnImageAsync(this IHighlightSearch search, string imagePath) => 
        await search.BearOnImage(await File.ReadAllBytesAsync(imagePath));
}