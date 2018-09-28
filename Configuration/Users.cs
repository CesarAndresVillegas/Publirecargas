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
    public partial class Users : Form
    {
        MySqlCommand comando;

        public Users()
        {
            InitializeComponent();
            llenarUsers();
            llenarComboFranquicia();
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

        private void llenarUsers()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM users ORDER BY id";

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridUsers.DataSource = Datos.ejecutarComandoSelect(comando);

            for (int i = 0; i < gridUsers.Columns.Count; i++)
            {
                gridUsers.Columns[i].Visible = false;
            }

            gridUsers.Columns["nombre"].Visible = true;
            gridUsers.Columns["documento"].Visible = true;
            gridUsers.Columns["tipo"].Visible = true;		
        }

        private void aLMACENARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validación

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre Completo del Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputdocumento.Text))
            {
                Mensajes.error("Debe Ingresar el Documento del Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputtipo.Text))
            {
                Mensajes.error("Debe Seleccionar el Tipo de Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputuser.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre de Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputpass.Text))
            {
                Mensajes.error("Debe Ingresar el Password");
                return;
            }

            if (String.IsNullOrEmpty(inputpass2.Text))
            {
                Mensajes.error("Debe Confirmar el Password");
                return;
            }

            if (!inputpass.Text.Equals(inputpass2.Text))
            {
                Mensajes.error("El Password no Coincide con la Confirmación");
                return;
            }

            if (inputtipo.Text.Equals("Franquicia") && String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                Mensajes.error("Seleccione una Franquicia");
                return;
            }

            #endregion

            #region Insert

            string nombre = inputnombre.Text;
            string user = inputuser.Text;
            string pass = inputpass.Text;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string documento = inputdocumento.Text;
            string tipo = inputtipo.Text;
            //string franquicia_id = inputfranquicia_id.Text;

            if (Mensajes.confirmacion("¿Está seguro de que desea Insertar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO users (nombre, user, pass, fecha, documento, tipo, franquicia_id) VALUES (@nombre, @user, @pass, @fecha, @documento, @tipo, @franquicia_id)";

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@user", user);
                comando.Parameters.AddWithValue("@pass", pass);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia_id.SelectedValue == null ? null : inputfranquicia_id.SelectedValue.ToString());
                
                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("La inserción se ha realizado correctamente.");

                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: inserción; LOS DATOS DE LA ACCIÓN SON: nombre = " + nombre + ", user = " + user + ", pass = " + pass + ", fecha = " + fecha + ", documento = " + documento + ", tipo = " + tipo + "";
                    Datos.crearLOG(formulario, descripcion);
                    llenarUsers();
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
            #region validación

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre Completo del Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputdocumento.Text))
            {
                Mensajes.error("Debe Ingresar el Documento del Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputtipo.Text))
            {
                Mensajes.error("Debe Seleccionar el Tipo de Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputuser.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre de Usuario");
                return;
            }

            if (String.IsNullOrEmpty(inputpass.Text))
            {
                Mensajes.error("Debe Ingresar el Password");
                return;
            }

            if (String.IsNullOrEmpty(inputpass2.Text))
            {
                Mensajes.error("Debe Confirmar el Password");
                return;
            }

            if (!inputpass.Text.Equals(inputpass2.Text))
            {
                Mensajes.error("El Password no Coincide con la Confirmación");
                return;
            }

            if (gridUsers.RowCount==0)
            {
                Mensajes.error("No Hay Datos Para Modificar");
                return;
            }

            if (inputtipo.Text.Equals("Franquicia") && String.IsNullOrEmpty(inputfranquicia_id.Text))
            {
                Mensajes.error("Seleccione una Franquicia");
                return;
            }

            #endregion

            #region update

            string id = gridUsers["id", gridUsers.CurrentRow.Index].Value.ToString();
            string nombre = inputnombre.Text;
            string user = inputuser.Text;
            string pass = inputpass.Text;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string documento = inputdocumento.Text;
            string tipo = inputtipo.Text;
            //string franquicia_id = inputfranquicia_id.Text;

            if (Mensajes.confirmacion("¿Está seguro de que desea modificar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "UPDATE users SET nombre=@nombre, user=@user, pass=@pass, fecha=@fecha, documento=@documento, tipo=@tipo, franquicia_id=@franquicia_id WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@user", user);
                comando.Parameters.AddWithValue("@pass", pass);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@documento", documento);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@franquicia_id", inputfranquicia_id.SelectedValue == null ? null : inputfranquicia_id.SelectedValue.ToString());

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("El registro se ha modificado correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: modificación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + nombre + ", user = " + user + ", pass = " + pass + ", fecha = " + fecha + ", documento = " + documento + ", tipo = " + tipo + "";
                    Datos.crearLOG(formulario, descripcion);
                    llenarUsers();
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

            if (gridUsers.RowCount==0)
            {
                Mensajes.error("No Hay Datos Para Modificar");
                return;
            }

            #endregion

            #region delete

            string id = gridUsers["id",gridUsers.CurrentRow.Index].Value.ToString();

            if (Mensajes.confirmacion("¿Está seguro de que desea eliminar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM users WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("Se ha eliminado el registro correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: eliminación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + gridUsers["nombre", gridUsers.CurrentRow.Index].Value.ToString() + ", user = " + gridUsers["user", gridUsers.CurrentRow.Index].Value.ToString() + ", pass = " + gridUsers["pass", gridUsers.CurrentRow.Index].Value.ToString() + ", fecha = " + gridUsers["fecha", gridUsers.CurrentRow.Index].Value.ToString() + ", documento = " + gridUsers["documento", gridUsers.CurrentRow.Index].Value.ToString() + ", tipo = " + gridUsers["tipo", gridUsers.CurrentRow.Index].Value.ToString() + ", " + gridUsers["franquicia_id", gridUsers.CurrentRow.Index].Value.ToString() + "";
                    Datos.crearLOG(formulario, descripcion);
                    llenarUsers();
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

        private void gridUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUsers.RowCount>0)
            {
                inputnombre.Text = gridUsers["nombre", gridUsers.CurrentRow.Index].Value.ToString();
                inputuser.Text = gridUsers["user", gridUsers.CurrentRow.Index].Value.ToString();
                inputpass.Text = gridUsers["pass", gridUsers.CurrentRow.Index].Value.ToString();
                inputpass2.Text = gridUsers["pass", gridUsers.CurrentRow.Index].Value.ToString();
                inputdocumento.Text = gridUsers["documento", gridUsers.CurrentRow.Index].Value.ToString();
                inputtipo.Text = gridUsers["tipo", gridUsers.CurrentRow.Index].Value.ToString();
                inputfranquicia_id.SelectedValue = gridUsers["franquicia_id", gridUsers.CurrentRow.Index].Value;              
            }
        }

        private void lIMPIARPANTALLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void limpiarPantalla()
        {
            inputnombre.Text = "";
            inputuser.Text = "";
            inputpass.Text = "";
            inputpass2.Text = "";
            inputdocumento.Text = "";
            inputtipo.SelectedIndex = -1;
            inputfranquicia_id.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputfranquicia_id.SelectedIndex = -1;
        }
    }
}
