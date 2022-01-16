using Core.Common;

namespace Core.Search;

public interface IHighlightSearch
{
    Task<Maybe<Image>> BearOnImage(byte[] image);
}