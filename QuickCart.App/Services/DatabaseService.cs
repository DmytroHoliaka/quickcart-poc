using QuickCart.App.Entities;
using QuickCart.App.Stores;

namespace QuickCart.App.Services
{
    public class DatabaseService
    {
        public DatabaseService(EventStore eventStore)
        {
            // Запис даних користувача в базу даних
            eventStore.AccountCreated += CreateUserHandler;
            
            // Запис даних товару в базу даних
            eventStore.ProductAdded += CreateProductHandler;
            
            // Запис оновлених даних товару в базу даних
            eventStore.ProductUpdated += UpdateProductHandler;
            
            // Видалення даних товару з бази даних
            eventStore.ProductDeleted += DeleteProductHandler;
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
