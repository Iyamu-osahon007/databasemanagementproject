namespace ProductsOrder
{
    partial class frmMDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIParent));
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            productOrderToolStripMenuItem = new ToolStripMenuItem();
            browseOrderToolStripMenuItem = new ToolStripMenuItem();
            browseProductsToolStripMenuItem = new ToolStripMenuItem();
            tsmHome = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            tspOrder = new ToolStripButton();
            tspProducts = new ToolStripButton();
            tsbProductsorder = new ToolStripButton();
            tsbBO = new ToolStripButton();
            tsbBP = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            tsProgressbar = new ToolStripProgressBar();
            tspLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, maintenanceToolStripMenuItem, tsmHome });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripSeparator4, toolStripSeparator5, exitToolStripMenuItem });
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(37, 20);
            fileMenu.Text = "&File";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolsStripMenuItem_Click;
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { orderToolStripMenuItem, productsToolStripMenuItem, productOrderToolStripMenuItem, browseOrderToolStripMenuItem, browseProductsToolStripMenuItem });
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(88, 20);
            maintenanceToolStripMenuItem.Tag = "";
            maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(162, 22);
            orderToolStripMenuItem.Tag = "orders";
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += ShowNewForm;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(162, 22);
            productsToolStripMenuItem.Tag = "products";
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += ShowNewForm;
            // 
            // productOrderToolStripMenuItem
            // 
            productOrderToolStripMenuItem.Name = "productOrderToolStripMenuItem";
            productOrderToolStripMenuItem.Size = new Size(162, 22);
            productOrderToolStripMenuItem.Tag = "productOrder";
            productOrderToolStripMenuItem.Text = "Product Order";
            productOrderToolStripMenuItem.Click += ShowNewForm;
            // 
            // browseOrderToolStripMenuItem
            // 
            browseOrderToolStripMenuItem.Name = "browseOrderToolStripMenuItem";
            browseOrderToolStripMenuItem.Size = new Size(162, 22);
            browseOrderToolStripMenuItem.Tag = "browseorders";
            browseOrderToolStripMenuItem.Text = "Browse Order";
            browseOrderToolStripMenuItem.Click += ShowNewForm;
            // 
            // browseProductsToolStripMenuItem
            // 
            browseProductsToolStripMenuItem.Name = "browseProductsToolStripMenuItem";
            browseProductsToolStripMenuItem.Size = new Size(162, 22);
            browseProductsToolStripMenuItem.Tag = "browseproduct";
            browseProductsToolStripMenuItem.Text = "Browse Products";
            browseProductsToolStripMenuItem.Click += ShowNewForm;
            // 
            // tsmHome
            // 
            tsmHome.Name = "tsmHome";
            tsmHome.Size = new Size(52, 20);
            tsmHome.Tag = "home";
            tsmHome.Text = "Home";
            tsmHome.Click += ShowNewForm;
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripSeparator2, tspOrder, tspProducts, tsbProductsorder, tsbBO, tsbBP });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(737, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tspOrder
            // 
            tspOrder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tspOrder.Image = (Image)resources.GetObject("tspOrder.Image");
            tspOrder.ImageTransparentColor = Color.Magenta;
            tspOrder.Name = "tspOrder";
            tspOrder.Size = new Size(23, 22);
            tspOrder.Tag = "orders";
            tspOrder.Text = "Orders";
            tspOrder.Click += ShowNewForm;
            // 
            // tspProducts
            // 
            tspProducts.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tspProducts.Image = (Image)resources.GetObject("tspProducts.Image");
            tspProducts.ImageTransparentColor = Color.Magenta;
            tspProducts.Name = "tspProducts";
            tspProducts.Size = new Size(23, 22);
            tspProducts.Tag = "products";
            tspProducts.Text = "Products";
            tspProducts.Click += ShowNewForm;
            // 
            // tsbProductsorder
            // 
            tsbProductsorder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbProductsorder.Image = (Image)resources.GetObject("tsbProductsorder.Image");
            tsbProductsorder.ImageTransparentColor = Color.Magenta;
            tsbProductsorder.Name = "tsbProductsorder";
            tsbProductsorder.Size = new Size(23, 22);
            tsbProductsorder.Tag = "productOrder";
            tsbProductsorder.Text = "ProductOrdered";
            tsbProductsorder.Click += ShowNewForm;
            // 
            // tsbBO
            // 
            tsbBO.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBO.Image = (Image)resources.GetObject("tsbBO.Image");
            tsbBO.ImageTransparentColor = Color.Magenta;
            tsbBO.Name = "tsbBO";
            tsbBO.Size = new Size(23, 22);
            tsbBO.Tag = "browseorders";
            tsbBO.Text = "Browse Orders";
            // 
            // tsbBP
            // 
            tsbBP.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBP.Image = (Image)resources.GetObject("tsbBP.Image");
            tsbBP.ImageTransparentColor = Color.Magenta;
            tsbBP.Name = "tsbBP";
            tsbBP.Size = new Size(23, 22);
            tsbBP.Tag = "browseproduct";
            tsbBP.Text = "Browse Products";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, tsProgressbar, tspLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // tsProgressbar
            // 
            tsProgressbar.Name = "tsProgressbar";
            tsProgressbar.Size = new Size(100, 16);
            // 
            // tspLabel
            // 
            tspLabel.Name = "tspLabel";
            tspLabel.Size = new Size(52, 17);
            tspLabel.Text = "Progress";
            // 
            // frmMDIParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMDIParent";
            Text = "frmMDIParent";
            Load += frmMDIParent_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem productOrderToolStripMenuItem;
        private ToolStripMenuItem browseOrderToolStripMenuItem;
        private ToolStripMenuItem browseProductsToolStripMenuItem;
        private ToolStripButton tspOrder;
        private ToolStripButton tspProducts;
        private ToolStripProgressBar tsProgressbar;
        private ToolStripButton tsbProductsorder;
        private ToolStripButton tsbBO;
        private ToolStripButton tsbBP;
        private ToolStripMenuItem tsmHome;
        private ToolStripStatusLabel tspLabel;
    }
}



