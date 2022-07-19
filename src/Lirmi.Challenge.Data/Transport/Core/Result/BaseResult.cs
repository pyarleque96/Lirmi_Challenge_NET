namespace Lirmi.Challenge.Data.Transport.Core.Result
{
    using Lirmi.Challenge.Data.Transport.Core.Result.QueryResult;

    public class BaseResult<T>
    {
        public PaginationRawResult Pagination { get; set; }

        public BaseResult()
        {
            Pagination = new PaginationRawResult();
        }
    }
}
