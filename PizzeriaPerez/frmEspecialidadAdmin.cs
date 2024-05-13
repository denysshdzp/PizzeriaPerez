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
            // TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet1.ESPECIALIDAD' Puede moverla o quitarla según sea necesario.
            this.eSPECIALIDADTableAdapter.Fill(this.pizzeriaFDataSet1.ESPECIALIDAD);

        }
        //Conexion con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=LAPTOP-PTEQ4GGC;Initial Catalog=PizzeriaF;Integrated Security=True");

        //Metodo para limpiar
        public void LIMPIAR()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioExtra.Clear();
            txtNombre.Focus();

        }

        //Llenar la tabla
        public void LLENAR()
        {

            SqlDataAdapter DA = new SqlDataAdapter("SP_MOSTRARESP", CONEXION);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Empieza la conexion
            CONEXION.Open();
            //Se ponen los parametros de la tabla ESPECIALIDAD que seran alimentados a traves de los txt
            SqlCommand ALTAS = new SqlCommand("insert into ESPECIALIDAD(Nombre,Descripcion,CostoExtra)" +
               "values (@Nombre,@Descripcion,@CostoExtra)", CONEXION);


            //Se manda la informacion a la tabla
            ALTAS.Parameters.AddWithValue("Nombre", txtNombre.Text);
            ALTAS.Parameters.AddWithValue("Descripcion", txtDescripcion.Text);
            ALTAS.Parameters.AddWithValue("CostoExtra", txtPrecioExtra.Text);

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
                else if (txtPrecioExtra.Text == null)
                {
                    MessageBox.Show("Llenar el campo de precio.");
                    txtPrecioExtra.Focus();
                }
                else
                {
                    ALTAS.ExecuteNonQuery();
                    LLENAR();
                    MessageBox.Show("Especialidad dado de alta");
                    LIMPIAR();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE REGISTRO");
            }

            CONEXION.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string baja = "DELETE FROM ESPECIALIDAD WHERE idEspecialidad=@idEspecialidad";
            CONEXION.Open();


            SqlCommand cmdIns = new SqlCommand(baja, CONEXION);
            cmdIns.Parameters.Add("idEspecialidad", txtIdEspecialidad.Text);
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
            txtIdEspecialidad.Clear();

            CONEXION.Close();
            MessageBox.Show("Especialidad eliminada");
            // limpiar los textbox
            LLENAR();
            LIMPIAR();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Comando actualizar atraves de un ID ya existente
            SqlCommand Actualizar = new SqlCommand("UPDATE ESPECIALIDAD SET Nombre=@Nombre, Descripcion=@Descripcion, CostoExtra=@CostoExtra WHERE idEspecialidad=@idEspecialidad", CONEXION);

            // Actualizar parametros en el DataGridView
            Actualizar.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            Actualizar.Parameters.AddWithValue("@CostoExtra", txtPrecioExtra.Text);
            Actualizar.Parameters.AddWithValue("@idEspecialidad", txtIdEspecialidad.Text);

            CONEXION.Open(); // Abrir la conexión

            Actualizar.ExecuteNonQuery(); // Ejecutar la consulta

            CONEXION.Close(); // Cerrar la conexión

            MessageBox.Show("Especialidad Modificada.");

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
            String Consulta = "select * from ESPECIALIDAD where idEspecialidad =" + txtIdEspecialidad.Text;
            SqlCommand cmdConsulta = new SqlCommand(Consulta, CONEXION);

            //Excepciones
            try
            {
                SqlCommand Consultar = CONEXION.CreateCommand();
                Consultar.CommandText = "select * from ESPECIALIDAD where idEspecialidad =" + txtIdEspecialidad.Text;
                Consultar.ExecuteNonQuery();

                LLENAR();


                SqlDataReader Reade = cmdConsulta.ExecuteReader();
                Reade.Read();
                txtNombre.Text = Reade.GetValue(1).ToString();
                txtDescripcion.Text = Reade.GetValue(2).ToString();
                txtPrecioExtra.Text = Reade.GetValue(3).ToString();
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
