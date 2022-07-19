using Lirmi.Challenge.Data.Transport.Core.Response;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;
using Lirmi.Challenge.WebApp.Agents.Core;
using Lirmi.Challenge.WebApp.Constants;
using System.Text.Json;

namespace Lirmi.Challenge.WebApp.Agents.API.School
{
    public class SchoolAPIAgent : BaseAgent, ISchoolAPIAgent
    {
        public SchoolAPIAgent()
        {

        }

        public async Task<BaseResponse<GetAllSchoolResult>> GetAll()
        {
            var httpRepsonse = await this.GetAsync(URLConstants.SchoolAPI.GET_ALL);
            var stringResponse = await httpRepsonse.Content.ReadAsStringAsync();

            var response = JsonSerializer.Deserialize<BaseResponse<GetAllSchoolResult>>(stringResponse);

            return response;
        }
    }
}
