using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class CategoryController
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Category> GetAllCategorys()
        {
            var catagorysorder = _dbContext.Categories.OrderBy(x => x.Id).ToList();
            return catagorysorder;
        }
        public Category ReadCategory(int id)
        {
            return _dbContext.Categories.Find(id);
        }

    }
}

