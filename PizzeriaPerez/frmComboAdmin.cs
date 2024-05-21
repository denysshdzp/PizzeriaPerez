using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmComboAdmin : Form
    {
        public frmComboAdmin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Conexión con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

        // Método para limpiar
        public void LIMPIAR()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        // Llenar la tabla
        public void LLENAR()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("SP_MOSTRARCOMBO", CONEXION);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la tabla: " + ex.Message);
            }
        }

        private void frmComboAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                LLENAR();
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
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Llenar el campo Nombre");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Llenar el campo de Descripción");
                    txtDescripcion.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Llenar el campo de Precio");
                    txtPrecio.Focus();
                    return;
                }

                CONEXION.Open();
                SqlCommand ALTAS = new SqlCommand("INSERT INTO COMBO(NombreCombo, Descripcion, PrecioCombo) VALUES (@NombreCombo, @Descripcion, @PrecioCombo)", CONEXION);
                ALTAS.Parameters.AddWithValue("@NombreCombo", txtNombre.Text);
                ALTAS.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                ALTAS.Parameters.AddWithValue("@PrecioCombo", txtPrecio.Text);

                ALTAS.ExecuteNonQuery();
                LLENAR();
                MessageBox.Show("Combo dado de alta");
                LIMPIAR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de registro: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand cmdIns = new SqlCommand("DELETE FROM COMBO WHERE idCombo=@idCombo", CONEXION);
                cmdIns.Parameters.AddWithValue("@idCombo", txtIdCombo.Text);

                cmdIns.ExecuteNonQuery();
                MessageBox.Show("Combo eliminado");
                LLENAR();
                LIMPIAR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand Actualizar = new SqlCommand("UPDATE COMBO SET NombreCombo=@NombreCombo, Descripcion=@Descripcion, PrecioCombo=@PrecioCombo WHERE idCombo=@idCombo", CONEXION);
                Actualizar.Parameters.AddWithValue("@NombreCombo", txtNombre.Text);
                Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                Actualizar.Parameters.AddWithValue("@PrecioCombo", txtPrecio.Text);
                Actualizar.Parameters.AddWithValue("@idCombo", txtIdCombo.Text);

                Actualizar.ExecuteNonQuery();
                MessageBox.Show("Combo modificado");
                LLENAR();
                LIMPIAR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand cmdConsulta = new SqlCommand("SELECT * FROM COMBO WHERE idCombo=@idCombo", CONEXION);
                cmdConsulta.Parameters.AddWithValue("@idCombo", txtIdCombo.Text);

                SqlDataReader reader = cmdConsulta.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader["NombreCombo"].ToString();
                    txtDescripcion.Text = reader["Descripcion"].ToString();
                    txtPrecio.Text = reader["PrecioCombo"].ToString();
                }
                else
                {
                    MessageBox.Show("ID no encontrado, intente de nuevo");
                    LIMPIAR();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }
        }
    }
}
