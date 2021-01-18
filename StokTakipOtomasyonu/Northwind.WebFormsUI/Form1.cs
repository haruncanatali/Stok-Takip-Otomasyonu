using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolves;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _service;
        private ICategoryService _service1;

        public Form1()
        {

            _service = InstanceFactory.GetInstance<IProductService>();
            _service1 = InstanceFactory.GetInstance<ICategoryService>();

            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            kategoriCbx.DataSource = _service1.GetAll();
            kategoriCbx.DisplayMember = "CategoryName";
            kategoriCbx.ValueMember = "CategoryId";

            ekleUrunCbx.DataSource = _service1.GetAll();
            ekleUrunCbx.DisplayMember = "CategoryName";
            ekleUrunCbx.ValueMember = "CategoryId";

            guncelleKategoriCbx.DataSource = _service1.GetAll();
            guncelleKategoriCbx.DisplayMember = "CategoryName";
            guncelleKategoriCbx.ValueMember = "CategoryId";
        }

        private void LoadProduct()
        {
            dataGridView1.DataSource = _service.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategories();
        }

        private void kategoriCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _service.GetProductByCategory(Convert.ToInt32(kategoriCbx.SelectedValue));
            }
            catch{}
        }

        private void urunAdiTxt_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(urunAdiTxt.Text))
            {
                dataGridView1.DataSource = _service.GetProductByProductName(urunAdiTxt.Text);
            }
            else
            {
                LoadProduct();
            }
        }





        private void Temizle(string text)
        {
            switch (text)
            {
                case "Ekle":
                    foreach (object item in gCEkle.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox txt = (TextBox)item;

                            txt.Text = "";
                        }
                    } 
                    break;
                case "Guncelle":
                    foreach (object item in gcGuncelle.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox txt = (TextBox)item;

                            txt.Text = "";
                        }
                    }

                    break;
            }
        }

        private void urunEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _service.AddProduct(new Product
                {
                    CategoryId = Convert.ToInt32(ekleUrunCbx.SelectedValue),
                    ProductName = ekleUrunAd.Text,
                    UnitPrice = Convert.ToDecimal(ekleUrunFiyat.Text),
                    QuantityPerUnit = ekleUrunBirim.Text,
                    UnitsInStock = Convert.ToInt16(ekleUrunStok.Text)
                });
                MessageBox.Show("Ürün Eklendi!");
                LoadProduct();
                Temizle("Ekle");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                    _service.UpdateProduct(new Product
                    {
                        ProductId = Convert.ToInt32(
                            dataGridView1.CurrentRow.Cells[0].Value.ToString()
                        ),
                        CategoryId = Convert.ToInt32(guncelleKategoriCbx.SelectedValue.ToString()),
                        ProductName = guncelleUrunAdi.Text,
                        UnitPrice = Convert.ToDecimal(guncelleFiyatTxt.Text),
                        QuantityPerUnit = guncelleBirimTxt.Text,
                        UnitsInStock = Convert.ToInt16(guncelleStokTxt.Text)
                    });
                MessageBox.Show("Ürün Güncellendi!");
                LoadProduct();
                Temizle("Guncelle");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewClick(object sender, DataGridViewCellEventArgs e)
        {
            guncelleUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guncelleFiyatTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            guncelleBirimTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            guncelleStokTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            guncelleKategoriCbx.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value;
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                _service.DeleteProduct(new Product
                {
                    ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())
                });
            MessageBox.Show("Ürün Silindi!");
            LoadProduct();
            Temizle("Guncelle");
        }
    }
}
