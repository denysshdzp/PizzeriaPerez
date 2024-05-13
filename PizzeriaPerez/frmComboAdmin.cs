using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            SqlDataAdapter DA = new SqlDataAdapter("SP_MOSTRARCOMBO", CONEXION);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;


        }
        private void frmComboAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet3.COMBO' Puede moverla o quitarla según sea necesario.
            this.cOMBOTableAdapter.Fill(this.pizzeriaFDataSet3.COMBO);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Empieza la conexion
            CONEXION.Open();
            //Se ponen los parametros de la tabla que seran alimentados a traves de los txt
            SqlCommand ALTAS = new SqlCommand("insert into COMBO(NombreCombo,Descripcion,PrecioCombo)" +
               "values (@NombreCombo,@Descripcion,@PrecioCombo)", CONEXION);


            //Se manda la informacion a la tabla
            ALTAS.Parameters.AddWithValue("NombreCombo", txtNombre.Text);
            ALTAS.Parameters.AddWithValue("Descripcion", txtDescripcion.Text);
            ALTAS.Parameters.AddWithValue("PrecioCombo", txtPrecio.Text);

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
                    MessageBox.Show("Combo dado de alta");
                    LIMPIAR();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE REGISTRO");
            }

            CONEXION.Close();
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            string baja = "DELETE FROM COMBO WHERE idCombo=@idCombo";
            CONEXION.Open();


            SqlCommand cmdIns = new SqlCommand(baja, CONEXION);
            cmdIns.Parameters.Add("idCombo", txtIdCombo.Text);
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
            txtIdCombo.Clear();

            CONEXION.Close();
            MessageBox.Show("Combo eliminado");
            // limpiar los textbox
            LLENAR();
            LIMPIAR();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Comando actualizar atraves de un ID ya existente
            SqlCommand Actualizar = new SqlCommand("UPDATE COMBO SET NombreCombo=@NombreCombo, Descripcion=@Descripcion, PrecioCombo=@PrecioCombo WHERE idCombo=@idCombo", CONEXION);

            // Actualizar parametros en el DataGridView
            Actualizar.Parameters.AddWithValue("@NombreCombo", txtNombre.Text);
            Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            Actualizar.Parameters.AddWithValue("@PrecioCombo", txtPrecio.Text);
            Actualizar.Parameters.AddWithValue("idCombo", txtIdCombo.Text);

            CONEXION.Open(); // Abrir la conexión

            Actualizar.ExecuteNonQuery(); // Ejecutar la consulta

            CONEXION.Close(); // Cerrar la conexión

            MessageBox.Show("Combo Modificado.");

            // Limpiar los textbox
            LLENAR();
            LIMPIAR();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Conexion abierta
            CONEXION.Open();
            LLENAR();

            //Consultar atraves del ID de la tabla
            String Consulta = "select * from COMBO where idCombo =" + txtIdCombo.Text;
            SqlCommand cmdConsulta = new SqlCommand(Consulta, CONEXION);

            //Excepciones
            try
            {
                SqlCommand Consultar = CONEXION.CreateCommand();
                Consultar.CommandText = "select * from COMBO where idCombo =" + txtIdCombo.Text;
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
    }
}
