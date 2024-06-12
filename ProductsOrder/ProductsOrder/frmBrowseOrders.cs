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
    public partial class frmBrowseOrders : Form
    {
        public frmBrowseOrders()
        {
            InitializeComponent();
        }

        private void LoadOrder()
        {
            string sql = "SELECT ShipName, OrderId FROM Orders ORDER BY ShipName";

            DataTable dtOrders = DataAccess.GetData(sql);

            dtOrders.AddEmptyRow("ShipName", "OrderId", "-- Please Select an Order --");

            Invoke(() =>
            {
                cmbOrders.Bind("ShipName", "OrderId", dtOrders);
            });
        }

        private void frmBrowseOrders_Load(object sender, EventArgs e)
        {
            LoadOrder();
            this.StartParentProgressBar(" Browse Orders Loading", "Browser Orders Loaded");
        }

        private void cmbOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sql = $@"
                        SELECT 
                            Product.ProductName, 
                            Product.PricePerUnit, 
                            Product.Quantity,
                            Product.ReOrderLevel,
                            Product.Stock,
                            Product.UnitOrder
                            FROM Product_Ordered 
                            INNER JOIN Product 
                            ON Product_Ordered.ProductId = Product.ProductId 
                            INNER JOIN Orders 
                            ON Product_Ordered.OrderId = Orders.OrderId ";

            sql += $@"WHERE Orders.OrderId = '{cmbOrders.SelectedValue}'";

            DataTable dt = DataAccess.GetData(sql);

            if(cmbOrders.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an Order");
            }
            else
            {
                if(dt.Rows.Count > 0)
                {
                    dgvOrders.Visible = true;
                    dgvOrders.DataSource = dt;

                    dgvOrders.ReadOnly = true;
                    dgvOrders.AutoResizeColumns();

                    dgvOrders.Columns["ProductName"].HeaderText = "Product Name";
                    dgvOrders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvOrders.Columns["PricePerUnit"].HeaderText = "PricePerUnit";
                    dgvOrders.Columns["Quantity"].HeaderText = "Quantity";
                    dgvOrders.Columns["ReOrderLevel"].HeaderText = "ReOrder-Level";
                    dgvOrders.Columns["Stock"].HeaderText = "Stock";
                    dgvOrders.Columns["UnitOrder"].HeaderText = "UnitOrder";

                }
                else
                {
                    dgvOrders.Visible = false;
                    dgvOrders.DataSource = null;

                    MessageBox.Show("There is no result that matches your search");
                }
            }
                         
        }
    }
}
