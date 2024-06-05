namespace Postman.Library
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, string content, HttpAction httpAction = HttpAction.GET, bool formatOutput = true);
        Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction httpAction = HttpAction.GET, bool formatOutput = true);
        bool IsValidUrl(string url);
    }
}