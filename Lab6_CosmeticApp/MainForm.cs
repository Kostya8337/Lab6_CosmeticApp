using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Lab6_CosmeticApp.Data;
using Lab6_CosmeticApp.Models;

namespace Lab6_CosmeticApp
{
    public partial class MainForm : Form
    {
        private BindingList<CosmeticProduct> products;
        private AppDbContext db;

        public MainForm()
        {
            InitializeComponent();

            db = new AppDbContext();
            bool v = db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            products = new BindingList<CosmeticProduct>(db.CosmeticProducts.ToList());

            listBox1.DataSource = products;
            listBox1.DisplayMember = "Name";

            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "Brand";

            dataGridView1.DataSource = products;

            listView1.View = View.Details;
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Brand");
            listView1.Columns.Add("Type");
            listView1.Columns.Add("ExpiryDate");

            RefreshListView();
        }

        private void RefreshListView()
        {
            listView1.Items.Clear();
            foreach (var p in products)
            {
                listView1.Items.Add(new ListViewItem(new[]
                {
                    p.Name,
                    p.Brand,
                    p.Type,
                    p.ExpiryDate.ToShortDateString()
                }));
            }
        }
    }
}