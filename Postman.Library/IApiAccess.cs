
namespace Postman.Library
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction httpAction = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}