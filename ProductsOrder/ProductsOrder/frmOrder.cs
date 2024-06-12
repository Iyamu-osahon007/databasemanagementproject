using System.Data;
using System.Data.SqlClient;
using System.Drawing.Design;

namespace ProductsOrder
{
    public partial class frmOrder : Form
    {

        #region Private Fields
        private int currentId;
        private int firstId;
        private int lastId;
        private int? nextId;
        private int? previousId;
        private int rowNumber;

        private FormState currentState;
        #endregion
        public frmOrder()
        {
            InitializeComponent();
        }
        // Step 1
        #region Get Data Row

        private int GetFirstOrderId()
        {
            int id = Convert.ToInt32(DataAccess.GetValue("SELECT TOP(1) OrderId FROM Orders ORDER BY ShipName"));

            return id;
        }

        private DataRow GetOrderDataRow(int id)
        {
            string sqlOrderId = $"SELECT OrderId, OrderDate, RequiredDate, ShippedDate, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, Freight FROM Orders WHERE OrderId = {id}";
            DataTable dt = DataAccess.GetData(sqlOrderId);

            return dt.Rows[0];
        }

        //This is for Navigation

        private DataRow GetPositionDataRow(int Id)
        {
            string sqlNavigate = $@"
SELECT 
(SELECT COUNT(1) FROM Orders) AS OrderCount,
 OrderId,
 (
	SELECT TOP(1) OrderId as FirstOrderId  FROM Orders ORDER BY ShipName

 ) as FirstOrderId,
 q.PreviousOrderId,
 q.NextOrderId,
 (
	SELECT TOP(1) OrderId as LastOrderId FROM Orders ORDER BY ShipName Desc

 ) as LastOrderId,
 q.RowNumber
 FROM
 (
	SELECT OrderId, ShipName,
	LEAD(OrderId) OVER(ORDER BY ShipName) AS NextOrderId,
	LAG(OrderId) OVER(ORDER BY ShipName) AS PreviousOrderId,
	ROW_NUMBER() OVER(ORDER BY ShipName) AS 'RowNumber'
	FROM Orders
 ) AS q
 WHERE q.OrderId = {Id}
 ORDER BY q.ShipName";


            DataTable dt = DataAccess.GetData(sqlNavigate);

            return dt.Rows[0];
        }
        #endregion

        // Step 2
        #region Display DataRow

        private void DisplayOrders(DataRow selectedOrder)
        {
            txtOrderId.Text = selectedOrder["OrderId"].ToString();
            txtOrderDate.Text = Convert.ToDateTime(selectedOrder["OrderDate"]).ToShortDateString().ToString();
            txtRequiredDate.Text = Convert.ToDateTime(selectedOrder["RequiredDate"]).ToShortDateString().ToString();
            txtShipDate.Text = Convert.ToDateTime(selectedOrder["ShippedDate"]).ToShortDateString().ToString();
            txtshipmentName.Text = selectedOrder["ShipName"].ToString();
            txtShipAddress.Text = selectedOrder["ShipAddress"].ToString();
            txtShipCity.Text = selectedOrder["ShipCity"].ToString();
            txtShipRegion.Text = selectedOrder["ShipRegion"].ToString();
            txtShipPostalCode.Text = selectedOrder["ShipPostalCode"].ToString();
            txtShipmentCountry.Text = selectedOrder["ShipCountry"].ToString();
            txtFreight.Text = Convert.ToDecimal(selectedOrder["Freight"]).ToString("c");

        }

        private void DisplayCurrentOrder()
        {
            DataRow currentOrderRow = GetOrderDataRow(currentId);
            DisplayOrders(currentOrderRow);
        }
        #endregion

        // Step 3
        #region LOAD POSITION

        private void LoadFirstOrder()
        {
            currentId = GetFirstOrderId();
            LoadCurrentPosition();
            DisplayCurrentOrder();
        }

        private void LoadCurrentPosition()
        {
            DataRow positionInfoRow = GetPositionDataRow(currentId);

            int OrderCount = Convert.ToInt32(positionInfoRow["OrderCount"]);
            currentId = Convert.ToInt32(positionInfoRow["OrderId"]);
            firstId = Convert.ToInt32(positionInfoRow["FirstOrderId"]);
            lastId = Convert.ToInt32(positionInfoRow["LastOrderId"]);
            rowNumber = Convert.ToInt32(positionInfoRow["RowNumber"]);

            nextId = positionInfoRow["NextOrderId"] != DBNull.Value ?
                Convert.ToInt32(positionInfoRow["NextOrderId"]) : null;

            previousId = positionInfoRow["PreviousOrderId"] != DBNull.Value ?
                Convert.ToInt32(positionInfoRow["PreviousOrderId"]) : null;

            //NavigationMgtBtn goe Here

            NavigationButtonManagement();

            this.DisplayParentStatusStripmessage($"Display Order {rowNumber} out of {OrderCount}");


        }




        #endregion

        //Step 4

        #region Navigation
        private void DisableNavigation()
        {
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
        }

        private void NavigationButtonManagement()
        {
            btnPrevious.Enabled = previousId != null;
            btnNext.Enabled = nextId != null;

            btnFirst.Enabled = currentId != firstId;
            btnLast.Enabled = currentId != lastId;
        }


        private void NavigationHandler(object sender, EventArgs e)
        {
            if (sender == btnFirst)
            {
                currentId = firstId;
            }
            else if (sender == btnLast)
            {
                currentId = lastId;
            }
            else if (sender == btnNext)
            {
                if (nextId != null)
                {
                    currentId = nextId.Value;
                }
                else
                {
                    MessageBox.Show("The Last order is currently displayed");
                }
            }
            else if (sender == btnPrevious)
            {
                if (previousId != null)
                {
                    currentId = previousId.Value;
                }
                else
                {
                    MessageBox.Show("The FIrst Order is currently being Displayed");
                }
            }
            else
            {
                return;
            }
            LoadCurrentPosition();
            DisplayCurrentOrder();
        }


        #endregion

        //Step 5
        #region Data creation

        private void UpdateOrder()
        {
            string sqlupdateOrders = $@"
            UPDATE Orders
             SET
             OrderDate = '{txtOrderDate.Text.Trim()}',
             RequiredDate = '{txtRequiredDate.Text.Trim()}',
             ShippedDate = '{txtShipDate.Text.Trim()}',
             ShipName = '{DataAccess.SQLFix(txtshipmentName.Text.Trim())}',
             ShipAddress = '{DataAccess.SQLFix(txtShipAddress.Text.Trim())}',
             ShipCity = '{DataAccess.SQLFix(txtShipCity.Text.Trim())}',
             ShipRegion = '{DataAccess.SQLFix(txtShipRegion.Text.Trim())}',
             ShipPostalCode = '{DataAccess.SQLFix(txtShipPostalCode.Text.Trim())}',
             ShipCountry = '{DataAccess.SQLFix(txtShipmentCountry.Text.Trim())}',
             Freight = {txtFreight.Text}
             WHERE OrderId = {txtOrderId.Text}
                ";

            int rowsAffected = DataAccess.SendData(sqlupdateOrders);

            if (rowsAffected == 0)
            {
                MessageBox.Show("The DataBase reported no Rows Affected, meaning the changes were not saved");
            }
            else if (rowsAffected == 1)
            {
                MessageBox.Show("Order was successfully Created");
            }
            else
            {
                MessageBox.Show("Something went wrong, Please verify your data");
            }
        }

        private void CreateOrder()
        {
            string sqlInsertOrder = $@"
                 INSERT INTO Orders 
                  (
                    OrderDate,
                    RequiredDate,   
                    ShippedDate,
                    ShipName,
                    ShipAddress,
                    ShipCity,
                    ShipRegion,
                    ShipPostalCode,
                    ShipCountry,
                    Freight
                   ) 
                 VALUES
                  (
                    '{txtOrderDate.Text.Trim()}',
                    '{txtRequiredDate.Text.Trim()}',
                    '{txtShipDate.Text.Trim()}',
                    '{DataAccess.SQLFix(txtshipmentName.Text.Trim())}',
                    '{DataAccess.SQLFix(txtShipAddress.Text.Trim())}',
                    '{DataAccess.SQLFix(txtShipCity.Text.Trim())}',
                    '{DataAccess.SQLFix(txtShipRegion.Text.Trim())}',
                    '{DataAccess.SQLFix(txtShipPostalCode.Text.Trim())}',
                    '{DataAccess.SQLFix(txtShipmentCountry.Text.Trim())}',
                    {txtFreight.Text}
                    )";

            int rowAffected = DataAccess.SendData(sqlInsertOrder);

            if (rowAffected == 1)
            {
                MessageBox.Show("Order was created successfully");
            }
            else
            {
                MessageBox.Show("The Database reported No Rows Affected");
            }

        }


        private void DeleteOrder()
        {
            string sqlDelete = $"DELETE FROM Orders WHERE OrderId = {txtOrderId.Text};";

            int rowAffected = DataAccess.SendData(sqlDelete);

            if (rowAffected == 1)
            {
                MessageBox.Show("Order was Successfully Deleted");

            }
            else
            {
                MessageBox.Show("The Database reported no Rows was Affected");
            }

        }

        #endregion


        //Step 6

        #region FOrm state

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
                

                InputsReadOnly(true);
                NavigationButtonManagement();
            }
            else
            {
                btnAdd.Enabled = false;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnSave.Text = "Save";

                InputsReadOnly(false);
                if (state == FormState.Add)
                {
                    UIUtilities.ClearControls(grpOrders.Controls, 0);
                }
                DisableNavigation();
            }
        }

        private void InputsReadOnly(bool readOnly)
        {
            txtOrderDate.ReadOnly = readOnly;
            txtRequiredDate.ReadOnly = readOnly;
            txtShipAddress.ReadOnly = readOnly;
            txtShipCity.ReadOnly = readOnly;
            txtShipDate.ReadOnly = readOnly;
            txtshipmentName.ReadOnly = readOnly;
            txtShipPostalCode.ReadOnly = readOnly;
            txtShipRegion.ReadOnly = readOnly;
            txtFreight.ReadOnly = readOnly;

        }




        #endregion


        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadFirstOrder();

            this.StartParentProgressBar("Orders Loading...", "Order Loaded");
            SetState(FormState.View);
        }
        // Step 7

        #region CRUD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetState(FormState.Add);
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Order", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteOrder();
                LoadFirstOrder();   
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentState == FormState.View)
                {
                    SetState(FormState.Edit);
                    txtFreight.Text = "";
                }
                else
                {
                    if (ValidateChildren())
                    {
                        if (txtOrderId.Text == string.Empty)
                        {
                            CreateOrder();
                            
                        }
                        else
                        {
                            UpdateOrder();
                           
                        }

                        SetState(FormState.View);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Sql Related Error: " + ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState(FormState.View);
            LoadFirstOrder();

            errorProvider.Clear();
        }

        #endregion


        //Step 8

        #region Validation

        private void txt_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            string errMsg = null;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txt.Tag} is required";
                e.Cancel = true;
            }

            if (txt == txtFreight)
            {
                if (!Validators.IsNumeric(txt.Text))
                {
                    errMsg = $"{txt.Tag} must be numeric";
                }

            }

            if (txt == txtOrderDate || txt == txtRequiredDate || txt == txtShipDate)
            {
                if (!Validators.IsValidDate(txt.Text))
                {
                    errMsg = $"{txt.Tag} must be yyyy/mm/dd";
                }

            }
            errorProvider.SetError(txt, errMsg);

        }
            #endregion



     
    }
}
