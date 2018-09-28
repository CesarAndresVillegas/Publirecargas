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
    public partial class NewCampaign : Form
    {
        MySqlCommand comando;

        public NewCampaign()
        {
            InitializeComponent();
            CrearIdCampana();
            LlenarGridCampana();
            LlenarTipoDispositivo();
            inputmes.Text = DateTime.Now.ToString("MMMM");
            inputano.Value = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            llenarComboFranquicias();

            if (VGlobales.tipo_usuario.Equals("Franquicia"))
            {
                inputfranquicia_id.SelectedValue = VGlobales.franquicia_id;
                inputfranquicia_id.Enabled = false;
                inputpublicar.Enabled = false;
            }
        }

        private void llenarComboFranquicias()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM franquicia WHERE activo = @activo ORDER BY nombre";
            comando.Parameters.AddWithValue("@activo", "1");

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputfranquicia_id.DataSource = Datos.ejecutarComandoSelect(comando);
            inputfranquicia_id.ValueMember = "id";
            inputfranquicia_id.DisplayMember = "nombre";
            inputfranquicia_id.SelectedIndex = -1;
		
        }

        private void LlenarTipoDispositivo()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM tipo_dispositivo ORDER BY nombre";

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputtipo_dispositivo_id.DataSource = Datos.ejecutarComandoSelect(comando);
            inputtipo_dispositivo_id.ValueMember = "id";
            inputtipo_dispositivo_id.DisplayMember = "nombre";
            inputtipo_dispositivo_id.SelectedIndex = -1;
        }

        private void LlenarGridCampana()
        {
            if (String.IsNullOrEmpty(inputtipo_dispositivo_id.Text) || String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM campana WHERE tipo_dispositivo_id = @tipo_dispositivo_id AND franquicia_id=@franquicia_id ORDER BY id DESC";
            comando.Parameters.AddWithValue("@tipo_dispositivo_id", inputtipo_dispositivo_id.SelectedValue.ToString());
            comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia_id.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridCampanas.DataSource = Datos.ejecutarComandoSelect(comando);

            for (int i = 0; i < gridCampanas.Columns.Count; i++)
            {
                gridCampanas.Columns[i].Visible = false;
            }

            gridCampanas.Columns["id"].Visible = true;
            gridCampanas.Columns["nombre"].Visible = true;
            gridCampanas.Columns["mes"].Visible = true;
            gridCampanas.Columns["tipo_dispositivo_id"].Visible = true;
            gridCampanas.Columns["publicar"].Visible = true;
        }

        private void CrearIdCampana()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT ((ifnull(max(id),0))+1) as ID FROM campana";
            // Al ejecutar la consulta se devuelve un DataTable.
            // --
            DataTable Campana = Datos.ejecutarComandoSelect(comando);
            labelCampana.Text = Campana.Rows[0]["ID"].ToString();
        }

        private void aLMACENARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar un Nombre de Campaña");
                return;
            }

            if (String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                Mensajes.error("Debe Seleccionar una Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputtipo_dispositivo_id.Text))
            {
                Mensajes.error("Debe Seleccionar el Tipo de Dispositivo");
                return;
            }

            if (String.IsNullOrEmpty(inputmes.Text))
            {
                Mensajes.error("Debe Seleccionar el Mes");
                return;
            }

            if (String.IsNullOrEmpty(inputano.Text))
            {
                Mensajes.error("Debe Seleccionar el Año");
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM campana WHERE tipo_dispositivo_id = @tipo_dispositivo_id AND franquicia_id=@franquicia_id AND mes = @mes AND ano = @ano";
            comando.Parameters.AddWithValue("@tipo_dispositivo_id", inputtipo_dispositivo_id.SelectedValue.ToString());
            comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia_id.SelectedValue.ToString());
            comando.Parameters.AddWithValue("@mes", inputmes.Text);
            comando.Parameters.AddWithValue("@ano", inputano.Value.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            DataTable Validacion = Datos.ejecutarComandoSelect(comando);

            if (Validacion.Rows.Count>0)
            {
                Mensajes.error("Ya Existe Una Campaña Creada Para este Mes y Este Tipo de Dispositivos y esta Franquicia");
                return;
            }

            #endregion

            #region Insert

            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string nombre = inputnombre.Text;
            string mes = inputmes.Text;
            string ano = inputano.Value.ToString();
            string franquicia_id = inputfranquicia_id.SelectedValue.ToString();
            string tipo_dispositivo_id = inputtipo_dispositivo_id.SelectedValue.ToString();
            bool publicar = (bool)inputpublicar.Checked;

            if (Mensajes.confirmacion("¿Está seguro de que desea Insertar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO campana (fecha, nombre, mes, ano, franquicia_id, tipo_dispositivo_id, publicar) VALUES (@fecha, @nombre, @mes, @ano, @franquicia_id, @tipo_dispositivo_id, @publicar)";

                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@mes", mes);
                comando.Parameters.AddWithValue("@ano", ano);
                comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);
                comando.Parameters.AddWithValue("@tipo_dispositivo_id", tipo_dispositivo_id);
                comando.Parameters.AddWithValue("@publicar", publicar);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("La inserción se ha realizado correctamente.");

                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: inserción; LOS DATOS DE LA ACCIÓN SON: fecha = " + fecha + ", nombre = " + nombre + ", mes = " + mes + ", ano = " + ano + ", franquicia_id = " + franquicia_id + ", tipo_dispositivo_id = " + tipo_dispositivo_id + ", publicar = " + inputpublicar.Checked + "";
                    Datos.crearLOG(formulario, descripcion);
                    LlenarGridCampana();
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

            #endregion
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar un Nombre de Campaña");
                return;
            }

            if (gridCampanas.RowCount==0)
            {
                Mensajes.error("No Hay Datos Para Modificar");
                return;
            }

            #endregion

            #region update

            string id = gridCampanas["id",gridCampanas.CurrentRow.Index].Value.ToString();
            string nombre = inputnombre.Text;
            bool publicar = (bool)inputpublicar.Checked;

            if (Mensajes.confirmacion("¿Está seguro de que desea modificar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "UPDATE campana SET nombre=@nombre, publicar=@publicar WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@publicar", publicar);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("El registro se ha modificado correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: modificación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + nombre + ", publicar = "+ publicar +"";
                    Datos.crearLOG(formulario, descripcion);
                    LlenarGridCampana();
                }
                else
                {
                    Mensajes.error("Ha ocurrido un error al intentar modificar el registro.");
                }
            }
            catch
            {
                Mensajes.error("Ha ocurrido un error al intentar modificar el registro.");
            }

            #endregion
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (gridCampanas.RowCount==0)
            {
                Mensajes.error("No Hay Datos Para Eliminar");
                return;
            }

            #endregion

            #region delete

            string id = gridCampanas["id",gridCampanas.CurrentRow.Index].Value.ToString();

            if (Mensajes.confirmacion("¿Está seguro de que desea eliminar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM campana WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("Se ha eliminado el registro correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: eliminación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + gridCampanas["nombre", gridCampanas.CurrentRow.Index].Value.ToString() + ", mes = " + gridCampanas["mes", gridCampanas.CurrentRow.Index].Value.ToString() + ", ano = " + gridCampanas["ano", gridCampanas.CurrentRow.Index].Value.ToString() + ", franquicia_id = " + gridCampanas["franquicia_id", gridCampanas.CurrentRow.Index].Value.ToString() + ", tipo_dispositivo_id = " + gridCampanas["tipo_dispositivo_id", gridCampanas.CurrentRow.Index].Value.ToString() + "";
                    Datos.crearLOG(formulario, descripcion);
                    LlenarGridCampana();
                }
                else
                {
                    Mensajes.error("Ha ocurrido un error al intentar eliminar el registro.");
                }
            }
            catch
            {
                Mensajes.error("Ha ocurrido un error al intentar eliminar el registro.");
            }

            #endregion
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            if (Mensajes.confirmacion("Desea Iniciar una Nueva Campaña?"))
            {
                inputnombre.Text = "";
                inputmes.Text=DateTime.Now.ToString("MMMM");
                inputano.Value = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                inputfranquicia_id.SelectedIndex = -1;
                inputtipo_dispositivo_id.SelectedIndex = -1;
                inputpublicar.Checked = false;
                CrearIdCampana();
                LlenarGridCampana();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM campana WHERE id = @id";
            comando.Parameters.AddWithValue("@id", labelCampana.Text);

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            DataTable Validacion = Datos.ejecutarComandoSelect(comando);

            if (Validacion.Rows.Count==0)
            {
                Mensajes.error("Debe Almacenar la Campaña O Seleccionar una Campaña Existente");
                return;
            }

            AddVideo frm = new AddVideo(labelCampana.Text, gridCampanas["tipo_dispositivo_id", gridCampanas.CurrentRow.Index].Value.ToString(), gridCampanas["franquicia_id", gridCampanas.CurrentRow.Index].Value.ToString());
            frm.Show();
        }
               
        private void inputtipo_dispositivo_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGridCampana();
        }

        private void inputfranquicia_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGridCampana();
        }

        private void gridCampanas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCampanas.RowCount == 0)
            {
                return;
            }

            inputnombre.Text = gridCampanas["nombre", gridCampanas.CurrentRow.Index].Value.ToString();
            inputmes.Text = gridCampanas["mes", gridCampanas.CurrentRow.Index].Value.ToString();
            inputano.Value = Convert.ToInt32(gridCampanas["ano", gridCampanas.CurrentRow.Index].Value.ToString());
            inputfranquicia_id.SelectedValue = gridCampanas["franquicia_id", gridCampanas.CurrentRow.Index].Value.ToString();
            inputtipo_dispositivo_id.SelectedValue = gridCampanas["tipo_dispositivo_id", gridCampanas.CurrentRow.Index].Value.ToString();
            labelCampana.Text = gridCampanas["id", gridCampanas.CurrentRow.Index].Value.ToString();
            inputpublicar.Checked = (bool)gridCampanas["publicar", gridCampanas.CurrentRow.Index].Value;
        }

    }
}
