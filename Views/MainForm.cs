using OOP_FileWriting_Example.Manager;
using OOP_FileWriting_Example.Manager.Writers;
using OOP_FileWriting_Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FileWriting_Example {
    public partial class MainForm : Form {

        private List<Product> _products;
        private LoginForm _loginForm;

        public MainForm(LoginForm loginForm) {
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            _loginForm.Show();
            this.Dispose();
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            string filterStr = txtFilter.Text;
            decimal filter = Convert.ToDecimal(filterStr);

            var productManager = new ProductManager();

            _products = productManager.GetFilteredProductsByPrice(filter);

            foreach (var product in _products) {
                lbProducts.Items.Add(product);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e) {

            IWriter writer;
            if (rbTxt.Checked)
                writer = new TextWriter(_products);
            else
                writer = new JsonWriter(_products);

            var writingManager = new WritingManager();
            writingManager.WriteFile(writer);
        }
    }
}
