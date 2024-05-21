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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PizzeriaPerez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
    //Conexion con SQL
    SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

    frmMenuPrincipal MENU = new frmMenuPrincipal();

        //Entrar al sistema
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM USUARIO WHERE  idUsuario = @idUsuario AND Contraseña = @Contraseña", CONEXION);
                cmd.Parameters.AddWithValue("@idUsuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContra.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count == 1)
                {
                    SqlCommand cmdRol = new SqlCommand("SELECT Tipo FROM USUARIO WHERE idUsuario = @idUsuario", CONEXION);
                    cmdRol.Parameters.AddWithValue("@idUsuario", txtUsuario.Text);
                    string tipoRol = cmdRol.ExecuteScalar().ToString();

                    if (tipoRol == "Administrador")
                    {
                        MessageBox.Show("Inicio de sesión exitoso como Administrador");
                        MENU.btnAdministrar.Enabled = true;
                        MENU.lblUser.Text = "Administrador";
                        MENU.Show();
                    }
                    else if (tipoRol == "Empleado")
                    {
                        MessageBox.Show("Inicio de sesión exitoso como Empleado");
                        MENU.btnAdministrar.Enabled = false;
                        MENU.lblUser.Text = "Empleado";
                        MENU.Show();
                    }
                }
                else if (count == 0)
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto(s).");
                    txtContra.Clear();
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("Error: Múltiples usuarios encontrados con las mismas credenciales.");
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtContra.UseSystemPasswordChar = true;
            }
        }
    }
}