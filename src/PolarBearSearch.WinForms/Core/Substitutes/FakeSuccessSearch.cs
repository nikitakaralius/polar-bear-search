using Core.Common;
using Core.Search;

namespace Core.Substitutes;

public class FakeSuccessSearch : IHighlightSearch
{
    public async Task<Maybe<Image>> SearchOnAsync(byte[] image) =>
        await Task.Run(() =>
        {
            Stream stream = new MemoryStream(image);
            return new Maybe<Image>(new Bitmap(stream));
        });
}