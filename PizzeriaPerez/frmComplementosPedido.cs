using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmComplementosPedido : Form
    {
        // Cambia la cadena de conexión según tu configuración
        SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

        public frmComplementosPedido()
        {
            InitializeComponent();
        }

        public void LIMPIAR()
        {
            txtCantidadComple.Clear();
            txtComentarios.Clear();
        }

        public void LLENAR()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("SPObtenerDetallesComplementoPedido", CONEXION);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();

                SqlCommand ALTAS = new SqlCommand("insert into COMPLEMENTOPEDIDO(idComplementos, Comentarios, Cantidad) values (@idComplementos, @Comentarios, @Cantidad)", CONEXION);

                // Obtener el ID
                int idComplementos = (int)cbComplemento.SelectedValue;

                ALTAS.Parameters.AddWithValue("@idComplementos", idComplementos);
                ALTAS.Parameters.AddWithValue("@Comentarios", txtComentarios.Text);
                ALTAS.Parameters.AddWithValue("@Cantidad", txtCantidadComple.Text);

                ALTAS.ExecuteNonQuery();
                LLENAR();
                MessageBox.Show("COMPLEMENTO AGREGADO AL PEDIDO");
                LIMPIAR();

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
                MessageBox.Show("Error al agregar el complemento: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }
        }

        private void frmComplementosPedido_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenar el ComboBox con los datos de la tabla COMPLEMENTOS
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT idComplementos, NombreComplementos FROM COMPLEMENTOS", CONEXION);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbComplemento.DisplayMember = "NombreComplementos";
                cbComplemento.ValueMember = "idComplementos";
                cbComplemento.DataSource = dt;

                // Cargar los datos en el DataGridView
                LLENAR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ComboBoxes: " + ex.Message);
            }
        }
    }
}
