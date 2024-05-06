using System.Text.Json;

namespace Postman.Library;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient _httpClient = new();
    public async Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction httpAction = HttpAction.GET)
    {
        var response = await _httpClient.GetAsync(url);
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
