using MediatR;
using Model.Queries.Entities;

namespace Domain.QueryHandlers
{
    internal class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, GetAllItemsQueryResult>
    {
        public Task<GetAllItemsQueryResult> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetAllItemsQueryResult()
            {
                //TODO: get from db
                Items = default,
            });
        }
    }
}
