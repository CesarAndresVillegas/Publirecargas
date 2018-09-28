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

namespace publiRecargas.Campaign
{
    public partial class AddVideo : Form
    {
        MySqlCommand comando;
        string idCampana;
        string tipoDispositivo;
        string franquicia_id;

        public AddVideo(string idCampana, string tipoDispositivo, string franquicia_id)
        {
            InitializeComponent();
            this.idCampana = idCampana;
            this.tipoDispositivo = tipoDispositivo;
            this.franquicia_id = franquicia_id;

            LlenarVideosCampana();
            LlenarClientes();
            LlenarMovilesDisponibles();
        }

        private void LlenarMovilesDisponibles()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT COUNT(*) AS Cant FROM movil WHERE activo = @activo AND tipo_dispositivo_id = @tipo_dispositivo_id AND franquicia_id=@franquicia_id";
            comando.Parameters.AddWithValue("@activo", "1");
            comando.Parameters.AddWithValue("@tipo_dispositivo_id", tipoDispositivo);
            comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            DataTable Moviles = Datos.ejecutarComandoSelect(comando);

            inputmoviles.Text = Moviles.Rows[0]["Cant"].ToString();	
        }

        private void LlenarClientes()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM clientes WHERE activo = @activo AND franquicia_id=@franquicia_id ORDER BY nombre";
            comando.Parameters.AddWithValue("@activo", "1");
            comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputclientes_id.DataSource = Datos.ejecutarComandoSelect(comando);
            inputclientes_id.ValueMember = "id";
            inputclientes_id.DisplayMember = "nombre";
            inputclientes_id.SelectedIndex = -1;
		
        }

        private void LlenarVideosCampana()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM movil_video_campana mvc JOIN videos v ON mvc.videos_id = v.id JOIN clientes c ON v.clientes_id  = c.id JOIN movil m ON mvc.movil_id = m.id WHERE campana_id = @campana_id GROUP BY videos_id ORDER BY mvc.id";
            comando.Parameters.AddWithValue("@campana_id", idCampana);

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridVideosCampana.DataSource = Datos.ejecutarComandoSelect(comando);

            inputvideos.Text = gridVideosCampana.RowCount.ToString();

            for (int i = 0; i < gridVideosCampana.Columns.Count; i++)
            {
                gridVideosCampana.Columns[i].Visible = false;
            }

            gridVideosCampana.Columns["id"].Visible = true;
            gridVideosCampana.Columns["nombre"].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (string.IsNullOrEmpty(inputclientes_id.Text))
            {
                Mensajes.error("Debe Seleccionar un Cliente");
                return;
            }

            if (inputCantidadMoviles.Value.Equals("0"))
            {
                Mensajes.error("La Cantidad de Móviles no Puede Ser Igual a Cero");
                return;
            }

            if (gridVideosCliente.RowCount==0)
            {
                Mensajes.error("El Cliente No Tiene Videos Disponibles");
                return;
            }

            if (inputCantidadMoviles.Value>Convert.ToInt32(inputmoviles.Text))
            {
                Mensajes.error("La Cantidad de Móviles Requerida e Mayor que la Cantidad Disponible");
                return;
            }

            for (int i = 0; i < gridVideosCampana.RowCount; i++)
            {
                if (gridVideosCliente["id",gridVideosCliente.CurrentRow.Index].Value.ToString().Equals(gridVideosCampana["videos_id",i].Value.ToString()))
                {
                    Mensajes.error("El video ya se encuentra agregado a la campaña");
                    return;
                }
            }

            #endregion

            #region Agregar Video
            
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT id FROM movil WHERE activo = @activo AND franquicia_id = @franquicia_id AND tipo_dispositivo_id = @tipo_dispositivo_id";
            comando.Parameters.AddWithValue("@activo", "1");
            comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);
            comando.Parameters.AddWithValue("@tipo_dispositivo_id", tipoDispositivo);

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            DataTable Moviles = Datos.ejecutarComandoSelect(comando);

            for (int i = 0; i < inputCantidadMoviles.Value; i++)
            {
                #region movil video campana

                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO movil_video_campana (movil_id, campana_id, videos_id) VALUES (@movil_id, @campana_id, @videos_id)";
                comando.Parameters.AddWithValue("@movil_id", Moviles.Rows[i]["id"].ToString());
                comando.Parameters.AddWithValue("@campana_id", idCampana);
                comando.Parameters.AddWithValue("@videos_id", gridVideosCliente["id", gridVideosCliente.CurrentRow.Index].Value.ToString());

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.                    
                }
                else
                { Mensajes.error("Mensaje de error."); return; }

                #endregion
            }

            Mensajes.informacion("Videos Agregados con Éxito");

            LlenarVideosCampana();
	
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (gridVideosCampana.RowCount==0)
            {
                Mensajes.error("No Hay Videos Asociados a la Campaña");
                return;
            }

            #endregion

            #region delete

            if (Mensajes.confirmacion("Desea Sacar el Video de la Campaña"))
            {
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM movil_video_campana WHERE id = @id";
                comando.Parameters.AddWithValue("@id", gridVideosCampana["id",gridVideosCampana.CurrentRow.Index].Value.ToString());

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("Mensaje confirmación.");
                }
                else
                { Mensajes.error("Mensaje de error."); }                
            }

            #endregion
        }

        private void inputclientes_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputclientes_id.Text))
            {
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "SELECT * FROM videos WHERE clientes_id = @clientes_id ORDER BY nombre";
                comando.Parameters.AddWithValue("@clientes_id", inputclientes_id.SelectedValue.ToString());

                // Al ejecutar la consulta se devuelve un DataTable.
                // -- 
                gridVideosCliente.DataSource = Datos.ejecutarComandoSelect(comando);
                gridVideosCliente.Columns["ruta"].Visible = false;
                gridVideosCliente.Columns["clientes_id"].Visible = false;
            }
        }
    }
}
