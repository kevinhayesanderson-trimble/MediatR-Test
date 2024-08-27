using MediatR;
using Model.Notifications;

namespace Domain.NotificationHandler
{
    internal class DataUpdateNotificationHandler : INotificationHandler<DataUpdateNotification>
    {
        public Task Handle(DataUpdateNotification notification, CancellationToken cancellationToken)
        {
            var item = notification.Item;
            //TODO: update read db
            return Task.CompletedTask;
        }
    }
}
