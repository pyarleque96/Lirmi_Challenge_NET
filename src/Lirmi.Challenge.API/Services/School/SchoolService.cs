using Lirmi.Challenge.Data.CQS.School.Command;
using Lirmi.Challenge.Data.CQS.School.Query;
using Lirmi.Challenge.Data.Transport.Core.Request;
using Lirmi.Challenge.Data.Transport.Core.Response;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Parameter;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;

namespace Lirmi.Challenge.API.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolQuery _schoolQuery;
        private readonly ISchoolCommand _schoolCommand;

        public SchoolService(ISchoolQuery schoolQuery,
                             ISchoolCommand schoolCommand)
        {
            _schoolQuery = schoolQuery;
            _schoolCommand = schoolCommand;
        }

        public async Task<BaseResponse<GetAllSchoolResult>> GetAll()
        {
            var response = new BaseResponse<GetAllSchoolResult>();

            try
            {
                var result = await _schoolQuery.GetAll();

                response.Correct(result);
            }
            catch (Exception ex)
            {
                response.Fail(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse<GetSingleSchoolResult>> GetSingle(BaseRequest<GetSingleSchoolParameter> request)
        {
            var response = new BaseResponse<GetSingleSchoolResult>();

            try
            {
                var result = await _schoolQuery.GetSingle(request.Parameter);

                response.Correct(result);
            }
            catch (Exception ex)
            {
                response.Fail(ex.Message);
            }

            return response;
        }
    }
}
