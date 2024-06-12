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

namespace ProductsOrder
{
    public partial class frmProductOrder : Form
    {
        #region Private fields

        int currentOrderId;
        int currentProductId;
        int currentQuantity;
        decimal currentPrice;
        int currentDiscount;

        int firstOrderId;
        int firstProductId;
        int firstQuantity;
        decimal firstPrice;
        int firstDiscount;

        int lastOrderId;
        int lastProductId;
        int lastQuantity;
        decimal lastPrice;
        int lastDiscount;


        int? previousOrderId;
        int? previousProductId;
        int? previousQuantity;
        decimal? previouspPrice;
        int? previousDiscount;

        int? nextOrderId;
        int? nextProductId;
        int? nextQuantity;
        decimal? NextUnitPrice;
        int? nextDiscount;

        private FormState currentState;



        #endregion

        public frmProductOrder()
        {
            InitializeComponent();
        }
        // Step 1
        #region Load data
        private void LoadProducts()
        {
            string sqlProducts = " SELECT ProductId, ProductName FROM Product ORDER BY ProductName";

            cmbProduct.Bind("ProductName", "ProductId", DataAccess.GetData(sqlProducts));

        }


        private void LoadOrders()
        {
            string sqlOrder = " SELECT OrderId, ShipName FROM Orders ORDER BY ShipName";

            cmbOrder.Bind("ShipName", "OrderId", DataAccess.GetData(sqlOrder));

        }


        //private void LoadUnitPrice()
        //{
        //    string sqlprice = $"SELECT UnitPrice, OrderId FROM Product_Ordered WHERE OrderId = {cmbOrder.SelectedValue} AND ProductId = {cmbProduct.SelectedValue}";

        //    cmbUnitPrice.Bind("UnitPrice", "OrderId", DataAccess.GetData(sqlprice));
        //}

        private void LoadFirstProductOrder()
        {
            DataTable firstPdtOrd = DataAccess.GetData("SELECT TOP (1) OrderId, ProductId, Quantity, UnitPrice, Discount FROM Product_Ordered ORDER BY OrderId, ProductId");

            if (firstPdtOrd.Rows.Count > 0)
            {
                DataRow firstRow = firstPdtOrd.Rows[0];

                currentOrderId = Convert.ToInt32(firstRow["OrderId"]);
                currentProductId = Convert.ToInt32(firstRow["ProductId"]);
                currentPrice = Convert.ToInt32(firstRow["UnitPrice"]);
                currentQuantity = Convert.ToInt32(firstRow["Quantity"]);
                currentDiscount = Convert.ToInt32(firstRow["Discount"]);


                //LoadcurrentPosition
                LoadCurrentPostion();
                //DisplaycurrentPosition
                DisplayCurrentProductOrder();


            }
        }



        private void LoadCurrentPostion()
        {
            DataTable dt = GetPdtOrdDataTable();
            LoadCurPosition(dt.Rows[0]);
            EnableNavigation(currentState == FormState.View);
            //
        }



        private void LoadCurPosition(DataRow dataRow)
        {
            firstOrderId = Convert.ToInt32(dataRow["FirstOrderID"]);
            firstProductId = Convert.ToInt32(dataRow["FirstProductID"]);
            firstQuantity = Convert.ToInt32(dataRow["FirstQuantity"]);
            firstPrice = Convert.ToDecimal(dataRow["FirstUnitPrice"]);
            firstDiscount = Convert.ToInt32(dataRow["FirstDiscount"]);

            previousOrderId = DataUIUT.GetInteger(dataRow, "previousOrderId");
            previousProductId = DataUIUT.GetInteger(dataRow, "previousProductId");
            previousQuantity = DataUIUT.GetInteger(dataRow, "previousQuantity");

           // previouspPrice = DataUIUT.GetInteger(dataRow, "previouspPrice");

            previouspPrice = dataRow["previouspPrice"] != DBNull.Value ?
                Convert.ToDecimal(dataRow["previouspPrice"]) : null;

            previousDiscount = DataUIUT.GetInteger(dataRow, "previousDiscount");

            lastOrderId = Convert.ToInt32(dataRow["LastOrderID"]);
            lastProductId = Convert.ToInt32(dataRow["LastProductID"]);
            lastQuantity = Convert.ToInt32(dataRow["LastQuantity"]);
            lastPrice = Convert.ToDecimal(dataRow["LastUnitPrice"]);
            lastDiscount = Convert.ToInt32(dataRow["LastDiscount"]);




            nextOrderId = DataUIUT.GetInteger(dataRow, "nextOrderId");
            nextProductId = DataUIUT.GetInteger(dataRow, "NextProductId");
            nextQuantity = DataUIUT.GetInteger(dataRow, "NextQuantity");


           // NextUnitPrice = DataUIUT.GetInteger(dataRow, "NextUnitPrice");

            NextUnitPrice = dataRow["NextUnitPrice"] != DBNull.Value ?
             Convert.ToDecimal(dataRow["NextUnitPrice"]) : null;


            nextDiscount = DataUIUT.GetInteger(dataRow, "NextDiscount");

        }



        #endregion

        // Step 2
        #region Get Data
        private DataTable GetPdtOrdDataTable()
        {
            string sql = $@"
                SELECT
	                q.nextOrderId,
	                q.nextProductId,
	                q.nextQuantity,
	                q.NextUnitPrice,
	                q.nextDiscount,

	                q.previousOrderId,
	                q.previousProductId,
	                q.previousQuantity,
	                q.previouspPrice,
	                q.previousDiscount,
	                q.RowNumber,
                (SELECT TOP(1) OrderId FROM Product_Ordered ORDER BY OrderId) AS FirstOrderID,
                (SELECT TOP(1) ProductId FROM Product_Ordered ORDER BY OrderId) AS FirstProductID,
                (SELECT TOP(1) Quantity FROM Product_Ordered ORDER BY OrderId) AS FirstQuantity,
                (SELECT TOP(1) UnitPrice FROM Product_Ordered ORDER BY OrderId) AS FirstUnitPrice,
                (SELECT TOP(1) Discount FROM Product_Ordered ORDER BY OrderId) AS FirstDiscount,

                (SELECT TOP(1) OrderId FROM Product_Ordered ORDER BY OrderId DESC) AS LastOrderID,
                (SELECT TOP(1) ProductId FROM Product_Ordered ORDER BY OrderId DESC) AS LastProductID,
                (SELECT TOP(1) Quantity FROM Product_Ordered ORDER BY OrderId DESC) AS LastQuantity,
                (SELECT TOP(1) UnitPrice FROM Product_Ordered ORDER BY OrderId DESC) AS LastUnitPrice,
                (SELECT TOP(1) Discount FROM Product_Ordered ORDER BY OrderId DESC) AS LastDiscount
                FROM
                (
                SELECT OrderId, ProductId, Quantity,UnitPrice,Discount,
                LEAD(OrderId) OVER(ORDER BY OrderId) AS nextOrderId,
                LEAD(ProductId) OVER(ORDER BY OrderId) AS NextProductId,
                LEAD(Quantity) OVER(ORDER BY OrderId) AS NextQuantity,
                LEAD(UnitPrice) OVER(ORDER BY OrderId) AS NextUnitPrice,
                LEAD(Discount) OVER(ORDER BY OrderId) AS NextDiscount,

                LAG(OrderId) OVER(ORDER BY OrderId) AS previousOrderId,
                LAG(ProductId) OVER(ORDER BY OrderId) AS previousProductId,
                LAG(Quantity) OVER(ORDER BY OrderId) AS previousQuantity,
                LAG(UnitPrice) OVER(ORDER BY OrderId) AS previouspPrice,
                LAG(Discount) OVER(ORDER BY OrderId) AS previousDiscount,
                ROW_NUMBER() OVER(ORDER BY OrderId) AS RowNumber
                FROM Product_Ordered) AS q
                WHERE 
                q.OrderId = {currentOrderId} 
                and q.ProductId = {currentProductId}
                and q.Quantity = {currentQuantity}
                and q.UnitPrice = {currentPrice}
                and q.Discount = {currentDiscount}
            ";

            return DataAccess.GetData(sql);
        }

        private DataTable GetProductOrderDataTable()
        {
            string sql = $"SELECT * FROM Product_Ordered WHERE OrderId = {currentOrderId} AND ProductId = {currentProductId} AND Quantity = {currentQuantity} AND UnitPrice = {currentPrice} AND Discount = {currentDiscount}";

            DataTable dt = DataAccess.GetData(sql);
            return dt;
        }



        #endregion


        // Step 3
        #region DIsplay Data

        private void DisplayCurrentProductOrder()
        {
            DataTable dtprodtOrd = GetProductOrderDataTable();

            if (dtprodtOrd.Rows.Count == 1)
            {
                DisplayCurPosition(dtprodtOrd.Rows[0]);
                DisplayPrice();
            }

           


        }

        private void DisplayCurPosition(DataRow dataRow)
        {
            cmbOrder.SelectedValue = Convert.ToInt32(dataRow["OrderId"]);
            cmbProduct.SelectedValue = Convert.ToInt32(dataRow["ProductId"]);

            txtDst.Text = Convert.ToInt32(dataRow["Discount"]).ToString();
            txtQty.Text = Convert.ToInt32(dataRow["Quantity"]).ToString();
            labUnitP.Text = Convert.ToInt32(dataRow["UnitPrice"]).ToString();


            this.DisplayParentStatusStripmessage("Product Order Loaded");



        }


        #endregion


        // Step 4
        #region NavigationHandler

        private void NavigationHandler(object sender, EventArgs e)
        {
            if (sender == btnFirst)
            {
                currentOrderId = firstOrderId;
                currentProductId = firstProductId;
                currentQuantity = firstQuantity;
                currentPrice = firstPrice;
                currentDiscount = firstDiscount;

            }
            else if (sender == btnNext)
            {
                currentOrderId = nextOrderId.Value;
                currentProductId = nextProductId.Value;
                currentQuantity = nextQuantity.Value;
                currentPrice = NextUnitPrice.Value;
                currentDiscount = nextDiscount.Value;

            }
            else if (sender == btnPrevious)
            {
                currentOrderId = previousOrderId.Value;
                currentProductId = previousProductId.Value;
                currentQuantity = previousQuantity.Value;
                currentPrice = previouspPrice.Value;
                currentDiscount = previousDiscount.Value;

            }
            else if (sender == btnLast)
            {
                currentOrderId = lastOrderId;
                currentProductId = lastProductId;
                currentQuantity = lastQuantity;
                currentPrice = lastPrice;
                currentDiscount = lastDiscount;
            }
            else
            {
                return;
            }

            LoadCurrentPostion();
            DisplayCurrentProductOrder();
        }

        private void EnableNavigation(bool enable)
        {
            if (enable)
            {
                btnPrevious.Enabled = previousProductId != null
                    && previousOrderId != null
                    && previousQuantity != null
                    && previouspPrice != null
                    && previousDiscount != null;

                btnNext.Enabled = nextProductId != null
                    && nextOrderId != null
                    && nextQuantity != null
                      && NextUnitPrice != null
                    && nextDiscount != null;
            }
            else
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
            }

            btnFirst.Enabled = enable;
            btnLast.Enabled = enable;
        }

        #endregion

        // step 5
        #region Load State

        private void SetState(FormState state)
        {
            currentState = state;
            LoadState(state);
        }

        private void LoadState(FormState state)
        {
            if (state == FormState.View)
            {
                btnAdd.Enabled = true;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
                btnSave.Text = "Edit";
                AllowInputs(false);
                errorProvider1.Clear();
            }
            else
            {
                btnAdd.Enabled = false;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnSave.Text = "Save";
                AllowInputs(true);
                if (state == FormState.Add)
                {
                    grpProductOrdered.clearChildControls(defaultSelectedIndex: -1);
                    lbl1Total.Text = "";
                    lblDiscount.Text = "";
                   // labUnitP.Text = string.Empty;
                    // UIUtilities.clearChildControls(grpAssignments, -1);
                }
            }

            EnableNavigation(currentState == FormState.View);
        }

        private void AllowInputs(bool allowInputs)
        {
            txtDst.ReadOnly = !allowInputs;
            txtQty.ReadOnly = !allowInputs;


            cmbOrder.Enabled = allowInputs;
            cmbProduct.Enabled = allowInputs;

        }


        #endregion

        #region CRUD
        private void CreateProductOrdered()
        {
            int orderId = Convert.ToInt32(cmbOrder.SelectedValue);
            int productId = Convert.ToInt32(cmbProduct.SelectedValue);

            int qty = Convert.ToInt32(txtQty.Text);
            decimal UnitPrice = Convert.ToDecimal(labUnitP.Text);
            int discount = Convert.ToInt32(txtDst.Text);

            string sql = $@"INSERT INTO Product_Ordered
                            (OrderId, ProductId, Quantity, UnitPrice, Discount)
                            VALUES
                            ({orderId}, {productId}, {qty}, {UnitPrice}, {discount});";

            int rowsAffected = DataAccess.SendData(sql);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Product Ordered was created Succesfully");
            }
            else
            {
                MessageBox.Show("Failed to Save Product Ordered");
            }

        }

        private void DeleteProductOrdered()
        {
            string sqlDelete = $@"DELETE FROM Product_Ordered 
                                    WHERE OrderId = {currentOrderId} 
                                    AND ProductId = {currentProductId}";

            int rowsAffected = DataAccess.SendData(sqlDelete);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Assignment was deleted");
            }
            else
            {
                MessageBox.Show("The database reports no rows affected, verity you inputs");
            }



        }

        private void UpdateProductOrdered()
        {
            int orderId = Convert.ToInt32(cmbOrder.SelectedValue);
            int productId = Convert.ToInt32(cmbProduct.SelectedValue);

            int qty = Convert.ToInt32(txtQty.Text);
            decimal UnitPrice = Convert.ToDecimal(labUnitP.Text);
            int discount = Convert.ToInt32(txtDst.Text);

            string sqlUpdate = $@"
                  UPDATE Product_Ordered
                        SET OrderId = {orderId},
                        ProductId = {productId},
                        Quantity = {qty},
                        UnitPrice = {UnitPrice},
	                    Discount = {discount}
                        WHERE OrderId = {currentOrderId} 
	                    AND ProductId = {cmbProduct}";

            int rowsAffected = DataAccess.SendData(sqlUpdate);

            if (rowsAffected == 0)
            {
                MessageBox.Show("The DataBase reported no Rows Affected, meaning the changes were not saved");
            }
            else if (rowsAffected == 1)
            {
                MessageBox.Show("Product Ordered was successfully Updated");
            }
            else
            {
                MessageBox.Show("Something went wrong, Please verify your data");
            }


        }


        #endregion

        #region CRUD Button


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LoadOrders();
                LoadProducts();
                SetState(FormState.Add);
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this Assignent", "Are you sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteProductOrdered();
                    LoadFirstProductOrder();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentState == FormState.View)
                {
                    SetState(FormState.Edit);
                }
                else
                {

                    if (this.ValidateChildren())
                    {
                        if (currentState == FormState.Add)
                        {
                            CreateProductOrdered();
                            DisplayCurrentProductOrder();
                            
                            DisplayPrice();
                        }
                        else
                        {
                            UpdateProductOrdered();
                            LoadFirstProductOrder();
                            DisplayPrice();
                        }
                        SetState(FormState.View);
                    }
                    else
                    {
                        MessageBox.Show("Please resolve your validation");
                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                SetState(FormState.View);
                DisplayCurrentProductOrder();
                DisplayPrice();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        #endregion





        private void frmProductOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadProducts();

            LoadFirstProductOrder();
            DisplayPrice();

            this.StartParentProgressBar("Product Order Loading...", "Product Order Loaded");
            SetState(FormState.View);
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox? txt = sender as TextBox;

            if (txt == null)
                return;

            string? errmsg = string.Empty;

            if (txt.Text == string.Empty)
            {
                errmsg = $"{txt.Tag} is Required";
                e.Cancel = true;
            }

            if (txt == txtQty || txt == txtDst)
            {
                if (!Validators.IsNumeric(txt.Text))
                {
                    errmsg = $"{txt.Tag} is not numeric";
                    e.Cancel = true;
                }

            }

            errorProvider1.SetError(txt, errmsg);
        }

        private void cmb_Validtion(object sender, CancelEventArgs e)
        {
            ComboBox? cmb = sender as ComboBox;
            if (cmb == null) return;

            string errorMessage = string.Empty;

            if (cmb.SelectedIndex == -1)
            {
                errorMessage = $"{cmb.Tag} is required";
                e.Cancel = true;
            }

            errorProvider1.SetError(cmb, errorMessage);
        }

        private void DisplayPrice()
        {
            string sql = $@"SELECT Product.PricePerUnit FROM Product_Ordered " +
                $"INNER JOIN Product ON Product_Ordered.ProductId = Product.ProductId " +
                $"INNER JOIN Orders ON Product_Ordered.OrderId = Orders.OrderId ";

            sql += $"WHERE Orders.OrderId = {cmbOrder.SelectedValue} AND Product.ProductId = {cmbProduct.SelectedValue}";

            object price = DataAccess.GetValue(sql);

            labUnitP.Text = Convert.ToString($"{price}").Trim();

            decimal qty = Convert.ToInt32(txtQty.Text);

            decimal UnitPrice = Convert.ToDecimal(labUnitP.Text);

            decimal discount = Convert.ToInt32(txtDst.Text);


            decimal total = (UnitPrice * qty);

            lbl1Total.Text = Convert.ToString($"{total:c}");




            if (total >= 200)
            {
                decimal DiscountAmt = discount / 100;

                DiscountAmt *= total;

                DiscountAmt = total - DiscountAmt;

                lblDiscount.Text = Convert.ToString($"{DiscountAmt:c}");
            }
            else
            {
                lblDiscount.Text = "";
            }
            

           










        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
