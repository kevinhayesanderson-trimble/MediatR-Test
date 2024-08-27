using MediatR;
using Model.Queries.Entities;

namespace Domain.QueryHandlers
{
    internal class GetItemQueryHandler : IRequestHandler<GetItemQuery, GetItemQueryResult>
    {
        public Task<GetItemQueryResult> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetItemQueryResult()
            {
                //TODO: get items from db
                Item = default,
            });
        }
    }
}
