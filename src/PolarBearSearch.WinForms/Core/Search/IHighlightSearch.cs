namespace Core.Search;

public interface IHighlightSearch
{
    Task<ImageSearchResult> SearchOnAsync(byte[] image);
}