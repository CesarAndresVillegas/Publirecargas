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
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Specialized;
using WMPLib;
using System.Web.UI;

namespace publiRecargas.Configuration
{
    public partial class Videos : Form
    {
        MySqlCommand comando;

        public Videos()
        {
            InitializeComponent();
            LlenarGridVideos();
            LlenarClientes();
            llenarComboFranquicias();

            if (VGlobales.tipo_usuario.Equals("Franquicia"))
            {
                inputfranquicia_id.SelectedValue = VGlobales.franquicia_id;
                inputfranquicia_id.Enabled = false;
            }
        }

        private void llenarComboFranquicias()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM franquicia WHERE activo = @activo";
            comando.Parameters.AddWithValue("@activo", "1");

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputfranquicia_id.DataSource = Datos.ejecutarComandoSelect(comando);
            inputfranquicia_id.ValueMember = "id";
            inputfranquicia_id.DisplayMember = "nombre";
            inputfranquicia_id.SelectedIndex = -1;
        }

        private void LlenarClientes()
        {
            if (String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM clientes WHERE activo = @activo AND franquicia_id=@franquicia_id ORDER BY id";
            comando.Parameters.AddWithValue("@activo", "1");
            comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia_id.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputclientes_id.DataSource = Datos.ejecutarComandoSelect(comando);
            inputclientes_id.ValueMember = "id";
            inputclientes_id.DisplayMember = "nombre";
            inputclientes_id.SelectedIndex = -1;
        }

        private void LlenarGridVideos()
        {
            if (String.IsNullOrEmpty(inputclientes_id.Text))
            {
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM videos WHERE clientes_id=@clientes_id ORDER BY id";
            comando.Parameters.AddWithValue("clientes_id", inputclientes_id.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridVideos.DataSource = Datos.ejecutarComandoSelect(comando);

            for (int i = 0; i < gridVideos.Columns.Count; i++)
            {
                gridVideos.Columns[i].Visible = false;
            }

            gridVideos.Columns["id"].Visible = true;
            gridVideos.Columns["nombre"].Visible = true;
            gridVideos.Columns["duracion"].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputnombre.Text = openFileDialog1.FileName;
            }
        }

        private void aLMACENARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Seleccionar un Video");
                return;
            }

            if (String.IsNullOrEmpty(inputclientes_id.Text))
            {
                Mensajes.error("Debe Seleccionar un Cliente para el Video");
                return;
            }

            if (!Path.GetExtension(inputnombre.Text).Equals(".mp4"))
            {
                Mensajes.error("Solo Se Pueden Cargar Archivos con Formato mp4");
                return;
            }

            FileInfo infoArchivo = new FileInfo(inputnombre.Text);

            if (infoArchivo.Length > 20000000)
            {
                MessageBox.Show("Imposible subir el archivo, el limite permitido es de 20 Mb");
                return;
            }

            #endregion

            #region almacenar

            this.Cursor = Cursors.WaitCursor;

            #region post para almacenar video

            string uriString = VGlobales.rutaWeb + "/insert.php";

            var myWebClient = new ExtendedWebClient();
            myWebClient.AllowWriteStreamBuffering = false;

            myWebClient.Headers.Add("Content-Type", "binary/octet-stream");
            byte[] responseArray = myWebClient.UploadFile(uriString, "POST", inputnombre.Text);
            Mensajes.informacion(System.Text.Encoding.ASCII.GetString(responseArray));

            #endregion

            #region Insert a la bd

            if (System.Text.Encoding.ASCII.GetString(responseArray).Equals("Se ha Cargado con Exito el Archivo"))
            {
                #region consulta para saber en que numero de video sigue

                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "SELECT ((ifnull(max(id),0))+1) as ID FROM videos";
                // Al ejecutar la consulta se devuelve un DataTable.
                // --
                DataTable Campana = Datos.ejecutarComandoSelect(comando);

                #endregion

                string nombre = Path.GetFileName(inputnombre.Text);
                string ruta = VGlobales.rutaWeb + "/videos/" + Campana.Rows[0]["ID"].ToString() + Path.GetExtension(inputnombre.Text);
                string clientes_id = inputclientes_id.SelectedValue.ToString();
                WindowsMediaPlayer wmp = new WindowsMediaPlayer();
                IWMPMedia duracion = wmp.newMedia(inputnombre.Text);

                try
                {
                    //Se realiza la inserción de los datos en la base de datos
                    comando = Datos.crearComando();

                    comando.Parameters.Clear();
                    comando.CommandText = "INSERT INTO videos (nombre, ruta, clientes_id, duracion) VALUES (@nombre, @ruta, @clientes_id, @duracion)";

                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@ruta", ruta);
                    comando.Parameters.AddWithValue("@clientes_id", clientes_id);
                    comando.Parameters.AddWithValue("@duracion", duracion.duration.ToString());

                    // Ejecutar la consulta y decidir
                    // True: caso exitoso
                    // false: Error.
                    if (Datos.ejecutarComando(comando))
                    {
                        // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                        Mensajes.informacion("La inserción se ha realizado correctamente.");

                        string formulario = this.Name;
                        string descripcion = "ACCIÓN: inserción; LOS DATOS DE LA ACCIÓN SON: nombre = " + nombre + ", ruta = " + ruta + ", clientes_id = " + clientes_id + ", duracion = "+ duracion.duration.ToString() +"";
                        Datos.crearLOG(formulario, descripcion);
                        LlenarGridVideos();
                    }
                    else
                    {
                        Mensajes.error("Ha ocurrido un error al intentar realizar la inserción.");
                    }
                }
                catch
                {
                    Mensajes.error("Ha ocurrido un error al intentar realizar la inserción.");
                }
            }

            #endregion

            else
            {
                Mensajes.informacion(System.Text.Encoding.ASCII.GetString(responseArray));
                return;
            }

            this.Cursor = Cursors.Default;

            #endregion
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (gridVideos.RowCount == 0)
            {
                Mensajes.error("No Hay Videos Para Eliminar");
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM movil_video_campana WHERE videos_id = @videos_id";
            comando.Parameters.AddWithValue("@videos_id", gridVideos["id", gridVideos.CurrentRow.Index].Value.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            DataTable mvc = Datos.ejecutarComandoSelect(comando);

            if (mvc.Rows.Count > 0)
            {
                Mensajes.error("El Video ya Se encuenta Almacenado en Una O Varias Campañas, Imposible Eliminar");
                return;
            }


            #endregion

            #region delete

            this.Cursor = Cursors.WaitCursor;

            #region post para eliminar video

            string URL = VGlobales.rutaWeb + "/delete.php";
            WebClient webClient = new WebClient();

            NameValueCollection formData = new NameValueCollection();
            formData["id"] = gridVideos["id", gridVideos.CurrentRow.Index].Value.ToString();

            byte[] responseBytes = webClient.UploadValues(URL, "POST", formData);
            string responsefromserver = Encoding.UTF8.GetString(responseBytes);
            webClient.Dispose();

            #endregion

            #region delete a la bd

            if (responsefromserver.Equals("Datos Eliminados Correctamente"))
            {
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM videos WHERE id = @id";
                comando.Parameters.AddWithValue("@id", gridVideos["id", gridVideos.CurrentRow.Index].Value.ToString());

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: video eliminado; LOS DATOS DE LA ACCIÓN SON: id = " + gridVideos["id", gridVideos.CurrentRow.Index].Value.ToString() + ", nombre = " + gridVideos["nombre", gridVideos.CurrentRow.Index].Value.ToString() + ", ruta = " + gridVideos["ruta", gridVideos.CurrentRow.Index].Value.ToString() + ", clientes_id = " + gridVideos["clientes_id", gridVideos.CurrentRow.Index].Value.ToString() + "";
                    Datos.crearLOG(formulario, descripcion);
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("Video Eliminado Correctamente");
                    LlenarGridVideos();
                }
                else
                { Mensajes.error("Mensaje de error."); }

            }

            #endregion

            else
            {
                Mensajes.informacion(System.Text.Encoding.ASCII.ToString());
                this.Cursor = Cursors.Default;
                return;
            }

            this.Cursor = Cursors.Default;

            #endregion
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void limpiarPantalla()
        {
            inputnombre.Text = "";
            inputclientes_id.SelectedIndex = -1;
        }

        public class ExtendedWebClient : WebClient
        {
            public int Timeout { get; set; }
            public new bool AllowWriteStreamBuffering { get; set; }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                if (request != null)
                {
                    request.Timeout = Timeout;
                    var httpRequest = request as HttpWebRequest;
                    if (httpRequest != null)
                    {
                        httpRequest.AllowWriteStreamBuffering = AllowWriteStreamBuffering;
                    }
                }
                return request;
            }

            public ExtendedWebClient()
            {
                Timeout = 100000000; // the standard HTTP Request Timeout default
            }
        }

        private void inputfranquicia_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarClientes();
        }

        private void inputclientes_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGridVideos();
        }

    }
}
