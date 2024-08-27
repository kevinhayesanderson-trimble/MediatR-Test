using Model.Request;

namespace Model.Queries.Entities
{
    public class GetAllItemsQuery : IQuery<GetAllItemsQueryResult>
    {
    }

    public class GetAllItemsQueryResult : IQueryResult
    {
        public List<string> Items { get; set; }
    }
}
