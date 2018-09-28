using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publiRecargas.Campaign
{
    public partial class MenuCampaign : Form
    {
        public MenuCampaign()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Campaign.NewCampaign frm = new Campaign.NewCampaign();
            frm.Show();
        }
    }
}
