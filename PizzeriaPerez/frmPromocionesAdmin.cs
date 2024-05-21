using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmPromocionesAdmin : Form
    {
        public frmPromocionesAdmin()
        {
            InitializeComponent();
        }

        // Conexión con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

        // Método para limpiar
        public void LIMPIAR()
        {
            txtCodigo.Clear();
            txtCantidad.Clear();
            txtDescripcion.Clear();
            dtFechaInicio.Value = DateTime.Now;
            dtFechaFin.Value = DateTime.Now;
            txtCodigo.Focus();
        }

        // Llenar la tabla
        public void LLENAR()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM PROMOCIONES", CONEXION);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dataGridView1.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar la tabla: " + ex.Message);
            }
        }

        // Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand ALTAS = new SqlCommand("INSERT INTO PROMOCIONES(Codigo, Cantidad, Descripcion, FechaInicio, FechaFin) " +
                    "VALUES (@Codigo, @Cantidad, @Descripcion, @FechaInicio, @FechaFin)", CONEXION);
                ALTAS.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                ALTAS.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                ALTAS.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                ALTAS.Parameters.AddWithValue("@FechaInicio", dtFechaInicio.Value);
                ALTAS.Parameters.AddWithValue("@FechaFin", dtFechaFin.Value);

                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Llenar el campo Código");
                    txtCodigo.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Llenar el campo de cantidad.");
                    txtCantidad.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Llenar el campo de descripción.");
                    txtDescripcion.Focus();
                }
                else
                {
                    ALTAS.ExecuteNonQuery();
                    LLENAR();
                    MessageBox.Show("Promoción agregada");
                    LIMPIAR();
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

        private void frmPromocionesAdmin_Load(object sender, EventArgs e)
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

        // Botón para eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM PROMOCIONES WHERE idPromocion=@idPromocion";
                CONEXION.Open();
                SqlCommand cmdIns = new SqlCommand(baja, CONEXION);
                cmdIns.Parameters.AddWithValue("@idPromocion", Convert.ToInt32(dataGridView1.CurrentRow.Cells["idPromocion"].Value));
                cmdIns.ExecuteNonQuery();
                MessageBox.Show("Promoción eliminada");
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

        // Botón para consultar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPromocion = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idPromocion"].Value);
                CONEXION.Open();
                string Consulta = "SELECT * FROM PROMOCIONES WHERE idPromocion=@idPromocion";
                SqlCommand cmdConsulta = new SqlCommand(Consulta, CONEXION);
                cmdConsulta.Parameters.AddWithValue("@idPromocion", idPromocion);
                SqlDataReader Reader = cmdConsulta.ExecuteReader();
                if (Reader.Read())
                {
                    txtCodigo.Text = Reader["Codigo"].ToString();
                    txtCantidad.Text = Reader["Cantidad"].ToString();
                    txtDescripcion.Text = Reader["Descripcion"].ToString();
                    dtFechaInicio.Value = Convert.ToDateTime(Reader["FechaInicio"]);
                    dtFechaFin.Value = Convert.ToDateTime(Reader["FechaFin"]);
                }
                else
                {
                    MessageBox.Show("Id no encontrado, intente de nuevo");
                    LIMPIAR();
                }
                Reader.Close();
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

        // Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPromocion = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idPromocion"].Value);
                SqlCommand Actualizar = new SqlCommand("UPDATE PROMOCIONES SET Codigo=@Codigo, Cantidad=@Cantidad, Descripcion=@Descripcion, FechaInicio=@FechaInicio, FechaFin=@FechaFin WHERE idPromocion=@idPromocion", CONEXION);
                Actualizar.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                Actualizar.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                Actualizar.Parameters.AddWithValue("@FechaInicio", dtFechaInicio.Value);
                Actualizar.Parameters.AddWithValue("@FechaFin", dtFechaFin.Value);
                Actualizar.Parameters.AddWithValue("@idPromocion", idPromocion);

                CONEXION.Open();
                Actualizar.ExecuteNonQuery();
                MessageBox.Show("Promoción modificada.");
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
    }
}
