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

namespace publiRecargas.Reports
{
    public partial class VideosDevices : Form
    {
        MySqlCommand comando;

        public VideosDevices()
        {
            InitializeComponent();
            LlenaTipoCampana();
            llenarFranquicia();
        }

        private void llenarFranquicia()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM franquicia WHERE activo = @activo ORDER BY nombre";
            comando.Parameters.AddWithValue("@activo", "1");

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputfranquicia.DataSource = Datos.ejecutarComandoSelect(comando);
            inputfranquicia.ValueMember = "id";
            inputfranquicia.DisplayMember = "nombre";
            inputfranquicia.SelectedIndex = -1;		
        }

        private void LlenaTipoCampana()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM tipo_dispositivo ORDER BY nombre";

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputTipoCampana.DataSource = Datos.ejecutarComandoSelect(comando);
            inputTipoCampana.ValueMember = "id";
            inputTipoCampana.DisplayMember = "nombre";
            inputTipoCampana.SelectedIndex = -1;
		
        }

        private void LlenarGridCampanas()
        {
            if (String.IsNullOrEmpty(inputfranquicia.Text))
            {
                Mensajes.error("Seleccione una Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputTipoCampana.Text))
            {
                Mensajes.error("Seleccione un Tipo de Campaña");
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM campana WHERE tipo_dispositivo_id=@tipo_dispositivo_id AND franquicia_id=@franquicia_id ORDER BY id DESC";
            comando.Parameters.AddWithValue("@tipo_dispositivo_id", inputTipoCampana.SelectedValue.ToString());
            comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridCampanas.DataSource = Datos.ejecutarComandoSelect(comando);
            gridCampanas.Columns["id"].Visible=false;
            gridCampanas.Columns["fecha"].Visible = false;
		
        }

        private void LlenarGridVideosDispositivos()
        {

            if (String.IsNullOrEmpty(inputfranquicia.Text))
            {
                Mensajes.error("Seleccione una Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputTipoCampana.Text))
            {
                Mensajes.error("Seleccione un Tipo de Campaña");
                return;
            }

            if (gridCampanas.RowCount==0)
            {
                Mensajes.error("No hay videos asociados");
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT m.dispositivo_id AS Dispositivo,  COUNT(*) AS Cantidad FROM movil_video_campana mvc JOIN movil m ON mvc.movil_id = m.id WHERE campana_id=@campana_id GROUP BY mvc.movil_id";
            comando.Parameters.AddWithValue("@campana_id", gridCampanas["id",gridCampanas.CurrentRow.Index].Value.ToString());
            
            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridCantidadVideos.DataSource = Datos.ejecutarComandoSelect(comando);
            inputcantidad_dispositivos.Text = gridCantidadVideos.RowCount.ToString();

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT COUNT(*) AS cantidad FROM movil_video_campana WHERE campana_id=@campana_id GROUP BY videos_id";
            comando.Parameters.AddWithValue("@campana_id", gridCampanas["id", gridCampanas.CurrentRow.Index].Value.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            DataTable videosCantidad = Datos.ejecutarComandoSelect(comando);
            inputcantidad_videos.Text = videosCantidad.Rows.Count.ToString();		
        }

        private void button1_Click(object sender, EventArgs e)
        {           
           try
           {
                LlenarGridCampanas();                
           }
           catch
           { }            
        }

        private void gridCampanas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCampanas.RowCount==0)
            {
                return;
            }
            LlenarGridVideosDispositivos();
        }
    }
}
