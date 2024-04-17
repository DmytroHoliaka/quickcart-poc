using QuickCart.App.Entities;

namespace QuickCart.App.Stores
{
    public class EventStore
    {
        /*
            Обробники:
            1. Відправка листа з підтвердженням на електронну пошту
            2. Запис даних користувача в базу даних
            3. Логування
               ...
        */
        public event Func<User, Task>? AccountCreated;

        /*
            Обробники:
            1. Оновлення статусу “Онлайн” користувача
            2. Відновлення сеансу користувача
            3. Відправка повідомлення про вхід в систему на електронну пошту користувача
            4. Логування
               ...
        */
        public event Func<User, Task>? UserAuthorized;

        /*
            Обробники:
            1. Запис даних товару в базу даних
            2. Індексація товару для пошуку
            3. Відправка повідомлення продавцю про успішне додавання товару
            4. Оновлення кешу товарів
               ...
        */
        public event Func<Product, User, Task>? ProductAdded;

        /*
            Обробники:
            1. Запис оновлених даних товару в базу даних
            2. Оновлення індексації товару для пошуку
            4. Відправка повідомлення продавцю про успішне оновлення даних товару
            5. Оновлення кешу товарів
               ...
        */
        public event Func<Product, User, Task>? ProductUpdated;

        /*
            Обробники:
            1. Видалення даних товару з бази даних
            3. Відправка повідомлення продавцю про успішне видалення товару
            4. Оновлення кешу товарів
               ...
        */
        public event Func<Product, User, Task>? ProductDeleted;

        /*
            Додаткові події:

            1. Додавання товару в кошик.
                Запис даних про товар в кошику користувача
                Відправка повідомлення користувачу про успішне додавання товару в кошик
                Оновлення кешу кошика користувача
                 ...

            2. Замовлення товару
                Запис даних замовлення в базу даних
                Відправка повідомлення користувачу про успішне замовлення товару
                Відправка повідомлення продавцю про нове замовлення
                Логування
                 ...

            3. Оплата замовлення
                Запис даних про оплату в базу даних
                Відправка повідомлення користувачу про успішну оплату замовлення
                Відправка повідомлення продавцю про оплату замовлення
                Логування
                 ...

            4. Відгук про товар або продавця
                Запис даних відгуку в базу даних
                Відправка повідомлення користувачу про успішне залишення відгуку
                Відправка повідомлення продавцю про новий відгук
                 ...

            5. Відправлення повідомлень
                Запис даних повідомлення в базу даних
                Відправка повідомлення користувачу про успішне відправлення повідомлення
                Відправка повідомлення отримувачу про нове повідомлення
                 ...
        */

        public async Task InvokeAccountCreated(User newUser)
        {
            if (AccountCreated != null)
            {
                IEnumerable<Task> tasks = AccountCreated.GetInvocationList()
                    .Select(handler => ((Func<User, Task>)handler).Invoke(newUser))
                    .ToList();

                await Task.WhenAll(tasks);
            }
        }

        public async Task InvokeUserAuthorized(User user)
        {
            if (UserAuthorized != null)
            {
                IEnumerable<Task> tasks = UserAuthorized.GetInvocationList()
                    .Select(handler => ((Func<User, Task>)handler).Invoke(user))
                    .ToList();

                await Task.WhenAll(tasks);
            }
        }

        public async Task InvokeProductAdded(Product newProduct, User seller)
        {
            if (ProductAdded != null)
            {
                IEnumerable<Task> tasks = ProductAdded.GetInvocationList()
                    .Select(handler => ((Func<Product, User, Task>)handler).Invoke(newProduct, seller))
                    .ToList();

                await Task.WhenAll(tasks);
            }
        }

        public async Task InvokeProductUpdated(Product targetProduct, User seller)
        {
            if (ProductUpdated != null)
            {
                IEnumerable<Task> tasks = ProductUpdated.GetInvocationList()
                    .Select(handler => ((Func<Product, User, Task>)handler).Invoke(targetProduct, seller))
                    .ToList();

                await Task.WhenAll(tasks);
            }
        }

        public async Task InvokeProductDeleted(Product deletingProduct, User seller)
        {
            if (ProductDeleted != null)
            {
                IEnumerable<Task> tasks = ProductDeleted.GetInvocationList()
                    .Select(handler => ((Func<Product, User, Task>)handler).Invoke(deletingProduct, seller))
                    .ToList();

                await Task.WhenAll(tasks);
            }
        }
    }
}
