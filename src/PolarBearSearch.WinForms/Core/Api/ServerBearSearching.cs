using System.Net;
using Core.Search;

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
        bool bearFound = postResponse.StatusCode != HttpStatusCode.NoContent;
        Stream stream = await postResponse.Content.ReadAsStreamAsync();
        Image highlightedImage = new Bitmap(stream);
        return new ImageSearchResult(bearFound, highlightedImage);
    }
}