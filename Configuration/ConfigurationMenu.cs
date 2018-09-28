using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publiRecargas.Configuration
{
    public partial class ConfigurationMenu : Form
    {
        public ConfigurationMenu()
        {
            InitializeComponent();
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Configuration.Clients frm = new Configuration.Clients();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration.Videos frm = new Configuration.Videos();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VGlobales.tipo_usuario.Equals("Administrador"))
            {
                Configuration.Franchise frm = new Configuration.Franchise();
                frm.Show();
            }
            else
            {
                Mensajes.informacion("El Usuario no Tiene Acceso a Este Menú");
                return;
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Configuration.Device frm = new Configuration.Device();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (VGlobales.tipo_usuario.Equals("Administrador"))
            {
                Configuration.Users frm = new Configuration.Users();
                frm.Show();
            }
            else
            {
                Mensajes.informacion("El Usuario no Tiene Acceso a Este Menú");
                return;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Configuration.TipoDispositivo frm = new Configuration.TipoDispositivo();
            frm.Show();
        }
    }
}
