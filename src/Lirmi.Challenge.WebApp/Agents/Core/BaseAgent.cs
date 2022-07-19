namespace Lirmi.Challenge.WebApp.Agents.Core
{
    public class BaseAgent : IBaseAgent
    {
        private const string BaseUrl = "http://localhost:19451";

        public BaseAgent()
        {

        }

        public async Task<HttpResponseMessage> GetAsync(string actionName)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();

            using (var httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri(BaseUrl) })
            {
                try
                {
                    httpClient.Timeout = TimeSpan.FromMinutes(30);
                    var response = await httpClient.GetAsync(actionName);

                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task<HttpResponseMessage> GetAsync(string actionName, object request)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();

            using (var httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri(BaseUrl) })
            {
                try
                {
                    httpClient.Timeout = TimeSpan.FromMinutes(30);
                    var response = await httpClient.GetAsync(actionName);

                    return response;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Dispose()
        {
        }
    }
}
