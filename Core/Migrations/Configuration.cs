using Core.Context;
using Core.Domain;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Core.Migrations
{
    /// <summary>
    /// ������������ ��������.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<Core.Context.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// ���������� ���� ������.
        /// </summary>
        /// <param name="context">�������� ������ �������.</param>
        protected override void Seed(Core.Context.ProductContext context)
        {
            GroupProductContext groupProductContext = new GroupProductContext();

            List<GroupProduct> groupProducts = new List<GroupProduct>
            {
                new GroupProduct("���� � ������������"),
                new GroupProduct("���� � ������������"),
                new GroupProduct("����"),
                new GroupProduct("������ � �������� ��������"),
                new GroupProduct("������������� ��������"),
                new GroupProduct("����� � ������"),
                new GroupProduct("������������ �������"),
                new GroupProduct("������� ����")
            };

            List<Product> products = new List<Product>
            {
                new Product("��������",groupProducts[0]),
                new Product("�������",groupProducts[0]),
                new Product("������",groupProducts[0]),
                new Product("������",groupProducts[1]),
                new Product("�������",groupProducts[1]),
                new Product("������� ����",groupProducts[2]),
                new Product("����������� ����",groupProducts[2]),
                new Product("������",groupProducts[3]),
                new Product("������",groupProducts[3]),
                new Product("�������",groupProducts[3]),
                new Product("���",groupProducts[3]),
                new Product("�����",groupProducts[4]),
                new Product("���������",groupProducts[4]),
                new Product("�����",groupProducts[4]),
                new Product("���������",groupProducts[5]),
                new Product("�������",groupProducts[5]),
                new Product("�����",groupProducts[5]),
                new Product("�����",groupProducts[5]),
                new Product("������",groupProducts[5]),
                new Product("�����",groupProducts[5]),
                new Product("��������",groupProducts[5]),
                new Product("����",groupProducts[6]),
                new Product("�������",groupProducts[6]),
                new Product("�����",groupProducts[6]),
                new Product("��������� �����",groupProducts[7]),
                new Product("������",groupProducts[7]),
                new Product("��������� �����",groupProducts[7]),
                new Product("������������ �����",groupProducts[7])
            };

            foreach (Product profduct in products)
                context.Products.Add(profduct);

            context.SaveChanges();
        }
    }
}
