namespace Lirmi.Challenge.WebApp.Agents.Core
{
    public interface IBaseAgent : IDisposable
    {
        Task<HttpResponseMessage> GetAsync(string asctionName, object request);
    }
}
