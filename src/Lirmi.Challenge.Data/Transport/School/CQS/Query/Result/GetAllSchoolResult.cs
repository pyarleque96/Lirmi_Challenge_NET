using Lirmi.Challenge.Data.Transport.School.QueryEntity;

namespace Lirmi.Challenge.Data.Transport.School.CQS.Query.Result
{
    public class GetAllSchoolResult
    {
        public IEnumerable<SchoolQueryEntity> Schools { get; set; }
    }
}
