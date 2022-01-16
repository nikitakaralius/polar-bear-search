using Core.Common;
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

    public async Task<Maybe<Image>> BearOnImage(byte[] image)
    {
        _label.Visible = true;
        Maybe<Image> bearOnImage = await _search.BearOnImage(image);
        _label.Visible = false;
        return bearOnImage;
    }
}