using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webshop.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Webshop.Controllers;

namespace Webshop
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ProductController _productController;
        private readonly CategoryController _categoryController;
        public Form1()
        {
            InitializeComponent();
            _productController = new ProductController();
            _categoryController = new CategoryController();
            _dbContext = new ApplicationDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = _categoryController.GetAllCategorys();

            var selectedCategory = ((Category)comboBoxCategory.SelectedItem).Id;

            comboBoxProducts.DataSource = _productController.GetAllProducts(selectedCategory);

            comboBoxProductCategory.DataSource = _categoryController.GetAllCategorys();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = ((Category)comboBoxCategory.SelectedItem).Id;

            comboBoxProducts.DataSource = _productController.GetAllProducts(selectedCategory);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<ValidationResult> result = _productController.Create(new Product
            {
                Name = textBoxName.Text,
                Brand = textBoxBrand.Text,
                Color = textBoxColor.Text,
                Price = Convert.ToDouble(textBoxPrice.Text),
                Size = textBoxSize.Text,
                Storage = Convert.ToInt32(textBoxStorage.Text),
                CategoryId = ((Category)comboBoxProductCategory.SelectedItem).Id
            });

            if (result.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result));
            }
        }

        private void comboBoxProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<ValidationResult> result = _productController.Update( new Product
            {
                Name = textBoxName.Text,
                Brand = textBoxBrand.Text,
                Color = textBoxColor.Text,
                Price = Convert.ToDouble(textBoxPrice.Text),
                Size = textBoxSize.Text,
                Storage = Convert.ToInt32(textBoxStorage.Text),
                CategoryId = ((Category)comboBoxProductCategory.SelectedItem).Id,
                ProductID = ((Product) comboBoxProducts.SelectedItem).ProductID
            });

            if (result.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result));
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = (Product)comboBoxProducts.SelectedItem;

            textBoxName.Text = product.Name;
            textBoxBrand.Text = product.Brand;
            textBoxColor.Text = product.Color;
            textBoxPrice.Text = product.Price.ToString();
            textBoxSize.Text = product.Size;
            textBoxStorage.Text = product.Storage.ToString();
            comboBoxProductCategory.SelectedItem = _categoryController.ReadCategory(product.CategoryId);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productController.Delete(((Product) comboBoxProducts.SelectedItem).ProductID);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchString = textBoxSearch.Text;

            var searchResult = _productController.SearchResults().Where(x=>x.Name.Contains(searchString)).ToList();

            listBox1.DataSource = searchResult;
            listBox1.DisplayMember = "Name" + " "+ "Brand";
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            foreach (var x in _productController.SalesPerMonth())
            {
                listView1.Items.Add(x);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = (Product) listBox1.SelectedItem;

            textBoxName.Text = product.Name;
            textBoxBrand.Text = product.Brand;
            textBoxColor.Text = product.Color;
            textBoxPrice.Text = product.Price.ToString();
            textBoxSize.Text = product.Size;
            textBoxStorage.Text = product.Storage.ToString();
            comboBoxProductCategory.SelectedItem = _categoryController.ReadCategory(product.CategoryId);
        }
    }
}
