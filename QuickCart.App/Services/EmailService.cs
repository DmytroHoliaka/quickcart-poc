using QuickCart.App.Entities;
using QuickCart.App.Stores;

namespace QuickCart.App.Services
{
    public class EmailService : IDisposable
    {
        private readonly EventStore _eventStore;

        public EmailService(EventStore eventStore)
        {
            _eventStore = eventStore;

            // Відправка листа з підтвердженням на електронну пошту
            _eventStore.AccountCreated += SendConfirmationEmailHandler;

            // Відправка повідомлення про вхід в систему на електронну пошту користувача
            _eventStore.UserAuthorized += SendLoginNotificationHandler;

            // Відправка повідомлення продавцю про успішне додавання товару
            _eventStore.ProductAdded += SendNotificationAddingProductHandler;

            // Відправка повідомлення продавцю про успішне оновлення даних товару
            _eventStore.ProductUpdated += SendNotificationUpdatingProductHandler;

            // Відправка повідомлення продавцю про успішне видалення товару
            _eventStore.ProductDeleted += SendNotificationDeletingProductHandler;
        }
        
        public void Dispose()
        {
            _eventStore.AccountCreated -= SendConfirmationEmailHandler;
            _eventStore.UserAuthorized -= SendLoginNotificationHandler;
            _eventStore.ProductAdded -= SendNotificationAddingProductHandler;
            _eventStore.ProductUpdated -= SendNotificationUpdatingProductHandler;
            _eventStore.ProductDeleted -= SendNotificationDeletingProductHandler;

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
