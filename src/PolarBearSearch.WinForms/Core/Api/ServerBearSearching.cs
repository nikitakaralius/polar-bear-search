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
        HttpResponseMessage response = await client.PostAsync(_api, new ByteArrayContent(image));
        Image highlightedImage = await HighlightedImage(response);
        return new ImageSearchResult(IsBearFound(response), highlightedImage);
    }

    private static async Task<Image> HighlightedImage(HttpResponseMessage response)
    {
        Stream stream = await response.Content.ReadAsStreamAsync();
        return new Bitmap(stream);
    }

    private static bool IsBearFound(HttpResponseMessage response) => 
        response.StatusCode != HttpStatusCode.NoContent;
}