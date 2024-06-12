namespace ProductsOrder
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            btnOrder = new Button();
            btnProducts = new Button();
            btnProductsOrder = new Button();
            btnBrowseOrders = new Button();
            btnBrowseProduct = new Button();
            lblIvm = new Label();
            lblMaintain = new Label();
            lblBrowse = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.GradientActiveCaption;
            btnOrder.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(170, 157);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(165, 53);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Orders";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.GradientActiveCaption;
            btnProducts.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(170, 269);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(165, 53);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnProductsOrder
            // 
            btnProductsOrder.BackColor = SystemColors.GradientActiveCaption;
            btnProductsOrder.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductsOrder.Location = new Point(170, 375);
            btnProductsOrder.Name = "btnProductsOrder";
            btnProductsOrder.Size = new Size(165, 53);
            btnProductsOrder.TabIndex = 0;
            btnProductsOrder.Text = "Products Ordered";
            btnProductsOrder.UseVisualStyleBackColor = false;
            btnProductsOrder.Click += btnProductsOrder_Click;
            // 
            // btnBrowseOrders
            // 
            btnBrowseOrders.BackColor = SystemColors.GradientActiveCaption;
            btnBrowseOrders.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseOrders.Location = new Point(481, 157);
            btnBrowseOrders.Name = "btnBrowseOrders";
            btnBrowseOrders.Size = new Size(165, 53);
            btnBrowseOrders.TabIndex = 0;
            btnBrowseOrders.Text = "Browse Orders";
            btnBrowseOrders.UseVisualStyleBackColor = false;
            btnBrowseOrders.Click += btnBrowseOrders_Click;
            // 
            // btnBrowseProduct
            // 
            btnBrowseProduct.BackColor = SystemColors.GradientActiveCaption;
            btnBrowseProduct.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseProduct.Location = new Point(481, 269);
            btnBrowseProduct.Name = "btnBrowseProduct";
            btnBrowseProduct.Size = new Size(165, 53);
            btnBrowseProduct.TabIndex = 0;
            btnBrowseProduct.Text = "Browse Products";
            btnBrowseProduct.UseVisualStyleBackColor = false;
            btnBrowseProduct.Click += btnBrowseProduct_Click;
            // 
            // lblIvm
            // 
            lblIvm.AutoSize = true;
            lblIvm.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIvm.Location = new Point(302, 20);
            lblIvm.Name = "lblIvm";
            lblIvm.Size = new Size(200, 39);
            lblIvm.TabIndex = 1;
            lblIvm.Text = "IVM MANAGER";
            lblIvm.Click += label1_Click;
            // 
            // lblMaintain
            // 
            lblMaintain.AutoSize = true;
            lblMaintain.Font = new Font("Sitka Subheading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaintain.Location = new Point(147, 83);
            lblMaintain.Name = "lblMaintain";
            lblMaintain.Size = new Size(209, 30);
            lblMaintain.TabIndex = 1;
            lblMaintain.Text = "MainTain Inventory";
            lblMaintain.Click += label1_Click;
            // 
            // lblBrowse
            // 
            lblBrowse.AutoSize = true;
            lblBrowse.Font = new Font("Sitka Subheading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrowse.Location = new Point(466, 83);
            lblBrowse.Name = "lblBrowse";
            lblBrowse.Size = new Size(189, 30);
            lblBrowse.TabIndex = 1;
            lblBrowse.Text = "Browse Inventory";
            lblBrowse.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(113, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(113, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(113, 375);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 50);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(424, 272);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 50);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(424, 160);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblBrowse);
            Controls.Add(lblMaintain);
            Controls.Add(lblIvm);
            Controls.Add(btnProductsOrder);
            Controls.Add(btnProducts);
            Controls.Add(btnBrowseProduct);
            Controls.Add(btnBrowseOrders);
            Controls.Add(btnOrder);
            MinimizeBox = false;
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmHome";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrder;
        private Button btnProducts;
        private Button btnProductsOrder;
        private Button btnBrowseOrders;
        private Button btnBrowseProduct;
        private Label lblIvm;
        private Label lblMaintain;
        private Label lblBrowse;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}