namespace ProductsOrder
{
    partial class frmProductOrder
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
            grpProductOrdered = new GroupBox();
            labUnitP = new Label();
            lbl1Total = new Label();
            lblTotal = new Label();
            lblT = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnLast = new Button();
            btnDelete = new Button();
            btnNext = new Button();
            btnAdd = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            cmbProduct = new ComboBox();
            cmbOrder = new ComboBox();
            txtDst = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtQty = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label6 = new Label();
            lblDiscount = new Label();
            grpProductOrdered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grpProductOrdered
            // 
            grpProductOrdered.BackColor = SystemColors.GradientInactiveCaption;
            grpProductOrdered.Controls.Add(lblDiscount);
            grpProductOrdered.Controls.Add(labUnitP);
            grpProductOrdered.Controls.Add(lbl1Total);
            grpProductOrdered.Controls.Add(lblTotal);
            grpProductOrdered.Controls.Add(lblT);
            grpProductOrdered.Controls.Add(btnCancel);
            grpProductOrdered.Controls.Add(btnSave);
            grpProductOrdered.Controls.Add(btnLast);
            grpProductOrdered.Controls.Add(btnDelete);
            grpProductOrdered.Controls.Add(btnNext);
            grpProductOrdered.Controls.Add(btnAdd);
            grpProductOrdered.Controls.Add(btnPrevious);
            grpProductOrdered.Controls.Add(btnFirst);
            grpProductOrdered.Controls.Add(cmbProduct);
            grpProductOrdered.Controls.Add(cmbOrder);
            grpProductOrdered.Controls.Add(txtDst);
            grpProductOrdered.Controls.Add(label5);
            grpProductOrdered.Controls.Add(label6);
            grpProductOrdered.Controls.Add(label4);
            grpProductOrdered.Controls.Add(txtQty);
            grpProductOrdered.Controls.Add(label3);
            grpProductOrdered.Controls.Add(label2);
            grpProductOrdered.Controls.Add(label1);
            grpProductOrdered.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProductOrdered.Location = new Point(217, 12);
            grpProductOrdered.Name = "grpProductOrdered";
            grpProductOrdered.Size = new Size(571, 426);
            grpProductOrdered.TabIndex = 0;
            grpProductOrdered.TabStop = false;
            grpProductOrdered.Text = "Product Order Details";
            // 
            // labUnitP
            // 
            labUnitP.AutoSize = true;
            labUnitP.Location = new Point(94, 191);
            labUnitP.Name = "labUnitP";
            labUnitP.Size = new Size(20, 15);
            labUnitP.TabIndex = 9;
            labUnitP.Text = "C:";
            // 
            // lbl1Total
            // 
            lbl1Total.AutoSize = true;
            lbl1Total.Location = new Point(273, 192);
            lbl1Total.Name = "lbl1Total";
            lbl1Total.Size = new Size(20, 15);
            lbl1Total.TabIndex = 8;
            lbl1Total.Text = "C;";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(448, 187);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Click += label6_Click;
            // 
            // lblT
            // 
            lblT.AutoSize = true;
            lblT.Location = new Point(220, 192);
            lblT.Name = "lblT";
            lblT.Size = new Size(47, 15);
            lblT.TabIndex = 7;
            lblT.Text = "Total :";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(457, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 49);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnSave.Location = new Point(340, 371);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 49);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnLast.Location = new Point(457, 294);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(87, 49);
            btnLast.TabIndex = 3;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += NavigationHandler;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(204, 371);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 49);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnNext.Location = new Point(340, 294);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(87, 49);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += NavigationHandler;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAdd.Location = new Point(68, 371);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 49);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnPrevious.Location = new Point(204, 294);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(87, 49);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += NavigationHandler;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnFirst.Location = new Point(68, 294);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(87, 49);
            btnFirst.TabIndex = 3;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += NavigationHandler;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(94, 90);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(450, 23);
            cmbProduct.TabIndex = 2;
            cmbProduct.Validating += cmb_Validtion;
            // 
            // cmbOrder
            // 
            cmbOrder.FormattingEnabled = true;
            cmbOrder.Location = new Point(94, 38);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Size = new Size(450, 23);
            cmbOrder.TabIndex = 1;
            cmbOrder.Validating += cmb_Validtion;
            // 
            // txtDst
            // 
            txtDst.Location = new Point(94, 240);
            txtDst.Name = "txtDst";
            txtDst.Size = new Size(450, 21);
            txtDst.TabIndex = 5;
            txtDst.Validating += txt_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label5.Location = new Point(0, 245);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 0;
            label5.Text = "Discount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label4.Location = new Point(0, 189);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 0;
            label4.Text = "Unit Price:";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(94, 138);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(450, 21);
            txtQty.TabIndex = 3;
            txtQty.Validating += txt_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label3.Location = new Point(3, 143);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 0;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 0;
            label2.Text = "Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(50, 16);
            label1.TabIndex = 0;
            label1.Text = "Order:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(361, 191);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 0;
            label6.Text = "Discount Price :";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(459, 192);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(20, 15);
            lblDiscount.TabIndex = 9;
            lblDiscount.Text = "C:";
            // 
            // frmProductOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpProductOrdered);
            Name = "frmProductOrder";
            Tag = "productOrder";
            Text = "ProductOrdered";
            Load += frmProductOrder_Load;
            Click += NavigationHandler;
            grpProductOrdered.ResumeLayout(false);
            grpProductOrdered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpProductOrdered;
        private ComboBox cmbProduct;
        private ComboBox cmbOrder;
        private TextBox txtQty;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private Button btnLast;
        private Button btnDelete;
        private Button btnNext;
        private Button btnAdd;
        private Button btnPrevious;
        private Button btnFirst;
        private TextBox txtDst;
        private Label label5;
        private Label label4;
        private TextBox txtUnitP;
        private Label lblT;
        private Label lblTotal;
        private Label lbl1Total;
        private Label labUnitP;
        private Label lblDiscount;
        private Label label6;
    }
}