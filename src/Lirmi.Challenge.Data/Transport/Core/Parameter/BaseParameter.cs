namespace Lirmi.Challenge.Data.Transport.Core.Parameter
{
    public class BaseParameter
    {
        public BasePaginationParameter Pagination { get; set; }
        public BaseParameter()
        {
            Pagination = new BasePaginationParameter();
        }
    }
}
