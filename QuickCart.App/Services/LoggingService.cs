using QuickCart.App.Entities;
using QuickCart.App.Stores;

namespace QuickCart.App.Services
{
    public class LoggingService : IDisposable
    {
        private readonly EventStore _eventStore;

        public LoggingService(EventStore eventStore)
        {
            _eventStore = eventStore;

            // Логування створення нового облікового запису
            _eventStore.AccountCreated += LogAccountCreation;

            // Логування авторизації користувача
            _eventStore.UserAuthorized += LogUserAuthorization;

            // Логування додавання нового товару
            _eventStore.ProductAdded += LogProductAddition;

            // Логування оновлення товару
            _eventStore.ProductUpdated += LogProductUpdate;

            // Логування видалення товару
            _eventStore.ProductDeleted += LogProductDeletion;
        }

        public void Dispose()
        {
            _eventStore.AccountCreated -= LogAccountCreation;
            _eventStore.UserAuthorized -= LogUserAuthorization;
            _eventStore.ProductAdded -= LogProductAddition;
            _eventStore.ProductUpdated -= LogProductUpdate;
            _eventStore.ProductDeleted -= LogProductDeletion;
        }

        private async Task LogAccountCreation(User user)
        {
            await /*Логування створення аккаунту*/;
        }

        private async Task LogUserAuthorization(User user)
        {
            await /*Логування авторизації користувача*/;
        }

        private async Task LogProductAddition(Product product, User seller)
        {
            await /*Логування додавання товару*/;
        }

        private async Task LogProductUpdate(Product product, User seller)
        {
            await /*Логування оновлення товару*/;
        }

        private async Task LogProductDeletion(Product product, User seller)
        {
            await /*Логування видалення товару*/;
        }
    }
}
