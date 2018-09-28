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

namespace publiRecargas.Configuration
{
    public partial class Device : Form
    {
        MySqlCommand comando;

        public Device()
        {
            InitializeComponent();
            LlenarGridDevices();
            LlenarTipoDispositivo();
            llenarComboFranquicias();

            if (VGlobales.tipo_usuario.Equals("Franquicia"))
            {
                inputfranquicia_id.SelectedValue = VGlobales.franquicia_id;
                inputfranquicia_id.Enabled = false;
                aLMACENARToolStripMenuItem.Enabled = false;
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

        private void LlenarGridDevices()
        {
            if (String.IsNullOrEmpty(inputtipo_dispositivo_id.Text) || String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                return;
            }
            
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM movil WHERE tipo_dispositivo_id=@tipo_dispositivo_id AND franquicia_id=@franquicia_id ORDER BY id";
            comando.Parameters.AddWithValue("tipo_dispositivo_id", inputtipo_dispositivo_id.SelectedValue.ToString());
            comando.Parameters.AddWithValue("franquicia_id", inputfranquicia_id.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridDevices.DataSource = Datos.ejecutarComandoSelect(comando);

            for (int i = 0; i < gridDevices.Columns.Count; i++)
            {
                gridDevices.Columns[i].Visible = false;
            }

            gridDevices.Columns["id"].Visible = true;
            gridDevices.Columns["nombre"].Visible = true;
            gridDevices.Columns["dispositivo_id"].Visible = true;		
        }

        private void aLMACENARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputtipo_dispositivo_id.Text.Equals("Kiosco"))
            {
                #region validaciones                

                if (String.IsNullOrEmpty(inputtipo_dispositivo_id.Text))
                {
                    Mensajes.error("Debe Seleccionar el Tipo de Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputdispositivo_id.Text))
                {
                    Mensajes.error("Debe Ingresar un Identificador para el Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputfranquicia_id.Text))
                {
                    Mensajes.error("Debe Seleccionar una Franquicia");
                    return;
                }

                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "SELECT id FROM movil WHERE dispositivo_id = @dispositivo_id";
                comando.Parameters.AddWithValue("@dispositivo_id", inputdispositivo_id.Text);

                // Al ejecutar la consulta se devuelve un DataTable.
                // -- 
                DataTable validacion = Datos.ejecutarComandoSelect(comando);
                if (validacion.Rows.Count > 0)
                {
                    Mensajes.error("El id del Dispositivo ya Existe, Imposible Continuar");
                    return;
                }

                #endregion
            }
            else
            {
                #region validaciones
                

                if (String.IsNullOrEmpty(inputtipo_dispositivo_id.Text))
                {
                    Mensajes.error("Debe Seleccionar el Tipo de Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputdispositivo_id.Text))
                {
                    Mensajes.error("Debe Ingresar un Identificador para el Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputfranquicia_id.Text))
                {
                    Mensajes.error("Debe Seleccionar una Franquicia");
                    return;
                }

                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "SELECT id FROM movil WHERE dispositivo_id = @dispositivo_id";
                comando.Parameters.AddWithValue("@dispositivo_id", inputdispositivo_id.Text);

                // Al ejecutar la consulta se devuelve un DataTable.
                // -- 
                DataTable validacion = Datos.ejecutarComandoSelect(comando);
                if (validacion.Rows.Count > 0)
                {
                    Mensajes.error("El id del Dispositivo ya Existe, Imposible Continuar");
                    return;
                }

                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "SELECT id FROM movil WHERE placa = @placa";
                comando.Parameters.AddWithValue("@placa", inputplaca.Text);

                // Al ejecutar la consulta se devuelve un DataTable.
                // -- 
                validacion = Datos.ejecutarComandoSelect(comando);
                if (validacion.Rows.Count > 0)
                {
                    Mensajes.error("La Placa ya Existe, Imposible Continuar");
                    return;
                }

                #endregion
            }            

            #region insert

            string nombre = inputnombre.Text;
            string documento = inputdocumento.Text;
            string fecha_soat = inputfecha_soat.Value.ToString("yyyy-MM-dd");
            string fecha_tecnomecanica = inputfecha_tecnomecanica.Value.ToString("yyyy-MM-dd");
            string numero_vehiculo = inputnumero_vehiculo.Text;
            string placa = inputplaca.Text;
            string direccion = inputdireccion.Text;
            string telefono = inputtelefono.Text;
            string dispositivo_id = inputdispositivo_id.Text;
            string franquicia_id = inputfranquicia_id.SelectedValue.ToString();
            string tipo_dispositivo_id = inputtipo_dispositivo_id.SelectedValue.ToString();
            bool activo = inputactivo.Checked;

            if (Mensajes.confirmacion("¿Está seguro de que desea Insertar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO movil (nombre, documento, fecha_soat, fecha_tecnomecanica, numero_vehiculo, placa, direccion, telefono, dispositivo_id, franquicia_id, tipo_dispositivo_id, activo) VALUES (@nombre, @documento, @fecha_soat, @fecha_tecnomecanica, @numero_vehiculo, @placa, @direccion, @telefono, @dispositivo_id, @franquicia_id, @tipo_dispositivo_id, @activo)";

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@fecha_soat", fecha_soat);
                comando.Parameters.AddWithValue("@fecha_tecnomecanica", fecha_tecnomecanica);
                comando.Parameters.AddWithValue("@numero_vehiculo", numero_vehiculo);
                comando.Parameters.AddWithValue("@placa", placa);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@dispositivo_id", dispositivo_id);
                comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);
                comando.Parameters.AddWithValue("@tipo_dispositivo_id", tipo_dispositivo_id);
                comando.Parameters.AddWithValue("@activo", activo);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("La inserción se ha realizado correctamente.");

                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: inserción; LOS DATOS DE LA ACCIÓN SON: nombre = " + nombre + ", documento = " + documento + ", fecha_soat = " + fecha_soat + ", fecha_tecnomecanica = " + fecha_tecnomecanica + ", numero_vehiculo = " + numero_vehiculo + ", placa = " + placa + ", direccion = " + direccion + ", telefono = " + telefono + ", dispositivo_id = " + dispositivo_id + ", franquicia_id = " + franquicia_id + ", tipo_dispositivo_id = " + tipo_dispositivo_id + ", activo=" + activo + "";
                    Datos.crearLOG(formulario, descripcion);
                    LlenarGridDevices();
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
            if (inputtipo_dispositivo_id.Text.Equals("Kiosco"))
            {
                #region validaciones

                if (String.IsNullOrEmpty(inputtipo_dispositivo_id.Text))
                {
                    Mensajes.error("Debe Seleccionar el Tipo de Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputdispositivo_id.Text))
                {
                    Mensajes.error("Debe Ingresar un Identificador para el Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputfranquicia_id.Text))
                {
                    Mensajes.error("Debe Seleccionar una Franquicia");
                    return;
                }

                if (gridDevices.RowCount == 0)
                {
                    Mensajes.error("No Hay Registros Para Modificar");
                    return;
                }

                #endregion
            }
            else
            {
                #region validaciones

                if (String.IsNullOrEmpty(inputtipo_dispositivo_id.Text))
                {
                    Mensajes.error("Debe Seleccionar el Tipo de Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputdispositivo_id.Text))
                {
                    Mensajes.error("Debe Ingresar un Identificador para el Dispositivo");
                    return;
                }

                if (String.IsNullOrEmpty(inputfranquicia_id.Text))
                {
                    Mensajes.error("Debe Seleccionar una Franquicia");
                    return;
                }

                if (gridDevices.RowCount == 0)
                {
                    Mensajes.error("No Hay Registros Para Modificar");
                    return;
                }

                #endregion
            }           

            #region update

            string id = gridDevices["id",gridDevices.CurrentRow.Index].Value.ToString();
            string nombre = inputnombre.Text;
            string documento = inputdocumento.Text;
            string fecha_soat = inputfecha_soat.Value.ToString("yyyy-MM-dd");
            string fecha_tecnomecanica = inputfecha_tecnomecanica.Value.ToString("yyyy-MM-dd");
            string numero_vehiculo = inputnumero_vehiculo.Text;
            string placa = inputplaca.Text;
            string direccion = inputdireccion.Text;
            string telefono = inputtelefono.Text;
            string dispositivo_id = inputdispositivo_id.Text;
            string franquicia_id = inputfranquicia_id.SelectedValue.ToString();
            string tipo_dispositivo_id = inputtipo_dispositivo_id.SelectedValue.ToString();
            bool activo = inputactivo.Checked;

            if (Mensajes.confirmacion("¿Está seguro de que desea modificar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "UPDATE movil SET nombre=@nombre, documento=@documento, fecha_soat=@fecha_soat, fecha_tecnomecanica=@fecha_tecnomecanica, numero_vehiculo=@numero_vehiculo, placa=@placa, direccion=@direccion, telefono=@telefono, dispositivo_id=@dispositivo_id, franquicia_id=@franquicia_id, tipo_dispositivo_id=@tipo_dispositivo_id, activo = @activo WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@fecha_soat", fecha_soat);
                comando.Parameters.AddWithValue("@fecha_tecnomecanica", fecha_tecnomecanica);
                comando.Parameters.AddWithValue("@numero_vehiculo", numero_vehiculo);
                comando.Parameters.AddWithValue("@placa", placa);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@dispositivo_id", dispositivo_id);
                comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);
                comando.Parameters.AddWithValue("@tipo_dispositivo_id", tipo_dispositivo_id);
                comando.Parameters.AddWithValue("@activo", activo);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("El registro se ha modificado correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: modificación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + nombre + ", documento = " + documento + ", fecha_soat = " + fecha_soat + ", fecha_tecnomecanica = " + fecha_tecnomecanica + ", numero_vehiculo = " + numero_vehiculo + ", placa = " + placa + ", direccion = " + direccion + ", telefono = " + telefono + ", dispositivo_id = " + dispositivo_id + ", franquicia_id = " + franquicia_id + ", tipo_dispositivo_id = " + tipo_dispositivo_id + ", activo = " + activo + "";
                    Datos.crearLOG(formulario, descripcion);
                    LlenarGridDevices();
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

            if (gridDevices.RowCount==0)
            {
                Mensajes.error("No Hay Registros Para Eliminar");
                return;
            }

            #endregion

            #region delete

            string id = gridDevices["id",gridDevices.CurrentRow.Index].Value.ToString();

            if (Mensajes.confirmacion("¿Está seguro de que desea eliminar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM movil WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("Se ha eliminado el registro correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: eliminación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + gridDevices["nombre", gridDevices.CurrentRow.Index].Value.ToString() + ", documento = " + gridDevices["documento", gridDevices.CurrentRow.Index].Value.ToString() + ", fecha_soat = " + gridDevices["fecha_soat", gridDevices.CurrentRow.Index].Value.ToString() + ", fecha_tecnomecanica = " + gridDevices["fecha_tecnomecanica", gridDevices.CurrentRow.Index].Value.ToString() + ", numero_vehiculo = " + gridDevices["numero_vehiculo", gridDevices.CurrentRow.Index].Value.ToString() + ", placa = " + gridDevices["placa", gridDevices.CurrentRow.Index].Value.ToString() + ", direccion = " + gridDevices["direccion", gridDevices.CurrentRow.Index].Value.ToString() + ", telefono = " + gridDevices["telefono", gridDevices.CurrentRow.Index].Value.ToString() + ", dispositivo_id = " + gridDevices["dispositivo_id", gridDevices.CurrentRow.Index].Value.ToString() + ", franquicia_id = " + gridDevices["franquicia_id", gridDevices.CurrentRow.Index].Value.ToString() + ", tipo_dispositivo_id = " + gridDevices["tipo_dispositivo_id", gridDevices.CurrentRow.Index].Value.ToString() + "";
                    Datos.crearLOG(formulario, descripcion);
                    LlenarGridDevices();
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

        private void gridDevices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDevices.RowCount==0)
            {
                return;
            }

            inputnombre.Text = gridDevices["nombre", gridDevices.CurrentRow.Index].Value.ToString();
            inputdocumento.Text = gridDevices["documento", gridDevices.CurrentRow.Index].Value.ToString();
            inputfecha_soat.Text = gridDevices["fecha_soat", gridDevices.CurrentRow.Index].Value.ToString();
            inputfecha_tecnomecanica.Text = gridDevices["fecha_tecnomecanica", gridDevices.CurrentRow.Index].Value.ToString();
            inputnumero_vehiculo.Text = gridDevices["numero_vehiculo", gridDevices.CurrentRow.Index].Value.ToString();
            inputplaca.Text = gridDevices["placa", gridDevices.CurrentRow.Index].Value.ToString();
            inputdireccion.Text = gridDevices["direccion", gridDevices.CurrentRow.Index].Value.ToString();
            inputtelefono.Text = gridDevices["telefono", gridDevices.CurrentRow.Index].Value.ToString();
            inputdispositivo_id.Text = gridDevices["dispositivo_id", gridDevices.CurrentRow.Index].Value.ToString();
            inputfranquicia_id.SelectedValue = gridDevices["franquicia_id", gridDevices.CurrentRow.Index].Value.ToString();
            inputtipo_dispositivo_id.SelectedValue = gridDevices["tipo_dispositivo_id", gridDevices.CurrentRow.Index].Value.ToString();
            inputactivo.Checked = (bool)gridDevices["activo", gridDevices.CurrentRow.Index].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(inputtipo_dispositivo_id.Text)) && (String.IsNullOrEmpty(inputfranquicia_id.Text)))
            {
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "SELECT * FROM movil WHERE tipo_dispositivo_id=@tipo_dispositivo_id AND franquicia_id=@franquicia_id ORDER BY id";
                comando.Parameters.AddWithValue("@tipo_dispositivo_id", inputtipo_dispositivo_id.SelectedValue.ToString());
                comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia_id.SelectedValue.ToString());

                // Al ejecutar la consulta se devuelve un DataTable.
                // -- 
                gridDevices.DataSource = Datos.ejecutarComandoSelect(comando);

                for (int i = 0; i < gridDevices.Columns.Count; i++)
                {
                    gridDevices.Columns[i].Visible = false;
                }

                gridDevices.Columns["id"].Visible = true;
                gridDevices.Columns["nombre"].Visible = true;
            }
            else
            {
                LlenarGridDevices();
            }
                        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputtipo_dispositivo_id.SelectedValue = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(inputdispositivo_id.Text))
            {
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "SELECT * FROM movil WHERE dispositivo_id=@dispositivo_id ORDER BY id";
                comando.Parameters.AddWithValue("@dispositivo_id", inputdispositivo_id.Text);

                // Al ejecutar la consulta se devuelve un DataTable.
                // -- 
                gridDevices.DataSource = Datos.ejecutarComandoSelect(comando);

                for (int i = 0; i < gridDevices.Columns.Count; i++)
                {
                    gridDevices.Columns[i].Visible = false;
                }

                gridDevices.Columns["id"].Visible = true;
                gridDevices.Columns["nombre"].Visible = true;
            }
            else
            {
                LlenarGridDevices();
            }

        }

        private void inputtipo_dispositivo_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputtipo_dispositivo_id.Text.Equals("Kiosco"))
            {
                inputfecha_soat.Visible = false;
                inputfecha_tecnomecanica.Visible = false;
                inputnumero_vehiculo.Visible = false;
                inputplaca.Visible = false;
            }
            else
            {
                inputfecha_soat.Visible = true;
                inputfecha_tecnomecanica.Visible = true;
                inputnumero_vehiculo.Visible = true;
                inputplaca.Visible = true;
            }

            LlenarGridDevices();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void limpiarPantalla()
        {
            inputnombre.Text = "";
            inputdocumento.Text = "";
            inputtipo_dispositivo_id.SelectedIndex = -1;
            inputfecha_soat.Value = DateTime.Now;
            inputfecha_tecnomecanica.Value = DateTime.Now;
            inputnumero_vehiculo.Text = "";
            inputplaca.Text = "";
            inputdireccion.Text = "";
            inputtelefono.Text = "";
            inputdispositivo_id.Text = "";
            inputfranquicia_id.SelectedIndex = -1;
            inputactivo.Checked = true;
            gridDevices.DataSource = null;
        }

        private void inputfranquicia_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGridDevices();
        }

    }
}
