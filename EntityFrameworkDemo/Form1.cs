using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            // PART1
            //using (ETradeContext context = new ETradeContext()) // BELLEK İÇİN PAHALI BİR NESNE
            //{
            //    dgwProducts.DataSource = context.Products.ToList(); // listeye çevirir
            //}
            // PART2
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            // Collectionlara filtreleme yapma (LINQ)
            //var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList(); 

            // Direk veri tabanından filitreleme yapma (LINQ)
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }
        
        private void SearchProductByIdTrial(int id)
        {
            var result = _productDal.GetAll().Where(p=>p.Id==id).ToList(); // FirstOrDefault Fonksiyonuna Göre Yapamadım
            dgwProducts.DataSource = result;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Added!");
        }

        private void DgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = Convert.ToString(dgwProducts.CurrentRow.Cells[1].Value);
            tbxUnitPriceUpdate.Text = Convert.ToString(dgwProducts.CurrentRow.Cells[2].Value);
            tbxStockAmountUpdate.Text = Convert.ToString(dgwProducts.CurrentRow.Cells[3].Value);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted!");
        }

        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void BtnGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(Convert.ToInt32(tbxGetById.Text));
        }

        private void TbxGetByIdTrial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchProductByIdTrial(Convert.ToInt32(tbxGetByIdTrial.Text));
            }
            catch (FormatException exception)
            {
                LoadProducts();
            }
        }
    }
}
