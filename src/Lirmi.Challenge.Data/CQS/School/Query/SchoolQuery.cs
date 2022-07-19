using Lirmi.Challenge.Data.Context;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Parameter;
using Lirmi.Challenge.Data.Transport.School.CQS.Query.Result;
using Lirmi.Challenge.Data.Transport.School.QueryEntity;
using Microsoft.EntityFrameworkCore;

namespace Lirmi.Challenge.Data.CQS.School.Query
{
    public class SchoolQuery : ISchoolQuery
    {
        private readonly LirmiContext _lirmiContext;

        public SchoolQuery(LirmiContext lirmiContext)
        {
            _lirmiContext = lirmiContext;
        }

        public async Task<GetAllSchoolResult> GetAll()
        {
            var result = await _lirmiContext.School
                                            .Select(x => new SchoolQueryEntity
                                            {
                                                SchoolId = x.SchoolId,
                                                Name = x.Name,
                                                Code = x.Code,
                                                ShortName = x.ShortName,
                                                TypeDescription = x.TypeDescription,
                                                IsActive = x.IsActive,
                                                CreatedDate = x.CreatedDate,
                                                UpdatedDate = x.UpdatedDate
                                            })
                                            .ToListAsync();


            return new GetAllSchoolResult
            {
                Schools = result
            };
        }

        public async Task<GetSingleSchoolResult> GetSingle(GetSingleSchoolParameter parameter)
        {
            IQueryable<SchoolQueryEntity> query = _lirmiContext.School
                                                               .Select(x => new SchoolQueryEntity
                                                               {
                                                                   SchoolId = x.SchoolId,
                                                                   Name = x.Name,
                                                                   Code = x.Code,
                                                                   ShortName = x.ShortName,
                                                                   TypeDescription = x.TypeDescription,
                                                                   IsActive = x.IsActive,
                                                                   CreatedDate = x.CreatedDate,
                                                                   UpdatedDate = x.UpdatedDate
                                                               });

            var result = await query.FirstOrDefaultAsync(x => x.SchoolId == parameter.Id);

            return new GetSingleSchoolResult
            {
                School = result
            };
        }
    }
}
