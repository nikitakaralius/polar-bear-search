using Image = SixLabors.ImageSharp.Image;

namespace Core.Search;

public record ImageSearchResult(bool Found, Image Image);