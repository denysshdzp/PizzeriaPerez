using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Llamar la libreria SQL
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzeriaPerez
{
    public partial class frmComplementosPedido : Form
    {
        public frmComplementosPedido()
        {
            InitializeComponent();
        }
        //Conexion con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=LAPTOP-PTEQ4GGC;Initial Catalog=PizzeriaF;Integrated Security=True");

        //Metodo para limpiar
        public void LIMPIAR()
        {
            txtCantidadComple.Clear();
            txtComentarios.Clear();

        }

        //Llenar la tabla
        public void LLENAR()
        {

            SqlDataAdapter DA = new SqlDataAdapter("SPObtenerDetallesComplementoPedido", CONEXION);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            CONEXION.Open();
            SqlCommand ALTAS = new SqlCommand("insert into COMPLEMENTOPEDIDO(idComplementos,Comentarios,Cantidad)" +
               "values (@idComplementos,@Comentarios,@Cantidad)", CONEXION);

            // Obtener el ID 
            int idComplementos = (int)cbComplemento.SelectedValue;

            // Luego puedes utilizar estos IDs en lugar de los valores de los ComboBoxes en tus parámetros SQL
            ALTAS.Parameters.AddWithValue("idComplementos", idComplementos);
            ALTAS.Parameters.AddWithValue("Comentarios", txtComentarios.Text);
            ALTAS.Parameters.AddWithValue("Cantidad", txtCantidadComple.Text);


            try
            {

                ALTAS.ExecuteNonQuery();
                LLENAR();
                MessageBox.Show("COMPLEMENTO AGREGADO AL PEDIDO");
                LIMPIAR();

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE REGISTRO");
            }
            CONEXION.Close();
        }

        private void frmComplementosPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet3.COMPLEMENTOS' Puede moverla o quitarla según sea necesario.
            this.cOMPLEMENTOSTableAdapter.Fill(this.pizzeriaFDataSet3.COMPLEMENTOS);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet12.SPObtenerDetallesComplementoPedido' Puede moverla o quitarla según sea necesario.
            this.sPObtenerDetallesComplementoPedidoTableAdapter.Fill(this.pizzeriaFDataSet12.SPObtenerDetallesComplementoPedido);

        }
    }
}
