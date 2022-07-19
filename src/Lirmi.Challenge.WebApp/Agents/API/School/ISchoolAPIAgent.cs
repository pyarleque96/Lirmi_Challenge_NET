using Lirmi.Challenge.Data.Transport.Core.Response;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;

namespace Lirmi.Challenge.WebApp.Agents.API.School
{
    public interface ISchoolAPIAgent
    {
        Task<BaseResponse<GetAllSchoolResult>> GetAll();
    }
}
