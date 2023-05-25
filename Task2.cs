namespace dispose_dz
{
    public class Shop : IDisposable
    {
        // Властивості
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        // Конструктор
        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        // Метод Dispose для звільнення ресурсів
        public void Dispose()
        {
            Name = null;
            Address = null;
            Console.WriteLine("Магазин звільнено");
        }
        ~Shop()
        {
            Dispose();
        }

        public void Show()
        {
            Console.WriteLine("Назва магазину: " + Name);
            Console.WriteLine("Адреса магазину: " + Address);
            Console.WriteLine("Тип магазину: " + Type);
        }
    }

    // Перерахування для типу магазину
    public enum ShopType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    internal class Task2
    {
        public static void task2()
        {



            using (var shop = new Shop("Мій магазин", "вул. Примерна, 123", ShopType.Grocery))
            {
                shop.Show();
            }
        } // Тут метод Dispose() буде автоматично викликаний, звільняючи ресурси
    }

}

