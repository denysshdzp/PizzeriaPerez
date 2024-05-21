using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmPizzaPedido : Form
    {
        SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

        public frmPizzaPedido()
        {
            InitializeComponent();
        }

        public void LimpiarDatos()
        {
            txtCantidadExtra.Clear();
            txtComentarios.Clear();
            txtCantidadPIZZAS.Clear();
        }

        public void LLENAR()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("SPObtenerDetallesPizza", CONEXION);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar los datos: " + ex.Message);
            }
        }

        private void frmPizzaPedido_Load(object sender, EventArgs e)
        {
            LLENAR();
            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            try
            {
                SqlDataAdapter tamAdapter = new SqlDataAdapter("SELECT * FROM TAMAÑO", CONEXION);
                DataTable tamDataTable = new DataTable();
                tamAdapter.Fill(tamDataTable);
                cbTam.DataSource = tamDataTable;
                cbTam.DisplayMember = "NombreTamaño";
                cbTam.ValueMember = "idTamaño";

                SqlDataAdapter espAdapter = new SqlDataAdapter("SELECT * FROM ESPECIALIDAD", CONEXION);
                DataTable espDataTable = new DataTable();
                espAdapter.Fill(espDataTable);
                cbEspe.DataSource = espDataTable;
                cbEspe.DisplayMember = "NombreEspecialidad";
                cbEspe.ValueMember = "idEspecialidad";

                SqlDataAdapter ingAdapter = new SqlDataAdapter("SELECT * FROM INGREDIENTEEXTRA", CONEXION);
                DataTable ingDataTable = new DataTable();
                ingAdapter.Fill(ingDataTable);
                cbExtra.DataSource = ingDataTable;
                cbExtra.DisplayMember = "NombreIngrediente";
                cbExtra.ValueMember = "idIngredienteExtra";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBoxes: " + ex.Message);
            }
        }

        private decimal CalcularPrecioTotal(int idTamaño, int idEspecialidad, int idIngredienteExtra)
        {
            decimal precioTotal = 0;

            SqlCommand obtenerPrecioTamaño = new SqlCommand("SELECT Precio FROM TAMAÑO WHERE idTamaño = @idTamaño", CONEXION);
            obtenerPrecioTamaño.Parameters.AddWithValue("@idTamaño", idTamaño);
            decimal precioTamaño = Convert.ToDecimal(obtenerPrecioTamaño.ExecuteScalar());
            precioTotal += precioTamaño;

            SqlCommand obtenerCostoEspecialidad = new SqlCommand("SELECT CostoExtra FROM ESPECIALIDAD WHERE idEspecialidad = @idEspecialidad", CONEXION);
            obtenerCostoEspecialidad.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
            decimal costoEspecialidad = Convert.ToDecimal(obtenerCostoEspecialidad.ExecuteScalar());
            precioTotal += costoEspecialidad;

            if (idIngredienteExtra != 0)
            {
                SqlCommand obtenerPrecioIngredienteExtra = new SqlCommand("SELECT PrecioIngrediente FROM INGREDIENTEEXTRA WHERE idIngredienteExtra = @idIngredienteExtra", CONEXION);
                obtenerPrecioIngredienteExtra.Parameters.AddWithValue("@idIngredienteExtra", idIngredienteExtra);
                decimal precioIngredienteExtra = Convert.ToDecimal(obtenerPrecioIngredienteExtra.ExecuteScalar());
                precioTotal += precioIngredienteExtra;
            }

            int cantidadPizzas = Convert.ToInt32(txtCantidadPIZZAS.Text);
            precioTotal *= cantidadPizzas;

            return precioTotal;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();

                // Verificar si las cadenas pueden convertirse a enteros
                if (!int.TryParse(txtCantidadPIZZAS.Text, out int cantidadPizzas))
                {
                    MessageBox.Show("Cantidad de pizzas no válida.");
                    return;
                }

                // Obtener los valores seleccionados de los ComboBoxes
                int idTamañoSeleccionado = (int)cbTam.SelectedValue;
                int idEspecialidadSeleccionada = (int)cbEspe.SelectedValue;
                int idIngredienteExtraSeleccionado = (int)cbExtra.SelectedValue;

                // Insertar en la tabla PIZZA
                SqlCommand ALTAS = new SqlCommand("INSERT INTO PIZZA (idTamaño, idEspecialidad, Comentarios, CantidadPizzas, idIngredienteExtra, CantidadExtra) " +
                                                   "VALUES (@idTamaño, @idEspecialidad, @Comentarios, @CantidadPizzas, @idIngredienteExtra, @CantidadExtra)", CONEXION);

                ALTAS.Parameters.AddWithValue("@idTamaño", idTamañoSeleccionado);
                ALTAS.Parameters.AddWithValue("@idEspecialidad", idEspecialidadSeleccionada);
                ALTAS.Parameters.AddWithValue("@Comentarios", txtComentarios.Text);
                ALTAS.Parameters.AddWithValue("@CantidadPizzas", cantidadPizzas);
                ALTAS.Parameters.AddWithValue("@idIngredienteExtra", idIngredienteExtraSeleccionado);
                ALTAS.Parameters.AddWithValue("@CantidadExtra", txtCantidadExtra.Text);

                ALTAS.ExecuteNonQuery();

                MessageBox.Show("PIZZA AGREGADA AL PEDIDO");
                LimpiarDatos();
                LLENAR();

                // Llamar al procedimiento almacenado para llenar la tabla PEDIDO_FINAL
                SqlCommand llenarPedidoFinal = new SqlCommand("SP_LLENAR_PEDIDO_FINAL", CONEXION);
                llenarPedidoFinal.CommandType = CommandType.StoredProcedure;
                llenarPedidoFinal.ExecuteNonQuery();

                MessageBox.Show("Pedido Final actualizado.");

                if (Application.OpenForms["frmMenuPrincipal"] is frmMenuPrincipal menuPrincipal)
                {
                    menuPrincipal.CargarDatosPedidoFinal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE REGISTRO: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }
        }


    }
}

