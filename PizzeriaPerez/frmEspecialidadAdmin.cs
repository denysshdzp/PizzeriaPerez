using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmEspecialidadAdmin : Form
    {
        public frmEspecialidadAdmin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEspecialidadAdmin_Load(object sender, EventArgs e)
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

        // Conexión con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

        // Método para limpiar
        public void LIMPIAR()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioExtra.Clear();
            txtNombre.Focus();
        }

        // Llenar la tabla
        public void LLENAR()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("SP_MOSTRARESP", CONEXION);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la tabla: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand ALTAS = new SqlCommand("insert into ESPECIALIDAD(Nombre,Descripcion,CostoExtra) values (@Nombre,@Descripcion,@CostoExtra)", CONEXION);
                ALTAS.Parameters.AddWithValue("Nombre", txtNombre.Text);
                ALTAS.Parameters.AddWithValue("Descripcion", txtDescripcion.Text);
                ALTAS.Parameters.AddWithValue("CostoExtra", txtPrecioExtra.Text);

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Llenar el campo Nombre");
                    txtNombre.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Llenar el campo de Descripción");
                    txtDescripcion.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtPrecioExtra.Text))
                {
                    MessageBox.Show("Llenar el campo de Precio Extra");
                    txtPrecioExtra.Focus();
                }
                else
                {
                    ALTAS.ExecuteNonQuery();
                    LLENAR();
                    MessageBox.Show("Especialidad dada de alta");
                    LIMPIAR();
                }
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
                string baja = "DELETE FROM ESPECIALIDAD WHERE idEspecialidad=@idEspecialidad";
                CONEXION.Open();
                SqlCommand cmdIns = new SqlCommand(baja, CONEXION);
                cmdIns.Parameters.AddWithValue("idEspecialidad", txtIdEspecialidad.Text);
                cmdIns.ExecuteNonQuery();
                MessageBox.Show("Especialidad eliminada");
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
                SqlCommand Actualizar = new SqlCommand("UPDATE ESPECIALIDAD SET Nombre=@Nombre, Descripcion=@Descripcion, CostoExtra=@CostoExtra WHERE idEspecialidad=@idEspecialidad", CONEXION);
                Actualizar.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                Actualizar.Parameters.AddWithValue("@CostoExtra", txtPrecioExtra.Text);
                Actualizar.Parameters.AddWithValue("@idEspecialidad", txtIdEspecialidad.Text);

                CONEXION.Open();
                Actualizar.ExecuteNonQuery();
                MessageBox.Show("Especialidad modificada");
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
                string consulta = "SELECT * FROM ESPECIALIDAD WHERE idEspecialidad=@idEspecialidad";
                SqlCommand cmdConsulta = new SqlCommand(consulta, CONEXION);
                cmdConsulta.Parameters.AddWithValue("@idEspecialidad", txtIdEspecialidad.Text);

                SqlDataReader reader = cmdConsulta.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtDescripcion.Text = reader["Descripcion"].ToString();
                    txtPrecioExtra.Text = reader["CostoExtra"].ToString();
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
