using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True";

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosPedidoFinal(); // Cargar los datos de PEDIDO_FINAL al ListBox
            CalcularSubtotalYTotal();
        }

        // Método para cargar los datos de la tabla PEDIDO_FINAL en el ListBox
        public void CargarDatosPedidoFinal()
        {
            listBoxPedidoFinal.Items.Clear();

            // Conexión con la base de datos
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True"))
            {
                // Comando SQL para seleccionar los datos de la tabla PEDIDO_FINAL
                string consulta = "SELECT DescripcionPedido, PrecioTotal FROM PEDIDO_FINAL";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    try
                    {
                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar el comando y obtener los resultados
                        SqlDataReader reader = comando.ExecuteReader();

                        // Iterar sobre los resultados y agregar cada fila al ListBox
                        while (reader.Read())
                        {
                            // Obtener los valores necesarios
                            string descripcionPedido = reader["DescripcionPedido"].ToString();
                            decimal precioTotal = Convert.ToDecimal(reader["PrecioTotal"]);

                            // Agregar el elemento al ListBox
                            listBoxPedidoFinal.Items.Add($"{descripcionPedido} - {precioTotal}");
                        }

                        // Cerrar el lector de datos
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos de PEDIDO_FINAL: " + ex.Message);
                    }
                }
            }
        }

        // Evento Click del botón para cerrar sesión
        private void bnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Eventos Click de los botones para abrir diferentes formularios en el panel pContenido
        private void btnPizzaPedido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPizzaPedido());
        }

        private void btnComboPedido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCombosPedido());
        }

        private void btnComplementoPedido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmComplementosPedido());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmMenuAdmin());
        }

        // Método para abrir un formulario en el panel pContenido
        public void AbrirFormEnPanel(object formhija)
        {
            if (this.pContenido.Controls.Count > 0)
                this.pContenido.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenido.Controls.Add(fh);
            this.pContenido.Tag = fh;
            fh.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text.Trim();

            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Llamado a la forma de pago
                frmFormaDePago fdp = new frmFormaDePago();
                // Mostrarla
                fdp.Show();
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código ingresado
                string codigo = txtCodigoPromocion.Text;

                // Comprobar si el código existe y está dentro del período de validez
                using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True"))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PROMOCIONES WHERE Codigo = @Codigo AND GETDATE() BETWEEN FechaInicio AND FechaFin", conexion);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Si el código es válido, aplicar la promoción y recalcular el total
                        decimal porcentajeDescuento = ObtenerPorcentajePromocion(codigo);
                        decimal subtotal = CalcularSubtotal(conexion); // Recupera el subtotal de la base de datos
                        AplicarDescuento(porcentajeDescuento, subtotal);
                        MessageBox.Show("Promoción aplicada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mostrar el subtotal y el total
                        lblSubtotal.Visible = true;
                        lblTotal.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("El código de promoción no es válido o ya ha expirado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar la promoción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para calcular y mostrar el subtotal
        private decimal CalcularSubtotal(SqlConnection conexion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(PrecioTotal) AS Subtotal FROM PEDIDO_FINAL", conexion);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el subtotal: " + ex.Message);
                return 0;
            }
        }

        // Método para calcular y mostrar el subtotal y total
        private void CalcularSubtotalYTotal()
        {
            try
            {
                // Conexión con la base de datos
                using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True"))
                {
                    // Abrir la conexión
                    conexion.Open();

                    // Calcular el subtotal sumando los precios totales de todos los pedidos
                    decimal subtotal = CalcularSubtotal(conexion);

                    // Mostrar el subtotal en el label correspondiente
                    lblSubtotal.Text = subtotal.ToString("C", CultureInfo.CurrentCulture);
                    lblSubtotal.Visible = true;

                    // Mostrar el subtotal también en el label de total
                    lblTotal.Text = subtotal.ToString("C", CultureInfo.CurrentCulture);
                    lblTotal.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el subtotal y total: " + ex.Message);
            }
        }



        private decimal ObtenerPorcentajePromocion(string codigo)
        {
            decimal porcentaje = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Cantidad FROM PROMOCIONES WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        porcentaje = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el porcentaje de descuento de la promoción: " + ex.Message);
            }
            return porcentaje;
        }

        private void AplicarDescuento(decimal porcentajeDescuento, decimal subtotal)
        {
            try
            {
                MessageBox.Show($"Subtotal obtenido: {subtotal:C}");
                MessageBox.Show($"Porcentaje de descuento obtenido: {porcentajeDescuento}%");

                decimal descuento = subtotal * (porcentajeDescuento / 100);
                MessageBox.Show($"Descuento calculado: {descuento:C}");

                decimal total = subtotal - descuento;
                MessageBox.Show($"Total calculado: {total:C}");

                lblSubtotal.Text = subtotal.ToString("C", CultureInfo.CurrentCulture); // Mostrar el subtotal en el Label
                lblTotal.Text = total.ToString("C", CultureInfo.CurrentCulture);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar el descuento: " + ex.Message);
            }
        }




        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCliente = txtNombreCliente.Text;

                if (!string.IsNullOrEmpty(nombreCliente))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Clientes (Nombre) VALUES (@Nombre)";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Nombre", nombreCliente);
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente agregado correctamente a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el cliente a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
