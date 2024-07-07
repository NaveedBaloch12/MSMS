using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware.Pages
{
    public partial class pg_Setting : UserControl
    {
        public pg_Setting()
        {
            InitializeComponent();
        }

        private void cdBackGroundclr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.ChangeBGClr(cdBackGroundclr.SelectedIndex);
        }
    }
}
