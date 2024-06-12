using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsOrder
{
    public static class UIUtilities
    {
        public static void Bind(this ComboBox cmb, string displayMember, string valueMember, object? dataSource)
        {
            cmb.DataSource = dataSource;
            cmb.ValueMember = valueMember;
            cmb.DisplayMember = displayMember;
        }

        public static void AddEmptyRow(this DataTable dt, string displayMember, string valueMember, string defaultText = "")
        {
            DataRow dr = dt.NewRow();
            dr[displayMember] = defaultText;
            //dr[emptyColumn] = "-- Select an Item --";
            dr[valueMember] = DBNull.Value;
            dt.Rows.InsertAt(dr, 0);
        }

        public static void clearChildControls(this Control control, int defaultSelectedIndex = 0)
        {

            ClearControls(control.Controls, defaultSelectedIndex);

        }


        public static void ClearControls(this Control.ControlCollection parentControl, int defaultSelectedIndex)
        {
            foreach (Control control in parentControl)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.Text = string.Empty;
                        break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                    case ComboBox combo:
                        combo.SelectedIndex = defaultSelectedIndex;
                        break;
                    case ListBox listbox:
                        listbox.SelectedIndex = defaultSelectedIndex;
                        break;
                    case GroupBox groupBox:
                        ClearControls(groupBox.Controls, defaultSelectedIndex);
                        break;
                }
            }
        }


        public static void DisplayParentStatusStripmessage(this Form form, string message)
        {
            DisplayParentStatusStripmessage(form, message, Color.Black);
        }

        public static void DisplayParentStatusStripmessage(this Form form, string message, Color color)
        {
            frmMDIParent? parentMdi = form.MdiParent as frmMDIParent;

            if (parentMdi != null)
            {
                parentMdi.DisplayStatusMessage(message, color);
            }

        }

        public static void StartParentProgressBar(this Form form, string startMessage, string endMessage)
        {
            frmMDIParent? parentMdi = form.MdiParent as frmMDIParent;

            if (parentMdi != null)
            {
                parentMdi.StartProgressBar(startMessage, endMessage);
            }
        }

    }
}
