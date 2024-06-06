using System.Text;
using System.Text.Json;

namespace Postman.Library;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient _httpClient = new();

    public async Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true)
    {
        StringContent? stringContent = new(content, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, new StringContent(content), action, formatOutput);
    }

    public async Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction httpAction = HttpAction.GET, bool formatOutput = true)
    {
        HttpResponseMessage? response;
        switch (httpAction)
        {
            case HttpAction.GET:
                response = await _httpClient.GetAsync(url);
                break;
            case HttpAction.POST:
                response = await _httpClient.PostAsync(url, content);
                break;
            case HttpAction.PUT:
                response = await _httpClient.PutAsync(url, content);
                break;
            case HttpAction.PATCH:
                response = await _httpClient.PatchAsync(url, content);
                break;
            case HttpAction.DELETE:
                response = await _httpClient.DeleteAsync(url);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(httpAction), httpAction, null);
        }

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            if (formatOutput)
            {
                var jsonElemet = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElemet, new JsonSerializerOptions { WriteIndented = true });
            }
            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }

    public bool IsValidUrl(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) && uriOutput.Scheme == Uri.UriSchemeHttps;
    }
}
