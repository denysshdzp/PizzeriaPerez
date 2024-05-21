using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmTicket : Form
    {
        private string connectionString = "Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True";
        private PrintDocument printDocument = new PrintDocument();
        private string nombreCliente = "";

        public frmTicket()
        {
            InitializeComponent();
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            // Agregar columnas al DataGridView
            dataGridViewPedido.Columns.Add("DescripcionPedido", "Descripción del Pedido");
            dataGridViewPedido.Columns.Add("PrecioTotal", "Precio Total");

            CargarDetallesPedido();
            CalcularSubtotalDescuentoTotal();
            CargarNombreCliente();

            // Configurar el evento de impresión
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void CargarDetallesPedido()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT DescripcionPedido, PrecioTotal FROM pedido_final";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Agregar detalles del pedido al DataGridView
                        dataGridViewPedido.Rows.Add(reader["DescripcionPedido"], reader["PrecioTotal"]);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles del pedido: " + ex.Message);
            }
        }

        private void CalcularSubtotalDescuentoTotal()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dataGridViewPedido.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["PrecioTotal"].Value);
            }

            // Aplicar descuento si es necesario
            decimal descuento = 0; // Calcula el descuento según tu lógica
            decimal total = subtotal - descuento;

            // Mostrar los valores en los Labels correspondientes
            lblSubtotal.Text = subtotal.ToString("C");
            lblDescuento.Text = descuento.ToString("C");
            lblTotal.Text = total.ToString("C");
        }

        private void CargarNombreCliente()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 Nombre FROM Clientes ORDER BY IdCliente DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        lblNombreCliente.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el nombre del cliente: " + ex.Message);
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Configurar la impresora seleccionada
                printDocument.PrinterSettings = printDialog.PrinterSettings;

                // Iniciar el proceso de impresión
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Configurar la fuente y el formato de impresión
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float lineHeight = font.GetHeight(e.Graphics) + 2;
            float x = 10, y = 10;

            // Obtener los datos a imprimir
            string datosImpresion = ObtenerDatosImpresion();

            // Imprimir los datos en la página
            e.Graphics.DrawString(datosImpresion, font, brush, x, y);
        }

        private string ObtenerDatosImpresion()
        {
            // Aquí puedes obtener los datos que deseas imprimir, como los detalles del pedido, subtotal, descuento, nombre del cliente, etc.
            // Por ejemplo:
            string datos = $"Cliente: {nombreCliente}\n";
            datos += "Detalles del pedido:\n";
            foreach (DataGridViewRow row in dataGridViewPedido.Rows)
            {
                string descripcion = row.Cells["DescripcionPedido"].Value.ToString();
                string precio = row.Cells["PrecioTotal"].Value.ToString();
                datos += $"{descripcion}: {precio}\n";
            }
            datos += $"\nSubtotal: {lblSubtotal.Text}\n";
            datos += $"Descuento: {lblDescuento.Text}\n";
            datos += $"Total: {lblTotal.Text}\n";
            return datos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
