using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmIngredienteExtraAdmin : Form
    {
        public frmIngredienteExtraAdmin()
        {
            InitializeComponent();

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
                SqlDataAdapter DA = new SqlDataAdapter("SP_MOSTRAREXTRA", CONEXION);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la tabla: " + ex.Message);
            }
        }

        private void frmIngredienteExtraAdmin_Load(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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
                SqlCommand ALTAS = new SqlCommand("INSERT INTO INGREDIENTEEXTRA (NombreIngrediente, Descripcion, PrecioIngrediente) VALUES (@NombreIngrediente, @Descripcion, @PrecioIngrediente)", CONEXION);
                ALTAS.Parameters.AddWithValue("@NombreIngrediente", txtNombre.Text);
                ALTAS.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                ALTAS.Parameters.AddWithValue("@PrecioIngrediente", txtPrecio.Text);

                ALTAS.ExecuteNonQuery();
                LLENAR();
                MessageBox.Show("Ingrediente dado de alta");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand cmdIns = new SqlCommand("DELETE FROM INGREDIENTEEXTRA WHERE idIngredienteExtra=@idIngredienteExtra", CONEXION);
                cmdIns.Parameters.AddWithValue("@idIngredienteExtra", txtIdIngrediente.Text);

                cmdIns.ExecuteNonQuery();
                MessageBox.Show("Ingrediente eliminado");
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
                SqlCommand Actualizar = new SqlCommand("UPDATE INGREDIENTEEXTRA SET NombreIngrediente=@NombreIngrediente, Descripcion=@Descripcion, PrecioIngrediente=@PrecioIngrediente WHERE idIngredienteExtra=@idIngredienteExtra", CONEXION);
                Actualizar.Parameters.AddWithValue("@NombreIngrediente", txtNombre.Text);
                Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                Actualizar.Parameters.AddWithValue("@PrecioIngrediente", txtPrecio.Text);
                Actualizar.Parameters.AddWithValue("@idIngredienteExtra", txtIdIngrediente.Text);

                Actualizar.ExecuteNonQuery();
                MessageBox.Show("Ingrediente modificado");
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
                SqlCommand cmdConsulta = new SqlCommand("SELECT * FROM INGREDIENTEEXTRA WHERE idIngredienteExtra=@idIngredienteExtra", CONEXION);
                cmdConsulta.Parameters.AddWithValue("@idIngredienteExtra", txtIdIngrediente.Text);

                SqlDataReader reader = cmdConsulta.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader["NombreIngrediente"].ToString();
                    txtDescripcion.Text = reader["Descripcion"].ToString();
                    txtPrecio.Text = reader["PrecioIngrediente"].ToString();
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

