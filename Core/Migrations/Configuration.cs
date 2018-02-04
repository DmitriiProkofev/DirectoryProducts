using Core.Context;
using Core.Domain;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Core.Migrations
{
    /// <summary>
    /// Конфигурации миграций.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<Core.Context.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Заполнение базы данных.
        /// </summary>
        /// <param name="context">Контекст данных товаров.</param>
        protected override void Seed(Core.Context.ProductContext context)
        {
            GroupProductContext groupProductContext = new GroupProductContext();

            List<GroupProduct> groupProducts = new List<GroupProduct>
            {
                new GroupProduct("Мясо и мясопродукты"),
                new GroupProduct("Рыба и рыбопродукты"),
                new GroupProduct("Яйца"),
                new GroupProduct("Молоко и молочные продукты"),
                new GroupProduct("Хлебобулочные продукты"),
                new GroupProduct("Овощи и фрукты"),
                new GroupProduct("Кондитерские изделия"),
                new GroupProduct("Пищевые жиры")
            };

            List<Product> products = new List<Product>
            {
                new Product("Говядина",groupProducts[0]),
                new Product("Свинина",groupProducts[0]),
                new Product("Курица",groupProducts[0]),
                new Product("Лосось",groupProducts[1]),
                new Product("Тилапия",groupProducts[1]),
                new Product("Куриные яйца",groupProducts[2]),
                new Product("Перепелиные яйца",groupProducts[2]),
                new Product("Молоко",groupProducts[3]),
                new Product("Творог",groupProducts[3]),
                new Product("Сметана",groupProducts[3]),
                new Product("Сыр",groupProducts[3]),
                new Product("Батон",groupProducts[4]),
                new Product("Городской",groupProducts[4]),
                new Product("Багет",groupProducts[4]),
                new Product("Картофель",groupProducts[5]),
                new Product("Морковь",groupProducts[5]),
                new Product("Груша",groupProducts[5]),
                new Product("Тыква",groupProducts[5]),
                new Product("Яблоко",groupProducts[5]),
                new Product("Банан",groupProducts[5]),
                new Product("Виноград",groupProducts[5]),
                new Product("Торт",groupProducts[6]),
                new Product("Печенье",groupProducts[6]),
                new Product("Пирог",groupProducts[6]),
                new Product("Сливочное масло",groupProducts[7]),
                new Product("Сливки",groupProducts[7]),
                new Product("Оливковое масло",groupProducts[7]),
                new Product("Растительное масло",groupProducts[7])
            };

            foreach (Product profduct in products)
                context.Products.Add(profduct);

            context.SaveChanges();
        }
    }
}
