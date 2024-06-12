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
    public partial class frmBrowseProduct : Form
    {
        public frmBrowseProduct()
        {
            InitializeComponent();
        }


        private void LoadProducts()
        {
            string sql = "SELECT ProductName, ProductId FROM Product ORDER BY ProductName";

            DataTable dtProducts = DataAccess.GetData(sql);


            Invoke(() =>
            {
                cmbProducts.Bind("ProductName", "ProductId", dtProducts);
            });

        }

        private void frmBrowseProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            this.StartParentProgressBar("Browse Products Loading", "Browse Products Loaded");
        }

        private void cmbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sql = $@"
                    SELECT 
                        Orders.OrderDate, 
                        Orders.ShippedDate, 
                        Orders.ShipName,
                        Orders.ShipAddress,
                        Orders.ShipCity,
                        Orders.ShipCountry,
                        Orders.Freight
                        FROM Product_Ordered 
                        INNER JOIN Product 
                        ON Product_Ordered.ProductId = Product.ProductId 
                        INNER JOIN Orders 
                        ON Product_Ordered.OrderId = Orders.OrderId ";

                     sql += $@"WHERE Product.ProductId = '{cmbProducts.SelectedValue}'";

            DataTable dt = DataAccess.GetData(sql);

            if(cmbProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a Product");
            }
            else
            {
                if(dt.Rows.Count > 0)
                {
                    dgvProducts.Visible = true;
                    dgvProducts.DataSource = dt;

                    dgvProducts.ReadOnly = true;
                    dgvProducts.AutoResizeColumns();

                    dgvProducts.Columns["OrderDate"].HeaderText = "Order Date";
                    dgvProducts.Columns["ShippedDate"].HeaderText = "Shipped Date";
                    dgvProducts.Columns["ShipName"].HeaderText = "Ship Name";
                    dgvProducts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProducts.Columns["ShipAddress"].HeaderText = "Ship Address";
                    dgvProducts.Columns["ShipCity"].HeaderText = "Ship City";
                    dgvProducts.Columns["ShipCountry"].HeaderText = "Ship Country";
                    dgvProducts.Columns["Freight"].HeaderText = "Freight";

                }
                else
                {
                    dgvProducts.Visible = false;
                    dgvProducts.DataSource = null;

                    MessageBox.Show("There is no result that matches your search");
                }
            }
                                
        }

        
    }
}
