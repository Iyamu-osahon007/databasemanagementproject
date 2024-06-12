namespace ProductsOrder
{
    partial class frmBrowseProduct
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowseProduct));
            groupBox1 = new GroupBox();
            cmbProducts = new ComboBox();
            dgvProducts = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbProducts);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(223, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(383, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select a Product ";
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(19, 36);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(303, 24);
            cmbProducts.TabIndex = 0;
            cmbProducts.SelectionChangeCommitted += cmbProducts_SelectionChangeCommitted;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 197);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(776, 252);
            dgvProducts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 42);
            label1.TabIndex = 2;
            label1.Text = "Browse Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmBrowseProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox1);
            Name = "frmBrowseProduct";
            Text = "Browse Product";
            Load += frmBrowseProduct_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbProducts;
        private DataGridView dgvProducts;
        private Label label1;
        private PictureBox pictureBox1;
    }
}