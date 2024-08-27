using MediatR;
using Model.Command;

namespace Domain.Handlers
{
    internal class SampleCommandHandler : IRequestHandler<SampleCommand, SampleCommandComplete>
    {
        public Task<SampleCommandComplete> Handle(SampleCommand request, CancellationToken cancellationToken)
        {
            //TODO: insert in write db
            //TODO: raise notification
            return Task.FromResult(new SampleCommandComplete() { IsComplete = true });
        }
    }
}
