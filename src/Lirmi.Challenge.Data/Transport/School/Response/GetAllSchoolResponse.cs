using Lirmi.Challenge.Data.Transport.Core.Response;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;

namespace Lirmi.Challenge.Data.Transport.School.Response
{
    public class GetAllSchoolResponse : BaseResponse
    {
        public GetAllSchoolResult Result { get; set; }
    }
}
