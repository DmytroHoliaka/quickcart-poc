using QuickCart.App.Entities;
using QuickCart.App.Stores;

namespace QuickCart.App.Services
{
    public class DatabaseService : IDisposable
    {
        private readonly EventStore _eventStore;

        public DatabaseService(EventStore eventStore)
        {
            _eventStore = eventStore;

            // Запис даних користувача в базу даних
            _eventStore.AccountCreated += CreateUserHandler;
            
            // Запис даних товару в базу даних
            _eventStore.ProductAdded += CreateProductHandler;
            
            // Запис оновлених даних товару в базу даних
            _eventStore.ProductUpdated += UpdateProductHandler;
            
            // Видалення даних товару з бази даних
            _eventStore.ProductDeleted += DeleteProductHandler;
        }

        public void Dispose()
        {
            _eventStore.AccountCreated -= CreateUserHandler;
            _eventStore.ProductAdded -= CreateProductHandler;
            _eventStore.ProductUpdated -= UpdateProductHandler;
            _eventStore.ProductDeleted -= DeleteProductHandler;
        }

        public async Task CreateUserHandler(User userData)
        {
            await /*Виклик асинхронного метода запису нового користувача в базу даних*/;
        }

        public async Task CreateProductHandler(Product productData, User seller)
        {
            await /*Виклик асинхронного метода запису нового товару в базу даних*/;
        }

        public async Task UpdateProductHandler(Product targetProduct, User seller)
        {
            await /*Виклик асинхронного метода оновлення товару в базі даних*/;
        }

        public async Task DeleteProductHandler(Product deletingProduct, User seller)
        {
            await /*Виклик асинхронного метода видалення товару з бази даних*/;
        }
    }
}
