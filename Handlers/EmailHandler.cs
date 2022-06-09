using MediatR;
using MediatRApi.DataStore;
using MediatRApi.Notifications;

namespace MediatRApi.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotify>
    {
        private readonly FakeDataSample _fakeDataSample;
        public EmailHandler(FakeDataSample fakeDataSample)
        {
            _fakeDataSample = fakeDataSample;
        }
        public async Task Handle(ProductAddedNotify notification, CancellationToken cancellationToken)
        {
            await this._fakeDataSample.EventOccured(notification.Product, "Email sent");
            await Task.CompletedTask;
        }
    }
}
