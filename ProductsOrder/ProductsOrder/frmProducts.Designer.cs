namespace ProductsOrder
{
    partial class frmProducts
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            groupBox1 = new GroupBox();
            btn_cancel = new Button();
            btn_Edit_And_Save = new Button();
            btn_delete = new Button();
            btnAdd = new Button();
            btnSecond = new Button();
            btnFirst = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            chkDiscountinued = new CheckBox();
            label11 = new Label();
            txtReorder = new TextBox();
            label10 = new Label();
            txtUnitsOrder = new TextBox();
            label9 = new Label();
            txtUnitsStock = new TextBox();
            label8 = new Label();
            txtUnitPrice = new TextBox();
            label7 = new Label();
            txtQtyPerUnit = new TextBox();
            label6 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btn_cancel);
            groupBox1.Controls.Add(btn_Edit_And_Save);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnSecond);
            groupBox1.Controls.Add(btnFirst);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(chkDiscountinued);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtReorder);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtUnitsOrder);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtUnitsStock);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtQtyPerUnit);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(298, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 446);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(312, 370);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(62, 34);
            btn_cancel.TabIndex = 29;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_Edit_And_Save
            // 
            btn_Edit_And_Save.Location = new Point(231, 370);
            btn_Edit_And_Save.Name = "btn_Edit_And_Save";
            btn_Edit_And_Save.Size = new Size(62, 34);
            btn_Edit_And_Save.TabIndex = 29;
            btn_Edit_And_Save.Text = "Edit";
            btn_Edit_And_Save.UseVisualStyleBackColor = true;
            btn_Edit_And_Save.Click += btn_Edit_And_Save_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(139, 370);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(86, 34);
            btn_delete.TabIndex = 29;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(39, 370);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(62, 34);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSecond
            // 
            btnSecond.Location = new Point(312, 328);
            btnSecond.Name = "btnSecond";
            btnSecond.Size = new Size(62, 36);
            btnSecond.TabIndex = 28;
            btnSecond.Text = "> >";
            btnSecond.UseVisualStyleBackColor = true;
            btnSecond.Click += Navigationhandler;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(39, 328);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(62, 36);
            btnFirst.TabIndex = 27;
            btnFirst.Text = "< <";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += Navigationhandler;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(231, 328);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(62, 36);
            btnNext.TabIndex = 23;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += Navigationhandler;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(139, 328);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 36);
            btnPrevious.TabIndex = 22;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += Navigationhandler;
            // 
            // chkDiscountinued
            // 
            chkDiscountinued.AutoSize = true;
            chkDiscountinued.Location = new Point(139, 291);
            chkDiscountinued.Name = "chkDiscountinued";
            chkDiscountinued.Size = new Size(15, 14);
            chkDiscountinued.TabIndex = 20;
            chkDiscountinued.UseVisualStyleBackColor = true;
            chkDiscountinued.Validating += txt_Validating;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 287);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 19;
            label11.Text = "Discontinued:";
            // 
            // txtReorder
            // 
            txtReorder.Location = new Point(139, 247);
            txtReorder.Name = "txtReorder";
            txtReorder.ReadOnly = true;
            txtReorder.Size = new Size(235, 27);
            txtReorder.TabIndex = 17;
            txtReorder.Tag = "Order Level";
            txtReorder.Validating += txt_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 250);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 16;
            label10.Text = "Reorder Level:";
            // 
            // txtUnitsOrder
            // 
            txtUnitsOrder.Location = new Point(139, 214);
            txtUnitsOrder.Name = "txtUnitsOrder";
            txtUnitsOrder.ReadOnly = true;
            txtUnitsOrder.Size = new Size(235, 27);
            txtUnitsOrder.TabIndex = 15;
            txtUnitsOrder.Tag = "Unit On Order";
            txtUnitsOrder.Validating += txt_Validating;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 217);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 14;
            label9.Text = "Units on Order:";
            // 
            // txtUnitsStock
            // 
            txtUnitsStock.Location = new Point(139, 181);
            txtUnitsStock.Name = "txtUnitsStock";
            txtUnitsStock.ReadOnly = true;
            txtUnitsStock.Size = new Size(235, 27);
            txtUnitsStock.TabIndex = 13;
            txtUnitsStock.Tag = "Unit in Stock";
            txtUnitsStock.Validating += txt_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 184);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 12;
            label8.Text = "Units in Stock:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(139, 148);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(235, 27);
            txtUnitPrice.TabIndex = 11;
            txtUnitPrice.Tag = "Unit Price";
            txtUnitPrice.Validating += txt_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 148);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 10;
            label7.Text = "Unit Price:";
            // 
            // txtQtyPerUnit
            // 
            txtQtyPerUnit.Location = new Point(139, 115);
            txtQtyPerUnit.Name = "txtQtyPerUnit";
            txtQtyPerUnit.ReadOnly = true;
            txtQtyPerUnit.Size = new Size(235, 27);
            txtQtyPerUnit.TabIndex = 9;
            txtQtyPerUnit.Tag = "Qty Unit";
            txtQtyPerUnit.Validating += txt_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 118);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 8;
            label6.Text = "Qty/Unit:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(139, 74);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(235, 27);
            txtProductName.TabIndex = 3;
            txtProductName.Validating += txt_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 77);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(139, 41);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(235, 27);
            txtId.TabIndex = 0;
            txtId.Click += Navigationhandler;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 44);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 0;
            label2.Text = "Id:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 461);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(771, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(771, 483);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += frmProducts_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtReorder;
        private Label label10;
        private TextBox txtUnitsOrder;
        private Label label9;
        private TextBox txtUnitsStock;
        private Label label8;
        private TextBox txtUnitPrice;
        private Label label7;
        private TextBox txtQtyPerUnit;
        private Label label6;
        private TextBox txtProductName;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private CheckBox chkDiscountinued;
        private Label label11;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnSecond;
        private Button btnFirst;
        private Button btn_cancel;
        private Button btn_Edit_And_Save;
        private Button btn_delete;
        private Button btnAdd;
        private ErrorProvider errorProvider1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }


}
