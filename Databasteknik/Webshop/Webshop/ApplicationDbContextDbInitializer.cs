using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Windows.Forms.VisualStyles;
using Webshop.Models;

namespace Webshop
{
    internal class ApplicationDbContextDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(x => x.Id,
                new Category { Name = "Shoes" },
                new Category { Name = "Pants" },
                new Category { Name = "Shirts" },
                new Category { Name = "T-Shirts" }
                );
            context.SaveChanges();
            context.Products.AddOrUpdate(x => x.ProductID,
                new Product
                {
                    Name = "Free Run",
                    Brand = "Nike",
                    CategoryId = 1,
                    Color = "Black",
                    Price = 699,
                    Size = "43",
                    Storage = 10
                },
                new Product
                {
                    Name = "Slow Run",
                    Brand = "Nike",
                    CategoryId = 1,
                    Color = "Yellow",
                    Price = 699,
                    Size = "44",
                    Storage = 10
                },
                new Product
                {
                    Name = "Boots",
                    Brand = "Loake",
                    CategoryId = 1,
                    Color = "Brown",
                    Price = 699,
                    Size = "44",
                    Storage = 10
                },
                new Product
                {
                    Name = "Acne white T-Shirt",
                    Brand = "Acne",
                    CategoryId = 4,
                    Color = "White",
                    Price = 599,
                    Size = "M",
                    Storage = 10
                },
                new Product
                {
                    Name = "Pants by H&M",
                    Brand = "H&M",
                    CategoryId = 2,
                    Color = "Black",
                    Price = 599,
                    Size = "M",
                    Storage = 10
                });
            context.SaveChanges();
            context.Customers.AddOrUpdate(x => x.CustomerID,
                new Customer
                {
                    FirstName = "Andre",
                    LastName = "Holmlund",
                    Email = "Andre.holmlund@gmail.com",
                    PhoneNumber = "=0744430888",
                    City = "Stockholm",
                    Street = "Falköpingsvägen",
                    ZipCode = "12139"
                },
                new Customer
                {
                    FirstName = "Katja",
                    LastName = "Åström",
                    Email = "kumaja@gmail.com",
                    PhoneNumber = "=0744430888",
                    City = "Stockholm",
                    Street = "Falköpingsvägen",
                    ZipCode = "12139"
                },
                new Customer
                {
                    FirstName = "Erik",
                    LastName = "Jonsson",
                    Email = "Erik.jonsson@gmail.com",
                    PhoneNumber = "=0744422888",
                    City = "Stockholm",
                    Street = "Eriksväg",
                    ZipCode = "12173"
                },
                new Customer
                {
                    FirstName = "Göran",
                    LastName = "Göransson",
                    Email = "Göran.göransson@gmail.com",
                    PhoneNumber = "=0744430118",
                    City = "Stockholm",
                    Street = "Göransväg",
                    ZipCode = "12177"
                });
            context.SaveChanges();
            context.Orders.AddOrUpdate(x => x.Id,
                new Order
                {
                    Date = new DateTime(2015, 09, 23, 12, 01, 00),
                    CustomerId = 2
                },
                new Order
                {
                    Date = new DateTime(2016, 10, 22, 12, 01, 00),
                    CustomerId = 1
                },
                new Order
                {
                    Date = new DateTime(2016, 10, 24, 12, 01, 00),
                    CustomerId = 3
                },
                new Order
                {
                    Date = new DateTime(2016, 11, 11, 12, 01, 00),
                    CustomerId = 4
                });
            context.SaveChanges();
            context.ProductOrders.AddOrUpdate(x => new { x.ProductId, x.OrderId },
                new ProductOrder
                {
                    ProductId = 1,
                    OrderId = 1,
                    Quantity = 1
                },
                new ProductOrder
                {
                    ProductId = 2,
                    OrderId = 2,
                    Quantity = 2
                },
                new ProductOrder
                {
                    ProductId = 3,
                    OrderId = 3,
                    Quantity = 4
                });
            context.SaveChanges();
            base.Seed(context);

        }
    }
}