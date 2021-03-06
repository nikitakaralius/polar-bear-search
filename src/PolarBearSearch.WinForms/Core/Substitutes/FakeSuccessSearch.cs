using Core.Common;
using Core.Search;

namespace Core.Substitutes;

public class FakeSuccessSearch : IHighlightSearch
{
    public async Task<Maybe<Image>> BearOnImage(byte[] image)
    {
        await Task.Delay(1000);
        Stream stream = new MemoryStream(image);
        return new Maybe<Image>(new Bitmap(stream));
    }
}