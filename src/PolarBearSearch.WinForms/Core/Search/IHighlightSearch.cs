using Core.Common;

namespace Core.Search;

public interface IHighlightSearch
{
    Task<Maybe<Image>> SearchOnAsync(byte[] image);
}