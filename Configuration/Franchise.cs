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
    public partial class Franchise : Form
    {
        MySqlCommand comando;

        public Franchise()
        {
            InitializeComponent();
            llenarComboDepartamentos();
            llenarComboMunicipios();
            llenarGridFranquicias();
        }

        private void llenarGridFranquicias()
        {
            if (String.IsNullOrEmpty(inputmunicipios_id.Text))
            {
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM franquicia WHERE municipios_id=@municipios_id ORDER BY nombre";
            comando.Parameters.AddWithValue("@municipios_id", inputmunicipios_id.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridFranquicias.DataSource = Datos.ejecutarComandoSelect(comando);

            for (int i = 0; i < gridFranquicias.Columns.Count; i++)
            {
                gridFranquicias.Columns[i].Visible = false;
            }

            gridFranquicias.Columns["id"].Visible = true;
            gridFranquicias.Columns["nombre"].Visible = true;
            gridFranquicias.Columns["activo"].Visible = true;
        }

        private void llenarComboMunicipios()
        {
            if (String.IsNullOrEmpty(inputdepartamentos.Text))
            {
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM municipios WHERE departamentos_id = @departamentos_id ORDER BY nombre";
            comando.Parameters.AddWithValue("@departamentos_id", inputdepartamentos.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputmunicipios_id.DataSource = Datos.ejecutarComandoSelect(comando);
            inputmunicipios_id.ValueMember = "id";
            inputmunicipios_id.DisplayMember = "nombre";
            inputmunicipios_id.SelectedIndex = -1;
        }

        private void llenarComboDepartamentos()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM departamentos ORDER BY nombre";

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            inputdepartamentos.DataSource = Datos.ejecutarComandoSelect(comando);
            inputdepartamentos.ValueMember = "id";
            inputdepartamentos.DisplayMember = "nombre";
            inputdepartamentos.SelectedIndex = -1;
        }

        private void inputdepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputdepartamentos.Text))
            {
                return;
            }

            llenarComboMunicipios();
        }

        private void inputmunicipios_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputmunicipios_id.Text))
            {
                return;
            }

            llenarGridFranquicias();
        }

        private void aLMACENARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputtel.Text))
            {
                Mensajes.error("Debe Ingresar el Teléfono de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputdireccion.Text))
            {
                Mensajes.error("Debe Ingresar la Dirección de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputcontacto.Text))
            {
                Mensajes.error("Debe Ingresar el Número de Contrato de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputcontacto.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre del Contacto de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputtel_contacto.Text))
            {
                Mensajes.error("Debe Ingresar el Teléfono del Contacto de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputmunicipios_id.Text))
            {
                Mensajes.error("Debe Seleccionar un Municipio para la Franquicia");
                return;
            }

            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM franquicia WHERE activo = @activo AND municipios_id=@municipios_id";
            comando.Parameters.AddWithValue("@activo", "1");
            comando.Parameters.AddWithValue("@municipios_id", inputmunicipios_id.SelectedValue.ToString());

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            DataTable validacion = Datos.ejecutarComandoSelect(comando);
            if (validacion.Rows.Count > 0)
            {
                Mensajes.error("Ya Existe una Franquicia Creada para la Ciudad, Imposible Almacenar");
                return;
            }

            #endregion

            #region insert

            string nombre = inputnombre.Text;
            string tel = inputtel.Text;
            string contrato = inputcontrato.Text;
            string direccion = inputdireccion.Text;
            string contacto = inputcontacto.Text;
            string tel_contacto = inputtel_contacto.Text;
            string municipios_id = inputmunicipios_id.SelectedValue.ToString();
            bool activo = (bool)inputactivo.Checked;


            if (Mensajes.confirmacion("¿Está seguro de que desea Insertar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO franquicia (nombre, tel, contrato, direccion, contacto, tel_contacto, municipios_id, activo) VALUES (@nombre, @tel, @contrato, @direccion, @contacto, @tel_contacto, @municipios_id, @activo)";

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@tel", tel);
                comando.Parameters.AddWithValue("@contrato", contrato);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@contacto", contacto);
                comando.Parameters.AddWithValue("@tel_contacto", tel_contacto);
                comando.Parameters.AddWithValue("@municipios_id", municipios_id);
                comando.Parameters.AddWithValue("@activo", activo);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("La inserción se ha realizado correctamente.");

                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: inserción; LOS DATOS DE LA ACCIÓN SON: nombre = " + nombre + ", tel = " + tel + ", contrato = " + contrato + ", direccion = " + direccion + ", contacto = " + contacto + ", tel_contacto = " + tel_contacto + ", municipios_id = " + municipios_id + ", activo = " + activo + "";
                    Datos.crearLOG(formulario, descripcion);
                    llenarGridFranquicias();
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
                Mensajes.error("Debe Ingresar el Nombre de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputtel.Text))
            {
                Mensajes.error("Debe Ingresar el Teléfono de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputdireccion.Text))
            {
                Mensajes.error("Debe Ingresar la Dirección de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputcontacto.Text))
            {
                Mensajes.error("Debe Ingresar el Número de Contrato de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputcontacto.Text))
            {
                Mensajes.error("Debe Ingresar el Nombre del Contacto de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputtel_contacto.Text))
            {
                Mensajes.error("Debe Ingresar el Teléfono del Contacto de la Franquicia");
                return;
            }

            if (String.IsNullOrEmpty(inputmunicipios_id.Text))
            {
                Mensajes.error("Debe Seleccionar un Municipio para la Franquicia");
                return;
            }

            if (gridFranquicias.RowCount == 0)
            {
                Mensajes.error("No Hay Datos Para Modificar");
                return;
            }

            #endregion

            #region update

            string id = gridFranquicias["id", gridFranquicias.CurrentRow.Index].Value.ToString();
            string nombre = inputnombre.Text;
            string tel = inputtel.Text;
            string contrato = inputcontrato.Text;
            string direccion = inputdireccion.Text;
            string contacto = inputcontacto.Text;
            string tel_contacto = inputtel_contacto.Text;
            string municipios_id = inputmunicipios_id.SelectedValue.ToString();
            bool activo = (bool)inputactivo.Checked;

            if (Mensajes.confirmacion("¿Está seguro de que desea modificar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "UPDATE franquicia SET nombre=@nombre, tel=@tel, contrato=@contrato, direccion=@direccion, contacto=@contacto, tel_contacto=@tel_contacto, activo=@activo WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@tel", tel);
                comando.Parameters.AddWithValue("@contrato", contrato);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@contacto", contacto);
                comando.Parameters.AddWithValue("@tel_contacto", tel_contacto);
                comando.Parameters.AddWithValue("@activo", activo);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("El registro se ha modificado correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: modificación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + nombre + ", tel = " + tel + ", contrato = " + contrato + ", direccion = " + direccion + ", contacto = " + contacto + ", tel_contacto = " + tel_contacto + ", municipios_id = " + municipios_id + ", activo = " + activo + "";
                    Datos.crearLOG(formulario, descripcion);
                    llenarGridFranquicias();
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

            if (gridFranquicias.RowCount == 0)
            {
                Mensajes.error("No Hay datos para Eliminar");
                return;
            }

            #endregion

            #region delete

            string id = gridFranquicias["id", gridFranquicias.CurrentRow.Index].Value.ToString();

            if (Mensajes.confirmacion("¿Está seguro de que desea eliminar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM franquicia WHERE id = @id";
                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("Se ha eliminado el registro correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: eliminación; LOS DATOS DE LA ACCIÓN SON: id = " + id + ", nombre = " + gridFranquicias["nombre", gridFranquicias.CurrentRow.Index].Value.ToString() + ", tel = " + gridFranquicias["tel", gridFranquicias.CurrentRow.Index].Value.ToString() + ", contrato = " + gridFranquicias["contrato", gridFranquicias.CurrentRow.Index].Value.ToString() + ", direccion = " + gridFranquicias["direccion", gridFranquicias.CurrentRow.Index].Value.ToString() + ", contacto = " + gridFranquicias["contacto", gridFranquicias.CurrentRow.Index].Value.ToString() + ", tel_contacto = " + gridFranquicias["tel_contacto", gridFranquicias.CurrentRow.Index].Value.ToString() + ", municipios_id = " + gridFranquicias["municipios_id", gridFranquicias.CurrentRow.Index].Value.ToString() + ", activo = " + gridFranquicias["activo", gridFranquicias.CurrentRow.Index].Value.ToString() + "";
                    Datos.crearLOG(formulario, descripcion);
                    llenarGridFranquicias();
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

        private void nuevo_Click(object sender, EventArgs e)
        {
            if (Mensajes.confirmacion("Desea Limpiar los Datos de Pantalla?"))
            {
                inputnombre.Text = "";
                inputtel.Text = "";
                inputcontrato.Text = "";
                inputdireccion.Text = "";
                inputcontacto.Text = "";
                inputtel_contacto.Text = "";
                inputmunicipios_id.Text = "";
                inputactivo.Checked = true;
            }
        }

        private void gridFranquicias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFranquicias.RowCount > 0)
            {
                inputnombre.Text = gridFranquicias["nombre", gridFranquicias.CurrentRow.Index].Value.ToString();
                inputtel.Text = gridFranquicias["tel", gridFranquicias.CurrentRow.Index].Value.ToString();
                inputcontrato.Text = gridFranquicias["contrato", gridFranquicias.CurrentRow.Index].Value.ToString();
                inputdireccion.Text = gridFranquicias["direccion", gridFranquicias.CurrentRow.Index].Value.ToString();
                inputcontacto.Text = gridFranquicias["contacto", gridFranquicias.CurrentRow.Index].Value.ToString();
                inputtel_contacto.Text = gridFranquicias["tel_contacto", gridFranquicias.CurrentRow.Index].Value.ToString();
                inputmunicipios_id.SelectedValue = gridFranquicias["municipios_id", gridFranquicias.CurrentRow.Index].Value.ToString();
                inputactivo.Checked = (bool)gridFranquicias["activo", gridFranquicias.CurrentRow.Index].Value;
            }
        }
    }
}
