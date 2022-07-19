#nullable disable

namespace Lirmi.Challenge.Data.Transport.School.QueryEntity
{
    public class SchoolQueryEntity
    {
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Code { get; set; }
        public string TypeDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
    }
}
