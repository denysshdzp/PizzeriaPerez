using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class frmCombosPedido : Form
    {
        public frmCombosPedido()
        {
            InitializeComponent();
        }

        private void frmCombosPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet11.SPObtenerDetallesCombo' Puede moverla o quitarla según sea necesario.
            this.sPObtenerDetallesComboTableAdapter1.Fill(this.pizzeriaFDataSet11.SPObtenerDetallesCombo);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet10.SPObtenerDetalleCombo' Puede moverla o quitarla según sea necesario.
            //this.sPObtenerDetalleComboTableAdapter.Fill(this.pizzeriaFDataSet10.SPObtenerDetalleCombo);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet9.SPObtenerDetallesCombo' Puede moverla o quitarla según sea necesario.
            this.sPObtenerDetallesComboTableAdapter.Fill(this.pizzeriaFDataSet9.SPObtenerDetallesCombo);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet3.INGREDIENTEEXTRA' Puede moverla o quitarla según sea necesario.
            this.iNGREDIENTEEXTRATableAdapter.Fill(this.pizzeriaFDataSet3.INGREDIENTEEXTRA);
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet8.COMBO' Puede moverla o quitarla según sea necesario.
            this.cOMBOTableAdapter.Fill(this.pizzeriaFDataSet8.COMBO);

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

            SqlDataAdapter DA = new SqlDataAdapter("SPObtenerDetallesCombo", CONEXION);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CONEXION.Open();
            SqlCommand ALTAS = new SqlCommand("insert into COMBOPEDIDO(idCombo,Comentarios,idIngredienteExtra,CantidadExtra)" +
               "values (@idCombo,@Comentarios,@idIngredienteExtra,@CantidadExtra)", CONEXION);

            // Obtener el ID del tamaño seleccionado
            int idComboPedido= (int)cbCombo.SelectedValue;

            // Obtener el ID del ingrediente extra seleccionado
            int idIngredienteExtraSeleccionado = (int)cbExtra.SelectedValue;

            // Luego puedes utilizar estos IDs en lugar de los valores de los ComboBoxes en tus parámetros SQL
            ALTAS.Parameters.AddWithValue("idCombo", idComboPedido);
            ALTAS.Parameters.AddWithValue("Comentarios", txtComentarios.Text);
            ALTAS.Parameters.AddWithValue("idIngredienteExtra", idIngredienteExtraSeleccionado);
            ALTAS.Parameters.AddWithValue("CantidadExtra", txtCantidadExtra.Text);


            try
            {

                ALTAS.ExecuteNonQuery();
                LLENAR();
                MessageBox.Show("COMBO AGREGADA AL PEDIDO");
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
