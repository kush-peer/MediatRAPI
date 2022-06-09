using MediatR;
using MediatRApi.Models;

namespace MediatRApi.Notifications
{
    public record ProductAddedNotify(Product Product): INotification;
}
