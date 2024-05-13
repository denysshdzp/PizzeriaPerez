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
    public partial class frmTamañoAdmin : Form
    {
        public frmTamañoAdmin()
        {
            InitializeComponent();
        }
   
        //Conexion con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=LAPTOP-PTEQ4GGC;Initial Catalog=PizzeriaF;Integrated Security=True");
       
        //Metodo para limpiar
        public void LIMPIAR()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
            
        }

        //Llenar la tabla
        public void LLENAR()
        {

            SqlDataAdapter DA = new SqlDataAdapter("SP_MOSTRARTAMA", CONEXION);
            //SqlDataAdapter rel = new SqlDataAdapter "SELECT * FROM Cliente ", CONEXION);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
        }

            //Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Empieza la conexion
            CONEXION.Open();
            //Se ponen los parametros de la tabla TAMANO que seran alimentados a traves de los txt
            SqlCommand ALTAS = new SqlCommand("insert into TAMAÑO(Nombre,Descripcion,Precio)" +
               "values (@Nombre,@Descripcion,@Precio)", CONEXION);


            //Se manda la informacion a la tabla
            ALTAS.Parameters.AddWithValue("Nombre", txtNombre.Text);
            ALTAS.Parameters.AddWithValue("Descripcion", txtDescripcion.Text);
            ALTAS.Parameters.AddWithValue("Precio", txtPrecio.Text);

            //Excepciones
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Llenar el campo Nombre");
                    txtNombre.Focus();
                }
                else if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Llenar el campo de descripcion.");

                    txtDescripcion.Focus();
                }
                else if (txtPrecio.Text == null)
                {
                    MessageBox.Show("Llenar el campo de precio.");
                    txtPrecio.Focus();
                }
                else
                {
                    ALTAS.ExecuteNonQuery();
                    LLENAR();
                    MessageBox.Show("Tamaño dado de alta");
                    LIMPIAR();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE REGISTRO");
            }

            CONEXION.Close();
        }

        private void frmTamañoAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet.TAMAÑO' Puede moverla o quitarla según sea necesario.
            this.tAMAÑOTableAdapter.Fill(this.pizzeriaFDataSet.TAMAÑO);

        }

        //Boton para eliminar
        private void bnEliminar_Click(object sender, EventArgs e)
        {
            string baja = "DELETE FROM TAMAÑO WHERE idTamaño=@idTamaño";
            CONEXION.Open();


            SqlCommand cmdIns = new SqlCommand(baja, CONEXION);
            cmdIns.Parameters.Add("idTamaño", txtidTamaño.Text);
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
            txtidTamaño.Clear();

            CONEXION.Close();
            MessageBox.Show("Tamaño eliminado");
            // limpiar los textbox
            LLENAR();
            LIMPIAR();
        }

        //Boton para consultar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Conexion abierta
            CONEXION.Open();
            LLENAR();

            //Consultar atraves del ID de la tabla
            String Consulta = "select * from TAMAÑO where idTamaño =" + txtidTamaño.Text;
            SqlCommand cmdConsulta = new SqlCommand(Consulta, CONEXION);

            //Excepciones
            try
            {
                SqlCommand Consultar = CONEXION.CreateCommand();
                Consultar.CommandText = "select * from TAMAÑO where idTamaño = '" + txtidTamaño.Text + "'";
                Consultar.ExecuteNonQuery();

                LLENAR();


                SqlDataReader Reade = cmdConsulta.ExecuteReader();
                Reade.Read();
                txtNombre.Text = Reade.GetValue(1).ToString();
                txtDescripcion.Text = Reade.GetValue(2).ToString();
                txtPrecio.Text = Reade.GetValue(3).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Id no encontrado, intente de nuevo");

                // limpiar los textbox
                LIMPIAR();
            }
            CONEXION.Close();


        }

        //Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Comando actualizar atraves de un ID ya existente
            SqlCommand Actualizar = new SqlCommand("UPDATE TAMAÑO SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio WHERE idTamaño=@idTamaño", CONEXION);

            // Actualizar parametros en el DataGridView
            Actualizar.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            Actualizar.Parameters.AddWithValue("@Precio", txtPrecio.Text);
            Actualizar.Parameters.AddWithValue("@idTamaño", txtidTamaño.Text);

            CONEXION.Open(); // Abrir la conexión

            Actualizar.ExecuteNonQuery(); // Ejecutar la consulta

            CONEXION.Close(); // Cerrar la conexión

            MessageBox.Show("Tamaño Modificado.");

            // Limpiar los textbox
            LLENAR();
            LIMPIAR();

        }
    }
}
