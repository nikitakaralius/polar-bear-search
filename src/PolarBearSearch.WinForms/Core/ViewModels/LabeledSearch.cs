using Core.Search;

namespace Core.ViewModels;

public class LabeledSearch : IHighlightSearch
{
    private readonly IHighlightSearch _search;
    private readonly Label _label;

    public LabeledSearch(IHighlightSearch search, Label label)
    {
        _search = search;
        _label = label;
        _label.Visible = false;
    }

    public async Task<ImageSearchResult> SearchOnAsync(byte[] image)
    {
        _label.Visible = true;
        ImageSearchResult searchResult = await _search.SearchOnAsync(image);
        _label.Visible = false;
        return searchResult;
    }
}