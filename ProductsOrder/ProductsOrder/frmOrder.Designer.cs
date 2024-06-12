namespace ProductsOrder
{
    partial class frmOrder
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
            grpOrders = new GroupBox();
            txtOrderId = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnLast = new Button();
            btnAdd = new Button();
            txtShipmentCountry = new TextBox();
            txtFreight = new TextBox();
            txtShipPostalCode = new TextBox();
            txtShipRegion = new TextBox();
            txtShipCity = new TextBox();
            txtShipAddress = new TextBox();
            txtshipmentName = new TextBox();
            txtShipDate = new TextBox();
            label7 = new Label();
            label9 = new Label();
            lbel8 = new Label();
            label8 = new Label();
            lbl001 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnDelete = new Button();
            btnFirst = new Button();
            btnSave = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            txtRequiredDate = new TextBox();
            label3 = new Label();
            txtOrderDate = new TextBox();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            grpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // grpOrders
            // 
            grpOrders.BackColor = SystemColors.GradientActiveCaption;
            grpOrders.Controls.Add(txtOrderId);
            grpOrders.Controls.Add(label1);
            grpOrders.Controls.Add(btnCancel);
            grpOrders.Controls.Add(btnLast);
            grpOrders.Controls.Add(btnAdd);
            grpOrders.Controls.Add(txtShipmentCountry);
            grpOrders.Controls.Add(txtFreight);
            grpOrders.Controls.Add(txtShipPostalCode);
            grpOrders.Controls.Add(txtShipRegion);
            grpOrders.Controls.Add(txtShipCity);
            grpOrders.Controls.Add(txtShipAddress);
            grpOrders.Controls.Add(txtshipmentName);
            grpOrders.Controls.Add(txtShipDate);
            grpOrders.Controls.Add(label7);
            grpOrders.Controls.Add(label9);
            grpOrders.Controls.Add(lbel8);
            grpOrders.Controls.Add(label8);
            grpOrders.Controls.Add(lbl001);
            grpOrders.Controls.Add(label6);
            grpOrders.Controls.Add(label5);
            grpOrders.Controls.Add(label4);
            grpOrders.Controls.Add(btnDelete);
            grpOrders.Controls.Add(btnFirst);
            grpOrders.Controls.Add(btnSave);
            grpOrders.Controls.Add(btnPrevious);
            grpOrders.Controls.Add(btnNext);
            grpOrders.Controls.Add(txtRequiredDate);
            grpOrders.Controls.Add(label3);
            grpOrders.Controls.Add(txtOrderDate);
            grpOrders.Controls.Add(label2);
            grpOrders.Dock = DockStyle.Right;
            grpOrders.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpOrders.Location = new Point(274, 0);
            grpOrders.Margin = new Padding(0, 0, 0, 40);
            grpOrders.Name = "grpOrders";
            grpOrders.Padding = new Padding(4);
            grpOrders.Size = new Size(560, 572);
            grpOrders.TabIndex = 9;
            grpOrders.TabStop = false;
            grpOrders.Text = "Orders";
            // 
            // txtOrderId
            // 
            txtOrderId.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderId.Location = new Point(151, 24);
            txtOrderId.Margin = new Padding(4);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(391, 20);
            txtOrderId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 17);
            label1.TabIndex = 27;
            label1.Text = "Id:";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(444, 436);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 54);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(444, 380);
            btnLast.Margin = new Padding(4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(94, 50);
            btnLast.TabIndex = 22;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += NavigationHandler;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(139, 436);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 54);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtShipmentCountry
            // 
            txtShipmentCountry.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShipmentCountry.Location = new Point(151, 313);
            txtShipmentCountry.Margin = new Padding(4);
            txtShipmentCountry.Name = "txtShipmentCountry";
            txtShipmentCountry.PlaceholderText = "Country";
            txtShipmentCountry.Size = new Size(391, 20);
            txtShipmentCountry.TabIndex = 8;
            txtShipmentCountry.Tag = "country";
            txtShipmentCountry.Text = "Country";
            txtShipmentCountry.Validating += txt_validating;
            // 
            // txtFreight
            // 
            txtFreight.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFreight.Location = new Point(372, 347);
            txtFreight.Margin = new Padding(4);
            txtFreight.Name = "txtFreight";
            txtFreight.PlaceholderText = "Freight";
            txtFreight.Size = new Size(133, 20);
            txtFreight.TabIndex = 10;
            txtFreight.Tag = "freight";
            txtFreight.Text = "Freight";
            txtFreight.Validating += txt_validating;
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShipPostalCode.Location = new Point(151, 346);
            txtShipPostalCode.Margin = new Padding(4);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.PlaceholderText = "Postal Code";
            txtShipPostalCode.Size = new Size(133, 20);
            txtShipPostalCode.TabIndex = 9;
            txtShipPostalCode.Tag = "postal code";
            txtShipPostalCode.Text = "Postal Code";
            txtShipPostalCode.Validating += txt_validating;
            // 
            // txtShipRegion
            // 
            txtShipRegion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShipRegion.Location = new Point(151, 277);
            txtShipRegion.Margin = new Padding(4);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.PlaceholderText = "Region";
            txtShipRegion.Size = new Size(391, 20);
            txtShipRegion.TabIndex = 7;
            txtShipRegion.Tag = "region";
            txtShipRegion.Text = "Region";
            txtShipRegion.Validating += txt_validating;
            // 
            // txtShipCity
            // 
            txtShipCity.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShipCity.Location = new Point(151, 239);
            txtShipCity.Margin = new Padding(4);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.PlaceholderText = "City";
            txtShipCity.Size = new Size(391, 20);
            txtShipCity.TabIndex = 6;
            txtShipCity.Tag = "city";
            txtShipCity.Text = "City";
            txtShipCity.Validating += txt_validating;
            // 
            // txtShipAddress
            // 
            txtShipAddress.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShipAddress.Location = new Point(151, 202);
            txtShipAddress.Margin = new Padding(4);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.PlaceholderText = "Address";
            txtShipAddress.Size = new Size(391, 20);
            txtShipAddress.TabIndex = 5;
            txtShipAddress.Tag = "address";
            txtShipAddress.Text = "Address";
            txtShipAddress.Validating += txt_validating;
            // 
            // txtshipmentName
            // 
            txtshipmentName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtshipmentName.Location = new Point(151, 165);
            txtshipmentName.Margin = new Padding(4);
            txtshipmentName.Name = "txtshipmentName";
            txtshipmentName.PlaceholderText = "Name";
            txtshipmentName.Size = new Size(391, 20);
            txtshipmentName.TabIndex = 4;
            txtshipmentName.Tag = "name";
            txtshipmentName.Text = "Name";
            txtshipmentName.Validating += txt_validating;
            // 
            // txtShipDate
            // 
            txtShipDate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShipDate.Location = new Point(151, 128);
            txtShipDate.Margin = new Padding(4);
            txtShipDate.Name = "txtShipDate";
            txtShipDate.PlaceholderText = "yyyy-mm-dd";
            txtShipDate.Size = new Size(391, 20);
            txtShipDate.TabIndex = 3;
            txtShipDate.Tag = "shipdate";
            txtShipDate.Text = "yyyy-mm-dd";
            txtShipDate.Validating += txt_validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 349);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 4;
            label7.Text = "Freight";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 313);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 17);
            label9.TabIndex = 4;
            label9.Text = "Ship Country";
            // 
            // lbel8
            // 
            lbel8.AutoSize = true;
            lbel8.Location = new Point(12, 347);
            lbel8.Margin = new Padding(4, 0, 4, 0);
            lbel8.Name = "lbel8";
            lbel8.Size = new Size(127, 17);
            lbel8.TabIndex = 4;
            lbel8.Text = "Ship PostalCode";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 277);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 17);
            label8.TabIndex = 4;
            label8.Text = "Shipment Region";
            // 
            // lbl001
            // 
            lbl001.AutoSize = true;
            lbl001.Location = new Point(30, 239);
            lbl001.Margin = new Padding(4, 0, 4, 0);
            lbl001.Name = "lbl001";
            lbl001.Size = new Size(107, 17);
            lbl001.TabIndex = 4;
            lbl001.Text = "Shipment City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 202);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 17);
            label6.TabIndex = 4;
            label6.Text = "Shipment Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 165);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 17);
            label5.TabIndex = 4;
            label5.Text = "Shipment Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 4;
            label4.Text = "Shipment Date";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(241, 436);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 54);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(139, 380);
            btnFirst.Margin = new Padding(4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(94, 50);
            btnFirst.TabIndex = 21;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += NavigationHandler;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(342, 436);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 54);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(241, 380);
            btnPrevious.Margin = new Padding(4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 50);
            btnPrevious.TabIndex = 20;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += NavigationHandler;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(342, 380);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 50);
            btnNext.TabIndex = 19;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += NavigationHandler;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRequiredDate.Location = new Point(151, 93);
            txtRequiredDate.Margin = new Padding(4);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.PlaceholderText = "yyyy-mm-dd";
            txtRequiredDate.Size = new Size(391, 20);
            txtRequiredDate.TabIndex = 2;
            txtRequiredDate.Tag = "date";
            txtRequiredDate.Text = "yyyy-mm-dd";
            txtRequiredDate.Validating += txt_validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 93);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 2;
            label3.Text = "Required Date";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BackColor = SystemColors.Window;
            txtOrderDate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderDate.ForeColor = SystemColors.WindowText;
            txtOrderDate.Location = new Point(151, 58);
            txtOrderDate.Margin = new Padding(4);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.PlaceholderText = "yyyy-mm-dd";
            txtOrderDate.Size = new Size(391, 20);
            txtOrderDate.TabIndex = 1;
            txtOrderDate.Tag = "date";
            txtOrderDate.Text = "yyyy-mm-dd";
            txtOrderDate.Validating += txt_validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 0;
            label2.Text = "Order Date";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(834, 572);
            Controls.Add(grpOrders);
            Margin = new Padding(4);
            Name = "frmOrder";
            Text = "Order";
            Load += frmOrder_Load;
            grpOrders.ResumeLayout(false);
            grpOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtShipDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private TextBox txtShipAddress;
        private TextBox txtshipmentName;
        private TextBox txtShipPostalCode;
        private TextBox txtShipRegion;
        private TextBox txtShipCity;
        private Label lbel8;
        private Label label8;
        private Label lbl001;
        private Label label6;
        private Label label5;
        private TextBox txtShipmentCountry;
        private TextBox txtFreight;
        private Label label7;
        private Label label9;
    }
}
