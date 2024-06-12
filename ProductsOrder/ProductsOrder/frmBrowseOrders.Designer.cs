namespace ProductsOrder
{
    partial class frmBrowseOrders
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowseOrders));
            groupBox1 = new GroupBox();
            cmbOrders = new ComboBox();
            dgvOrders = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbOrders);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(218, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose an Order ";
            // 
            // cmbOrders
            // 
            cmbOrders.FormattingEnabled = true;
            cmbOrders.Location = new Point(34, 37);
            cmbOrders.Name = "cmbOrders";
            cmbOrders.Size = new Size(232, 24);
            cmbOrders.TabIndex = 0;
            cmbOrders.SelectionChangeCommitted += cmbOrders_SelectionChangeCommitted;
            // 
            // dgvOrders
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(26, 198);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(744, 230);
            dgvOrders.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 1;
            label1.Text = "Browse Orders";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmBrowseOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvOrders);
            Controls.Add(groupBox1);
            Name = "frmBrowseOrders";
            Text = "frmBrowseOrders";
            Load += frmBrowseOrders_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbOrders;
        private DataGridView dgvOrders;
        private Label label1;
        private PictureBox pictureBox1;
    }
}