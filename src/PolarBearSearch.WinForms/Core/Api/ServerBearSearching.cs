using System.Net;
using Core.Common;
using Core.Search;

namespace Core.Api;

public class ServerBearSearching : IHighlightSearch
{
    private readonly Uri _api;
    
    public ServerBearSearching(Uri api)
    {
        _api = api;
    }
    
    public async Task<Maybe<Image>> SearchOnAsync(byte[] image)
    {
        HttpClient client = new();
        HttpResponseMessage response = await client.PostAsync(_api, new ByteArrayContent(image));
        bool bearFound = IsBearFound(response);
        return bearFound
            ? new Maybe<Image>(await HighlightedImage(response), bearFound)
            : Maybe<Image>.Nothing;
    }

    private static async Task<Image> HighlightedImage(HttpResponseMessage response)
    {
        Stream stream = await response.Content.ReadAsStreamAsync();
        return new Bitmap(stream);
    }

    private static bool IsBearFound(HttpResponseMessage response) => 
        response.StatusCode != HttpStatusCode.NoContent;
}