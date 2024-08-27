using Model.Request;

namespace Model.Queries.Entities
{
    public class GetItemQuery : IQuery<GetItemQueryResult>
    {

    }

    public class GetItemQueryResult :IQueryResult
    {
        public string Item { get; set; }
    }
}
