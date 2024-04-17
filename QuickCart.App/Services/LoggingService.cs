using QuickCart.App.Entities;
using QuickCart.App.Stores;

namespace QuickCart.App.Services
{
    public class LoggingService
    {
        public LoggingService(EventStore eventStore)
        {
            // Логування створення нового облікового запису
            eventStore.AccountCreated += LogAccountCreation;

            // Логування авторизації користувача
            eventStore.UserAuthorized += LogUserAuthorization;

            // Логування додавання нового товару
            eventStore.ProductAdded += LogProductAddition;

            // Логування оновлення товару
            eventStore.ProductUpdated += LogProductUpdate;

            // Логування видалення товару
            eventStore.ProductDeleted += LogProductDeletion;
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
