using QuickCart.App.Entities;
using QuickCart.App.Stores;

namespace QuickCart.App.Services
{
    public class EmailService
    {
        public EmailService(EventStore eventStore)
        {
            // Відправка листа з підтвердженням на електронну пошту
            eventStore.AccountCreated += SendConfirmationEmailHandler;

            // Відправка повідомлення про вхід в систему на електронну пошту користувача
            eventStore.UserAuthorized += SendLoginNotificationHandler;

            // Відправка повідомлення продавцю про успішне додавання товару
            eventStore.ProductAdded += SendNotificationAddingProductHandler;

            // Відправка повідомлення продавцю про успішне оновлення даних товару
            eventStore.ProductUpdated += SendNotificationUpdatingProductHandler;

            // Відправка повідомлення продавцю про успішне видалення товару
            eventStore.ProductDeleted += SendNotificationDeletingProductHandler;
        }

        private async Task SendNotificationUpdatingProductHandler(Product product, User seller)
        {
            string? email = seller.Email;
            await /*Асинхронна відправка листа*/;
        }

        private async Task SendNotificationAddingProductHandler(Product arg, User seller)
        {
            string? email = seller.Email;
            await /*Асинхронна відправка листа*/;
        }

        private async Task SendNotificationDeletingProductHandler(Product product, User seller)
        {
            string? email = seller.Email;
            await /*Асинхронна відправка листа*/;
        }

        private async Task SendLoginNotificationHandler(User user)
        {
            string? email = user.Email;
            await /*Асинхронна відправка листа*/;
        }

        private async Task SendConfirmationEmailHandler(User user)
        {
            string? email = user.Email;
            await /*Асинхронна відправка листа*/;
        }
    }
}
