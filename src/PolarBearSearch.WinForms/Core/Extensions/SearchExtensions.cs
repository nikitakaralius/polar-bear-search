using Core.Search;

namespace Core.Extensions;

public static class SearchExtensions
{
    public static EventSearch WhenStartSearching(this IHighlightSearch search, Action @do) => 
        new(search, @do, null);

    public static EventSearch OnSuccess(this EventSearch search, Action @do) =>
        search.WithStart(@do);
}