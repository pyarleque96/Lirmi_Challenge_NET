using Lirmi.Challenge.Data.Transport.Core.Request;
using Lirmi.Challenge.Data.Transport.Core.Response;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Parameter;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;

namespace Lirmi.Challenge.API.Services
{
    public interface ISchoolService
    {
        Task<BaseResponse<GetAllSchoolResult>> GetAll();
        Task<BaseResponse<GetSingleSchoolResult>> GetSingle(BaseRequest<GetSingleSchoolParameter> request);
    }
}
