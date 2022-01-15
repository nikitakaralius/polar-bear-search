using Core.Search;
using Image = SixLabors.ImageSharp.Image;

namespace Core.Api;

public class ServerBearSearching : IHighlightSearch
{
    private readonly Uri _api;

    public ServerBearSearching(Uri api)
    {
        _api = api;
    }
    
    public async Task<ImageSearchResult> SearchOnAsync(byte[] image)
    {
        HttpClient client = new();
        HttpResponseMessage postResponse = await client.PostAsync(_api, new ByteArrayContent(image));
        HttpResponseMessage getResponse = await client.GetAsync(_api);
        string bearFoundResponse = await getResponse.Content.ReadAsStringAsync();
        bool bearFound = Convert.ToBoolean(bearFoundResponse);
        Stream stream = await postResponse.Content.ReadAsStreamAsync();
        Image highlightedImage = await Image.LoadAsync(stream);
        return new ImageSearchResult(bearFound, highlightedImage);
    }
}