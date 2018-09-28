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
    public partial class TipoDispositivo : Form
    {
        MySqlCommand comando;
        
        public TipoDispositivo()
        {
            InitializeComponent();
            llenarGridTipo();
        }

        private void llenarGridTipo()
        {
            comando = Datos.crearComando();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM tipo_dispositivo ORDER BY nombre";

            // Al ejecutar la consulta se devuelve un DataTable.
            // -- 
            gridTipos.DataSource = Datos.ejecutarComandoSelect(comando);
		
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region validaciones

            if (String.IsNullOrEmpty(inputnombre.Text))
            {
                Mensajes.error("Debe Ingresar un Nombre de Procedimiento");
                return;
            }

            if (String.IsNullOrEmpty(inputcantidad_reproducciones.Text) || inputcantidad_reproducciones.Equals(0))
            {
                Mensajes.error("Seleccionar la Cantidad de Reproducciones");
                return;
            }

            #endregion

            #region update

            string nombre = inputnombre.Text;
            string cantidad_reproducciones = inputcantidad_reproducciones.Value.ToString();
            string id = gridTipos["id",gridTipos.CurrentRow.Index].Value.ToString();

            if (Mensajes.confirmacion("¿Está seguro de que desea modificar el registro?") == false)
            {
                return;
            }

            try
            {
                //Se realiza la inserción de los datos en la base de datos
                comando = Datos.crearComando();

                comando.Parameters.Clear();
                comando.CommandText = "UPDATE tipo_dispositivo SET nombre=@nombre, cantidad_reproducciones=@cantidad_reproducciones WHERE id = @id";

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cantidad_reproducciones", cantidad_reproducciones);
                comando.Parameters.AddWithValue("@id", id);

                // Ejecutar la consulta y decidir
                // True: caso exitoso
                // false: Error.
                if (Datos.ejecutarComando(comando))
                {
                    // TODO: OPERACIÓN A REALIZAR EN CASO DE ÉXITO.
                    Mensajes.informacion("El registro se ha modificado correctamente.");
                    string formulario = this.Name;
                    string descripcion = "ACCIÓN: modificación; LOS DATOS DE LA ACCIÓN SON: nombre = " + nombre + ", cantidad_reproducciones = " + cantidad_reproducciones + ", id = " + id + "";
                    Datos.crearLOG(formulario, descripcion);
                    llenarGridTipo();
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

        private void gridTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTipos.RowCount==0)
            {
                return;
            }

            inputcantidad_reproducciones.Value = Convert.ToDecimal(gridTipos["cantidad_reproducciones", gridTipos.CurrentRow.Index].Value.ToString());
            inputnombre.Text=gridTipos["nombre",gridTipos.CurrentRow.Index].Value.ToString();
        }
    }
}
