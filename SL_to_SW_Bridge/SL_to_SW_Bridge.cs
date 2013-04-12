using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SL_to_SW_Bridge
{
    public class SL_to_SW_Bridge
    {
        public void Start_Bridge(List<BillItem> ToImport)
        {
            BillImport Lower_Bridge = new BillImport(ToImport);

            Lower_Bridge.ShowDialog();

            if (Lower_Bridge.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                Lower_Bridge.Dispose();

                System.Windows.Forms.MessageBox.Show("Process Cancelled by User!", "WARNING!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            }
        }
    }
}
