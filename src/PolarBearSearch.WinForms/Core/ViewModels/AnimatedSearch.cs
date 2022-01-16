using Core.Common;
using Core.Search;

namespace Core.ViewModels;

public class AnimatedSearch : IHighlightSearch
{
    private readonly IHighlightSearch _search;
    private readonly PictureBox _pictureBox;
    
    public AnimatedSearch(IHighlightSearch search, PictureBox pictureBox)
    {
        _search = search;
        _pictureBox = pictureBox;
    }

    public async Task<Maybe<Image>> SearchOnAsync(byte[] image)
    {
        return await _search.SearchOnAsync(image);
    }
}