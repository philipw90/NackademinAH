using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webshop.Models;

namespace Webshop
{
    public class ProductController
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly string _connectionString;

        public ProductController()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ApplicationDbContext"].ConnectionString;
            _dbContext = new ApplicationDbContext();
        }

        public List<ValidationResult> Create(Product product)
        {
            ValidationContext contex = new ValidationContext(product, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(product, contex, result, true);
            if (valid)
            {
                _dbContext.Products.AddOrUpdate();
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
            }
            return result;

        }

        public List<Product> GetAllProducts(int category)
        {
            var productListQuery = _dbContext.Products.Where(x => x.Category.Id == category).ToList();

            return productListQuery;
        }

        public List<ValidationResult> Update(Product product)
        {
            ValidationContext contex = new ValidationContext(product, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(product, contex, result, true);
            if (valid)
            {
                var k = _dbContext.Products.Find(product.ProductID);
                k.Name = product.Name;
                k.Brand = product.Brand;
                k.Color = product.Color;
                k.Price = product.Price;
                k.Storage = product.Storage;
                k.Category = product.Category;

                _dbContext.SaveChanges();
            }
            return result;

        }

        public void Delete(int id)
        {
            var k = _dbContext.Products.Single(x => x.ProductID == id);
            _dbContext.Products.Remove(k);
            _dbContext.SaveChanges();
        }

        public List<Product> SearchResults()
        {
            var searchResult = _dbContext.Products.OrderBy(x => x.Name).ToList();
            return searchResult;
        }

        public List<string> SalesPerMonth()
        {

            var rapport =
                _dbContext.ProductOrders.GroupBy(x => x.Order.Date.Month)
                    .Select(
                        y =>
                            new
                            {
                                Month = y.FirstOrDefault().Order.Date.Month,
                                TotalPrice = y.Sum(z => z.Product.Price*z.Quantity)
                            })
                    .ToList();

            List<string> salesList = new List<string>();

            var ordersPerMonth = from r in _dbContext.ProductOrders
                                 group r by r.Order.Date.Month
                into g
                                 select new { Month = g.Key, Sum = g.Sum(p => p.Product.Price) };

            foreach (var sale in ordersPerMonth)
            {
                salesList.Add(sale.ToString());
            }

            return salesList;

           
        }


    }
}
