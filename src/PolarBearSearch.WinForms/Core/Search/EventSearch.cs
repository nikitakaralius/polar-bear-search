using Core.Common;

namespace Core.Search;

public class EventSearch : IHighlightSearch
{
    private readonly IHighlightSearch _highlightSearch;
    private readonly Action? _onStartSearching;
    private readonly Action? _onSuccess;
    public EventSearch(IHighlightSearch highlightSearch, Action? onStartSearching, Action? onSuccess)
    {
        _highlightSearch = highlightSearch;
        _onSuccess = onSuccess;
        _onStartSearching = onStartSearching;
    }

    public async Task<Maybe<Image>> BearOnImage(byte[] image)
    {
        _onStartSearching?.Invoke();
        Maybe<Image> bearOnImage = await _highlightSearch.BearOnImage(image);
        if (bearOnImage.HasValue)
        {
            _onSuccess?.Invoke();
        }
        return bearOnImage;
    }

    public EventSearch WithStart(Action onEndSearching) => 
        new(_highlightSearch, _onStartSearching, onEndSearching);
}