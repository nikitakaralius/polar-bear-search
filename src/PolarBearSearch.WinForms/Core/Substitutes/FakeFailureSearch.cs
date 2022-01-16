using Core.Common;
using Core.Search;

namespace Core.Substitutes;

public class FakeFailureSearch : IHighlightSearch
{
    public async Task<Maybe<Image>> SearchOnAsync(byte[] image)
    {
        await Task.Delay(1000);
        return Maybe<Image>.Nothing;
    }
}