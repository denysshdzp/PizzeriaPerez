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
    public partial class frmPizzaPedido : Form
    {
        public frmPizzaPedido()
        {
            InitializeComponent();
        }
        //Conexion con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=LAPTOP-PTEQ4GGC;Initial Catalog=PizzeriaF;Integrated Security=True");

        //Metodo para limpiar
        public void LIMPIAR()
        {
            txtCantidadExtra.Clear();
            txtComentarios.Clear();

        }

        //Llenar la tabla
        public void LLENAR()
        {

            SqlDataAdapter DA = new SqlDataAdapter("SPObtenerDetallesPizza", CONEXION);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
        }


        private void frmPizzaPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet7.SPObtenerDetallesPizza' Puede moverla o quitarla según sea necesario.
            this.sPObtenerDetallesPizzaTableAdapter1.Fill(this.pizzeriaFDataSet7.SPObtenerDetallesPizza);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet6.SPObtenerDetallesPizza' Puede moverla o quitarla según sea necesario.
            this.sPObtenerDetallesPizzaTableAdapter.Fill(this.pizzeriaFDataSet6.SPObtenerDetallesPizza);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet3.INGREDIENTEEXTRA' Puede moverla o quitarla según sea necesario.
            this.iNGREDIENTEEXTRATableAdapter.Fill(this.pizzeriaFDataSet3.INGREDIENTEEXTRA);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet3.ESPECIALIDAD' Puede moverla o quitarla según sea necesario.
            this.eSPECIALIDADTableAdapter.Fill(this.pizzeriaFDataSet3.ESPECIALIDAD);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet3.TAMAÑO' Puede moverla o quitarla según sea necesario.
            this.tAMAÑOTableAdapter.Fill(this.pizzeriaFDataSet3.TAMAÑO);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CONEXION.Open();
            SqlCommand ALTAS = new SqlCommand("insert into PIZZA(idTamaño,idEspecialidad,Comentarios,CantidadPizzas,idIngredienteExtra,CantidadExtra)" +
               "values (@idTamaño,@idEspecialidad,@Comentarios,@CantidadPizzas,@idIngredienteExtra,@CantidadExtra)", CONEXION);

            // Obtener el ID del tamaño seleccionado
            int idTamañoSeleccionado = (int)cbTam.SelectedValue;

            // Obtener el ID de la especialidad seleccionada
            int idEspecialidadSeleccionada = (int)cbEspe.SelectedValue;

            // Obtener el ID del ingrediente extra seleccionado
            int idIngredienteExtraSeleccionado = (int)cbExtra.SelectedValue;

            // Luego puedes utilizar estos IDs en lugar de los valores de los ComboBoxes en tus parámetros SQL
            ALTAS.Parameters.AddWithValue("idTamaño", idTamañoSeleccionado);
            ALTAS.Parameters.AddWithValue("idEspecialidad", idEspecialidadSeleccionada);
            ALTAS.Parameters.AddWithValue("Comentarios", txtComentarios.Text);
            ALTAS.Parameters.AddWithValue("CantidadPizzas", txtCantidadPIZZAS.Text);
            ALTAS.Parameters.AddWithValue("idIngredienteExtra", idIngredienteExtraSeleccionado);
            ALTAS.Parameters.AddWithValue("CantidadExtra", txtCantidadExtra.Text);


            try
            {

                ALTAS.ExecuteNonQuery();
                LLENAR();
                MessageBox.Show("PIZZA AGREGADA AL PEDIDO");
                LIMPIAR();

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE REGISTRO");
            }
            CONEXION.Close();

        }
    }
}
