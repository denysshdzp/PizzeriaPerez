using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmCombosPedido : Form
    {
        SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

        public frmCombosPedido()
        {
            InitializeComponent();
        }

        public void LimpiarDatos()
        {
            txtComentarios.Clear();
            txtCantidadExtra.Clear(); // Limpiar el TextBox de cantidad
        }

        public void LLENAR()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("SPObtenerDetallesCombo", CONEXION);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de combo: " + ex.Message);
            }
        }

        private void frmCombosPedido_Load(object sender, EventArgs e)
        {
            LLENAR(); // Llenar el DataGridView al cargar el formulario
            CargarComboBoxes(); // Llenar los ComboBoxes al cargar el formulario
        }

        private void CargarComboBoxes()
        {
            try
            {
                // Llenar el ComboBox de Combo
                SqlDataAdapter comboAdapter = new SqlDataAdapter("SELECT * FROM COMBO", CONEXION);
                DataTable comboDataTable = new DataTable();
                comboAdapter.Fill(comboDataTable);
                cbCombo.DataSource = comboDataTable;
                cbCombo.DisplayMember = "NombreCombo";
                cbCombo.ValueMember = "idCombo";

                // Llenar el ComboBox de Ingrediente Extra
                SqlDataAdapter extraAdapter = new SqlDataAdapter("SELECT * FROM INGREDIENTEEXTRA", CONEXION);
                DataTable extraDataTable = new DataTable();
                extraAdapter.Fill(extraDataTable);
                cbExtra.DataSource = extraDataTable;
                cbExtra.DisplayMember = "NombreIngrediente";
                cbExtra.ValueMember = "idIngredienteExtra";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBoxes: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand ALTAS = new SqlCommand("INSERT INTO COMBOPEDIDO(idCombo, idIngredienteExtra, Comentarios, CantidadExtra) " +
                   "VALUES (@idCombo, @idIngredienteExtra, @Comentarios, @CantidadExtra)", CONEXION);

                int idComboSeleccionado = (int)cbCombo.SelectedValue;
                int idIngredienteExtraSeleccionado = (int)cbExtra.SelectedValue;

                ALTAS.Parameters.AddWithValue("@idCombo", idComboSeleccionado);
                ALTAS.Parameters.AddWithValue("@idIngredienteExtra", idIngredienteExtraSeleccionado);
                ALTAS.Parameters.AddWithValue("@Comentarios", txtComentarios.Text);
                ALTAS.Parameters.AddWithValue("@CantidadExtra", txtCantidadExtra.Text);

                ALTAS.ExecuteNonQuery();
                MessageBox.Show("COMBO AGREGADO AL PEDIDO");
                LimpiarDatos();
                LLENAR();

                // Llamar al procedimiento almacenado para llenar la tabla PEDIDO_FINAL
                SqlCommand llenarPedidoFinal = new SqlCommand("SP_LLENAR_PEDIDO_FINAL", CONEXION);
                llenarPedidoFinal.CommandType = CommandType.StoredProcedure;
                llenarPedidoFinal.ExecuteNonQuery();

                MessageBox.Show("Pedido Final actualizado.");

                // Actualizar el ListBox en el formulario principal
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



