using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsOrder
{
    public partial class frmProducts : Form
    {
        private int currentId;
        private int firstId;
        private int lastId;
        private int? nextId;
        private int? previousId;
        private int rowNumber;

        

        private FormState currentState;

        public frmProducts()
        {
            InitializeComponent();
        }



        //Step 1 

        #region Get Rows

        private int GetFirstProductId()
        {
            int id = Convert.ToInt32(DataAccess.GetValue("SELECT TOP(1) ProductId FROM Product ORDER BY ProductName"));

            return id;
        }

        private DataRow GetProductDataRow(int id)
        {

            string sqlProductId = $"SELECT ProductId, ProductName, PricePerUnit, Quantity, Stock, UnitOrder, ReOrderLevel,Discontinued FROM Product WHERE ProductId = {id}";
            DataTable dt = DataAccess.GetData(sqlProductId);

            return dt.Rows[0];
        }

        //This is for Navigation

        private DataRow GetPositionDataRow(int id)
        {
            string sqlNavigate = $@"
            SELECT 
                 (SELECT COUNT(1) FROM Product) AS ProductCount,
                 ProductId,
                 (
	                SELECT TOP(1) ProductId as FirstProductId  FROM Product ORDER BY ProductName

                 ) as FirstProductId,
                 q.PreviousProductId,
                 q.NextProductId,
                 (
	                SELECT TOP(1) ProductId as LastProductId FROM Product ORDER BY ProductName Desc

                 ) as LastProductId,
                 q.RowNumber
                 FROM
                 (
	                SELECT ProductId, ProductName,
	                LEAD(ProductId) OVER(ORDER BY ProductName) AS NextProductId,
	                LAG(ProductId) OVER(ORDER BY ProductName) AS PreviousProductId,
	                ROW_NUMBER() OVER(ORDER BY ProductName) AS 'RowNumber'
	                FROM Product
                 ) AS q
                 WHERE q.ProductId = {id}
                 ORDER BY q.ProductName
                            ";


            DataTable dt = DataAccess.GetData(sqlNavigate);

            return dt.Rows[0];
        }





        #endregion


        //Step 2

        #region

        private void DisplayProducts(DataRow selectedProduct)
        {

            txtId.Text = selectedProduct["ProductId"].ToString();
            txtProductName.Text = selectedProduct["ProductName"].ToString();
            txtQtyPerUnit.Text = selectedProduct["Quantity"].ToString();
            txtUnitPrice.Text = selectedProduct["PricePerUnit"].ToString();
            txtUnitsStock.Text = selectedProduct["Stock"].ToString();
            txtUnitsOrder.Text = selectedProduct["UnitOrder"].ToString();
            txtReorder.Text = selectedProduct["ReOrderLevel"].ToString();

            chkDiscountinued.Checked = Convert.ToBoolean(selectedProduct["Discontinued"]);

        }

        private void DisplayCurrentProduct()
        {
            DataRow currentProductRow = GetProductDataRow(currentId);
            DisplayProducts(currentProductRow);
        }


        #endregion

        //Step 3
        #region Load Position

        private void LoadFirstProduct()
        {
            currentId = GetFirstProductId();
            LoadCurrentPosition();
            DisplayCurrentProduct();
        }

        private void LoadCurrentPosition()
        {
            DataRow positionInfoRow = GetPositionDataRow(currentId);

            int productCount = Convert.ToInt32(positionInfoRow["ProductCount"]);
            currentId = Convert.ToInt32(positionInfoRow["ProductId"]);
            firstId = Convert.ToInt32(positionInfoRow["FirstProductId"]);
            lastId = Convert.ToInt32(positionInfoRow["LastProductId"]);
            rowNumber = Convert.ToInt32(positionInfoRow["RowNumber"]);

            nextId = positionInfoRow["NextProductId"] != DBNull.Value ?
                Convert.ToInt32(positionInfoRow["NextProductId"]) : null;

            previousId = positionInfoRow["PreviousProductId"] != DBNull.Value ?
                Convert.ToInt32(positionInfoRow["PreviousProductId"]) : null;

            NavigationButtonManagement();

            this.DisplayParentStatusStripmessage($"Display Products {rowNumber} out of {productCount}");
        }

        #endregion




        // Step 4 Status toolstrip
        public void DisplayToolStrip(string text, Color foreColor)
        {
            toolStripStatusLabel1.Text = text;

            toolStripStatusLabel1.ForeColor = foreColor;
        }


        //Step 6 




        private void frmProducts_Load(object sender, EventArgs e)
        {
           


        }

        #region Navigate Region



        private void DisAbleNavigation()
        {


            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnFirst.Enabled = false;
            btnSecond.Enabled = false;
        }

        private void Navigationhandler(object sender, EventArgs e)
        {
            if (sender == btnFirst)
            {
                currentId = firstId;

            }
            else if (sender == btnSecond)
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
                    MessageBox.Show("The last product is currently Displayed");
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
                    MessageBox.Show("The first product is currently displayed");
                }
            }
            else
            {
                return;
            }
            LoadCurrentPosition();
            DisplayCurrentProduct();

        }



        //Step 5 Navigation mangement

        private void NavigationButtonManagement()
        {
            btnPrevious.Enabled = previousId != null;
            btnNext.Enabled = nextId != null;

            btnFirst.Enabled = currentId != firstId;
            btnSecond.Enabled = currentId != lastId;
        }

        #endregion


        #region CRUD
        private void UpdateProducts()
        {
            string sqlUpdate = $@"
                UPDATE Product
                SET ProductName = '{DataAccess.SQLFix(txtProductName.Text.Trim())}',
                Quantity = '{DataAccess.SQLFix(txtQtyPerUnit.Text.Trim())}',
                PricePerUnit = {txtUnitPrice.Text},
                Stock = {txtUnitsStock.Text},
                UnitOrder = {txtUnitsOrder.Text},
                ReorderLevel = {txtReorder.Text},
                Discontinued = {(chkDiscountinued.Checked ? 1 : 0)}
                WHERE
	                ProductID = {txtId.Text}";

            int rowsAffected = DataAccess.SendData(sqlUpdate);
            int stock = Convert.ToInt32(txtUnitsStock.Text);

            int Order = Convert.ToInt32(txtUnitsOrder.Text);

            if (stock < 4 && Order > 5)
            {
                MessageBox.Show("Stock level must be greater than 4 to add product");
            }
            else
            {

                if (rowsAffected == 0)
                {
                    MessageBox.Show("THe Database reported no rows Affected, Meaning the changes were not saved");
                }
                else if (rowsAffected == 1)
                {
                    MessageBox.Show("Product Updated");
                }
                else
                {
                    MessageBox.Show("Something went wrong, Please verify your data");
                }
            }

        }

        private void CreateProduct()
        {
            string sqlInsertProduct = $@"
                Insert Into Product
                (
	                ProductName,
                    Quantity,
	                PricePerUnit,
	                Stock,
	                UnitOrder,
	                ReorderLevel,
	                Discontinued
                 )
                Values
                (
                    '{txtProductName.Text.Trim()}',
                    '{txtQtyPerUnit.Text.Trim()}',
                    {txtUnitPrice.Text},
                    {txtUnitsStock.Text},
                    {txtUnitsOrder.Text},
                    {txtReorder.Text},
                    {(chkDiscountinued.Checked ? 1 : 0)}
                )";

            int rowAfffected = DataAccess.SendData(sqlInsertProduct);


                if (rowAfffected == 1)
                {

                    MessageBox.Show("Product Created");
                }
                else
                {
                    MessageBox.Show("The Database reported No rows affected");

                }
            


          
        }

        private void DeleteProduct()
        {
            string sqlDelete = $"DELETE FROM Product WHERE ProductId = {txtId.Text}";

            int rowsAffected = DataAccess.SendData(sqlDelete);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Product was Deleted successfully", "Successful");
            }
            else
            {
                MessageBox.Show("The Database reported no rows Affected");
            }
        }




        #endregion


        #region FormState

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
                btn_cancel.Enabled = false;
                btn_delete.Enabled = true;
                btn_Edit_And_Save.Text = "Edit";

                InputsReadOnly(true);
                NavigationButtonManagement();
            }
            else
            {
                btnAdd.Enabled = false;
                btn_cancel.Enabled = true;
                btn_delete.Enabled = false;
                btn_Edit_And_Save.Text = "Save";

                InputsReadOnly(false);

                if (state == FormState.Add)
                {
                    UIUtilities.ClearControls(groupBox1.Controls,0);

                }
                DisAbleNavigation();


            }
        }

        private void InputsReadOnly(bool readOnly)
        {
            txtProductName.ReadOnly = readOnly;
            txtQtyPerUnit.ReadOnly = readOnly;
            txtReorder.ReadOnly = readOnly;
            txtUnitPrice.ReadOnly = readOnly;
            txtUnitsOrder.ReadOnly = readOnly;
            txtUnitsStock.ReadOnly = readOnly;
            chkDiscountinued.Enabled = readOnly;
        }




        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetState(FormState.Add);
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this instructor", "Are you sure?",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteProduct();
                LoadFirstProduct();


            }
        }

        private void btn_Edit_And_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentState == FormState.View)
                {
                    SetState(FormState.Edit);
                }
                else
                {
                    if (ValidateChildren())
                    {
                        if (txtId.Text == string.Empty)
                        {
                            //Adding 
                            int stock = Convert.ToInt32(txtUnitsStock.Text);

                            int Order = Convert.ToInt32(txtUnitsOrder.Text);

                            if (stock < 4 && Order > 5)
                            {
                                MessageBox.Show("Stock level must be greater than 4 to add product");
                            }
                            else
                            {
                                CreateProduct();
                                DisplayCurrentProduct();

                            }



                        }
                        else
                        {
                            //Edit 
                            int stock = Convert.ToInt32(txtUnitsStock.Text);

                            int Order = Convert.ToInt32(txtUnitsOrder.Text);

                            if (stock < 4 && Order > 5)
                            {
                                MessageBox.Show("Stock level must be greater than 4 to add product");
                            }
                            else
                            {
                                UpdateProducts();
                                DisplayCurrentProduct();
                            }
                          
                           
                           

                        }

                        SetState(FormState.View);

                    }
                    else
                    {
                        MessageBox.Show("Please resolve your validation");
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SetState(FormState.View);

            LoadFirstProduct() ;
            errorProvider1.Clear();

        }


        #region Validating

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox? txt = sender as TextBox;

            if (txt == null)
                return;

            string? errmsg = string.Empty;

            if (txt.Text == string.Empty)
            {
                errmsg = $"{txt.Tag} is Required";
            }

            if (txt == txtUnitPrice || txt == txtReorder
                || txt == txtUnitsOrder || txt == txtUnitsStock)
            {
                if (!Validators.IsNumeric(txt.Text))
                {
                    errmsg = $"{txt.Tag} is not numeric";
                }

            }

            //Business Rules
            string unit = txtUnitsStock.Text;
            if(txt == txtUnitsStock)
            {
                if(!int.TryParse(unit, out int intUnits) && intUnits < 4)
                {
                    errmsg = $"{txt.Tag} less than 4 cannot be added";
                }
               
            }

            errorProvider1.SetError(txt, errmsg);
        }





        #endregion

        private void frmProducts_Load_1(object sender, EventArgs e)
        {
            LoadFirstProduct();

            this.StartParentProgressBar("Products Loading...", "Products Loded");
            SetState(FormState.View);
        }
    }

}

