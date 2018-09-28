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
    public partial class Clients : Form
    {
        MySqlCommand comando;

        public Clients()
        {
            InitializeComponent();
            gridClientes();
            llenarComboFranquicia();

            if (VGlobales.tipo_usuario.Equals("Franquicia"))
            {
                inputfranquicia_id.SelectedValue = VGlobales.franquicia_id;
                inputfranquicia_id.Enabled = false;
            }
        }

        private void llenarComboFranquicia()
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

        private void gridClientes()
        {
            if (String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM clientes WHERE franquicia_id=@franquicia_id ORDER BY id";
            comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia_id.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            historialClientes.DataSource = Datos.ejecutarComandoSelect(comando);

            for (int i = 0; i < historialClientes.Columns.Count; i++)
            {
                historialClientes.Columns[i].Visible=false;
            }

            historialClientes.Columns["nit"].Visible=true;
            historialClientes.Columns["nombre"].Visible = true;
            historialClientes.Columns["activo"].Visible = true;

        }

        private void aLMACENARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (String.IsNullOrEmpty(inputnit.Text))
            {
                Mensajes.error("Debe Ingresar el Nit de la Entidad");
                return;
            }

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre de la Entidad");
                return;
            }

            if (String.IsNullOrEmpty(inputtelefono.Text))
            {
                Mensajes.error("Debe Ingresar el Teléfono de la Entidad");
                return;
            }

            if (String.IsNullOrEmpty(inputdireccion.Text))
            {
                Mensajes.error("Debe Ingresar la Dirección de la Entidad");
                return;
            }

            if (String.IsNullOrEmpty(inputcontacto.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre de la Persona de Contaco");
                return;
            }

            if (String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                Mensajes.error("Debe Seleccionar una Franquicia");
                return;
            }

            #endregion

            #region insert

            string nit = inputnit.Text;
            string nombre = inputnombre.Text;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            bool activo = inputactivo.Checked;
            string direccion = inputdireccion.Text;
            string telefono = inputtelefono.Text;
            string contacto = inputcontacto.Text;
            string franquicia_id = inputfranquicia_id.SelectedValue.ToString();

            if (Mensajes.confirmacion("¿Está seguro de que desea Insertar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO clientes (nit, nombre, fecha, activo, direccion, telefono, contacto, franquicia_id) VALUES (@nit, @nombre, @fecha, @activo, @direccion, @telefono, @contacto, @franquicia_id)";

                comando.Parameters.AddWithValue("@nit", nit);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@activo", activo);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@contacto", contacto);
                comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("La inserción se ha realizado correctamente.");

                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: inserción; LOS DATOS DE LA ACCIÓN SON: nit = " + nit + ", nombre = " + nombre + ", fecha = " + fecha + ", activo = " + activo + ", direccion = " + direccion + ", telefono = " + telefono + ", contacto = " + contacto + ", franquicia_id = " + franquicia_id + "";
                    Datos.crearLOG(formulario, descripcion);
                    gridClientes();
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

            if (String.IsNullOrEmpty(inputnit.Text))
            {
                Mensajes.error("Debe Ingresar el Nit de la Entidad");
                return;
            }

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre de la Entidad");
                return;
            }

            if (String.IsNullOrEmpty(inputtelefono.Text))
            {
                Mensajes.error("Debe Ingresar el Teléfono de la Entidad");
                return;
            }

            if (String.IsNullOrEmpty(inputdireccion.Text))
            {
                Mensajes.error("Debe Ingresar la Dirección de la Entidad");
                return;
            }

            if (historialClientes.RowCount==0)
            {
                Mensajes.error("No Hay Clientes Registrados para Modificar");
                return;
            }

            if (String.IsNullOrEmpty(inputcontacto.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre de la Persona de Contaco");
                return;
            }

            if (String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                Mensajes.error("Debe Seleccionar una Franquicia");
                return;
            }

            #endregion

            #region update

            string id = historialClientes["id", historialClientes.CurrentRow.Index].Value.ToString();
            string nit = inputnit.Text;
            string nombre = inputnombre.Text;
            bool activo = inputactivo.Checked;
            string direccion = inputdireccion.Text;
            string telefono = inputtelefono.Text;
            string contacto = inputcontacto.Text;
            string franquicia_id = inputfranquicia_id.Text;

            if (Mensajes.confirmacion("¿Está seguro de que desea modificar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "UPDATE clientes SET nit=@nit, nombre=@nombre, activo=@activo, direccion=@direccion, telefono=@telefono, contacto=@contacto, franquicia_id=@franquicia_id WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nit", nit);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@activo", activo);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@contacto", contacto);
                comando.Parameters.AddWithValue("@franquicia_id", franquicia_id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("El registro se ha modificado correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: modificación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nit = " + nit + ", nombre = " + nombre + ", activo = " + activo + ", direccion = " + direccion + ", telefono = " + telefono + ", contacto = " + contacto + ", franquicia_id = " + franquicia_id + "";
                    Datos.crearLOG(formulario, descripcion);
                    gridClientes();
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
            #region validacione

            if (historialClientes.RowCount==0)
            {
                Mensajes.error("No Hay Datos para Eliminar");
                return;
                
            }

            #endregion

            #region delete

            string id = historialClientes["id",historialClientes.CurrentRow.Index].Value.ToString();

            if (Mensajes.confirmacion("¿Está seguro de que desea eliminar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM clientes WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("Se ha eliminado el registro correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: eliminación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nit = " + historialClientes["id", historialClientes.CurrentRow.Index].Value.ToString() + ", nombre = " + historialClientes["nombre", historialClientes.CurrentRow.Index].Value.ToString() + ", fecha = " + historialClientes["fecha", historialClientes.CurrentRow.Index].Value.ToString() + ", activo = " + historialClientes["activo", historialClientes.CurrentRow.Index].Value.ToString() + ", direccion = " + historialClientes["direccion", historialClientes.CurrentRow.Index].Value.ToString() + ", telefono = " + historialClientes["telefono", historialClientes.CurrentRow.Index].Value.ToString() + ", contacto= " + historialClientes["contacto", historialClientes.CurrentRow.Index].Value.ToString() + ", franquicia_id = " + historialClientes["franquicia_id", historialClientes.CurrentRow.Index].Value.ToString() + "";
                    Datos.crearLOG(formulario, descripcion);
                    gridClientes();
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

        private void historialClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (historialClientes.RowCount==0)
            {
                return;
            }

            inputnit.Text = historialClientes["nit", historialClientes.CurrentRow.Index].Value.ToString();
            inputnombre.Text = historialClientes["nombre", historialClientes.CurrentRow.Index].Value.ToString();
            inputactivo.Checked = (bool)historialClientes["activo", historialClientes.CurrentRow.Index].Value;
            inputdireccion.Text = historialClientes["direccion", historialClientes.CurrentRow.Index].Value.ToString();
            inputtelefono.Text = historialClientes["telefono", historialClientes.CurrentRow.Index].Value.ToString();
            inputcontacto.Text = historialClientes["contacto", historialClientes.CurrentRow.Index].Value.ToString();
            inputfranquicia_id.SelectedValue = historialClientes["franquicia_id", historialClientes.CurrentRow.Index].Value.ToString();

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void limpiarPantalla()
        {
            inputnit.Text = "";
            inputnombre.Text = "";
            inputactivo.Checked = true;
            inputdireccion.Text = "";
            inputtelefono.Text = "";
            inputcontacto.Text = "";
            inputfranquicia_id.SelectedValue = -1;
        }

        private void inputfranquicia_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                gridClientes();
            }
        }
        
    }
}
