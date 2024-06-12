using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsOrder
{
    public partial class frmMDIParent : Form
    {
        private int childFormNumber = 0;

        public frmMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form? childForm = null;

            ToolStripItem? menuItem = sender as ToolStripItem;

            //  Button? button = sender as Button;

            if (menuItem == null)
                return;
            switch (menuItem.Tag)
            {
                case "orders":
                    childForm = new frmOrder();
                    break;
                case "products":
                    childForm = new frmProducts();
                    break;
                case "productOrder":
                    childForm = new frmProductOrder();
                    break;
                case "browseorders":
                    childForm = new frmBrowseOrders();
                    break;
                case "browseproduct":
                    childForm = new frmBrowseProduct();
                    break;
                case "home":
                    childForm = new frmHome();
                    break;

            }

            //if (button == null)
            //    return;
            //switch (button.Tag)
            //{
            //    case "orders":
            //        childForm = new frmOrder();
            //        break;
            //    case "prodicts":
            //        childForm = new frmProducts();
            //        break;
            //}

            if (childForm != null)
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.GetType() == childForm.GetType())
                    {
                        form.Activate();
                        return;
                    }
                }
                childForm.MdiParent = this;
                childForm.Show();
            }
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        public void DisplayStatusMessage(string message, Color color)
        {
            this.toolStripStatusLabel.Text = message;
            this.toolStripStatusLabel.ForeColor = color;
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            SplashScreen splash = new SplashScreen();

            frmLogin login = new frmLogin();

         

            splash.ShowDialog();

            if(splash.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                login.ShowDialog();
            }

            if(login.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
           

        }

        public void StartProgressBar(string startMessage, string endMessage)
        {
            tspLabel.Text = startMessage;
            tsProgressbar.Value = 0;
            this.statusStrip.Refresh();

            while (tsProgressbar.Value < tsProgressbar.Maximum)
            {
                Thread.Sleep(2);
                tsProgressbar.Value += 1;
            }
            tsProgressbar.Value = 100;

            tspLabel.Text = endMessage;

        }
    }
}
