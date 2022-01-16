using Core.Common;
using Core.Extensions;
using Core.Properties;
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

    public async Task<Maybe<Image>> BearOnImage(byte[] image)
    {
        _pictureBox.Replace(image: Resources.LoadingCircle);
        return await _search.BearOnImage(image);
    }
}