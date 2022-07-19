using Lirmi.Challenge.Data.Transport.School.CQS.Query.Parameter;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;

namespace Lirmi.Challenge.Data.CQS.School.Query
{
    public interface ISchoolQuery
    {
        Task<GetAllSchoolResult> GetAll();
        Task<GetSingleSchoolResult> GetSingle(GetSingleSchoolParameter parameter);
    }
}
