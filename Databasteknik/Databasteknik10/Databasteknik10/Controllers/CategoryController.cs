using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databasteknik10.Models;

namespace Databasteknik10.Controllers
{
    public class CategoryController
    {
        private readonly LibraryDbContext _dbContext;
        public CategoryController()
        {
            _dbContext = new LibraryDbContext();
        }

        public List<ValidationResult> Create(Category category)
        {
            ValidationContext contex = new ValidationContext(category, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(category, contex, result, true);
            if (valid)
            {
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
            }
            return result;
        }
        public void Update() { }
        public void Delete() { }
        public void Read() { }


    }
}
