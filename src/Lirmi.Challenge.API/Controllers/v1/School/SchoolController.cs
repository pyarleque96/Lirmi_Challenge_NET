using Lirmi.Challenge.API.Services;
using Lirmi.Challenge.Data.Transport.Core.Request;
using Lirmi.Challenge.Data.Transport.Core.Response;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Parameter;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;
using Lirmi.Challenge.Data.Transport.School.Response;
using Microsoft.AspNetCore.Mvc;

namespace Lirmi.Challenge.API.Controllers.v1
{
    public class SchoolController : BaseController
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet(Name = "GetAllSchool")]
        public async Task<BaseResponse<GetAllSchoolResult>> GetAll()
        {
            return await _schoolService.GetAll();
        }

        [HttpGet(Name = "GetSingleSchool")]
        public async Task<BaseResponse<GetSingleSchoolResult>> GetSingle(int id)
        {
            return await _schoolService.GetSingle(BaseRequest.Create(new GetSingleSchoolParameter
            {
                Id = id
            }));
        }
    }
}
