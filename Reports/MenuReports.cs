using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publiRecargas.Reports
{
    public partial class MenuReports : Form
    {
        public MenuReports()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reports.VideosDevices frm = new Reports.VideosDevices();
            frm.Show();
        }
    }
}
