using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace publiRecargas
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void ShowPanel(object ContenidoPanel)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);

            Form Panel = (ContenidoPanel as Form);

            Panel.TopLevel = false;
            Panel.FormBorderStyle = FormBorderStyle.None;
            Panel.Dock = DockStyle.Fill;
            this.panel.Controls.Add(Panel);
            this.panel.Tag = ContenidoPanel;
            Panel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VGlobales.tipo_usuario.Equals("Administrador") || VGlobales.tipo_usuario.Equals("Franquicia"))
            {
                Configuration.ConfigurationMenu frm = new Configuration.ConfigurationMenu();
                ShowPanel(frm);
            }
            else
            {
                Mensajes.informacion("El Usuario no Tiene Acceso a Este Menú");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Campaign.MenuCampaign frm = new Campaign.MenuCampaign();
            ShowPanel(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VGlobales.tipo_usuario.Equals("Administrador"))
            {
                Reports.MenuReports frm = new Reports.MenuReports();
                ShowPanel(frm);
            }
            else
            {
                Mensajes.informacion("El Usuario no Tiene Acceso a Este Menú");
                return;
            }
        }
    }
}
