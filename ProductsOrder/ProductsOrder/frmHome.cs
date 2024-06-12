using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsOrder
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();

            products.ShowDialog();
        }

        private void btnProductsOrder_Click(object sender, EventArgs e)
        {
            frmProductOrder productOrder = new frmProductOrder();
            productOrder.ShowDialog();
        }

        private void btnBrowseOrders_Click(object sender, EventArgs e)
        {
            frmBrowseOrders browseOrders = new frmBrowseOrders();

            browseOrders.ShowDialog();
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            frmBrowseProduct browseProduct = new frmBrowseProduct();

            browseProduct.ShowDialog();
        }

       
    }
}
