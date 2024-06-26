﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmTamañoAdmin : Form
    {
        public frmTamañoAdmin()
        {
            InitializeComponent();
        }

        // Conexión con SQL
        SqlConnection CONEXION = new SqlConnection("Data Source=DESKTOP-8RBGU1S;Initial Catalog=PizzeriaF;Integrated Security=True");

        // Método para limpiar
        public void LIMPIAR()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        // Llenar la tabla
        public void LLENAR()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter("SP_MOSTRARTAMA", CONEXION);
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
                SqlCommand ALTAS = new SqlCommand("insert into TAMAÑO(Nombre, Descripcion, Precio) values (@Nombre, @Descripcion, @Precio)", CONEXION);
                ALTAS.Parameters.AddWithValue("Nombre", txtNombre.Text);
                ALTAS.Parameters.AddWithValue("Descripcion", txtDescripcion.Text);
                ALTAS.Parameters.AddWithValue("Precio", txtPrecio.Text);

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Llenar el campo Nombre");
                    txtNombre.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Llenar el campo de descripcion.");
                    txtDescripcion.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtPrecio.Text))
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE REGISTRO: " + ex.Message);
            }
            finally
            {
                CONEXION.Close();
            }
        }

        private void frmTamañoAdmin_Load(object sender, EventArgs e)
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
        private void bnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string baja = "DELETE FROM TAMAÑO WHERE idTamaño=@idTamaño";
                CONEXION.Open();
                SqlCommand cmdIns = new SqlCommand(baja, CONEXION);
                cmdIns.Parameters.AddWithValue("idTamaño", txtidTamaño.Text);
                cmdIns.ExecuteNonQuery();
                txtidTamaño.Clear();
                MessageBox.Show("Tamaño eliminado");
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
                CONEXION.Open();
                string Consulta = "select * from TAMAÑO where idTamaño =" + txtidTamaño.Text;
                SqlCommand cmdConsulta = new SqlCommand(Consulta, CONEXION);
                SqlDataReader Reade = cmdConsulta.ExecuteReader();
                if (Reade.Read())
                {
                    txtNombre.Text = Reade.GetValue(1).ToString();
                    txtDescripcion.Text = Reade.GetValue(2).ToString();
                    txtPrecio.Text = Reade.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("Id no encontrado, intente de nuevo");
                    LIMPIAR();
                }
                Reade.Close();
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
                SqlCommand Actualizar = new SqlCommand("UPDATE TAMAÑO SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio WHERE idTamaño=@idTamaño", CONEXION);
                Actualizar.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                Actualizar.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                Actualizar.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                Actualizar.Parameters.AddWithValue("@idTamaño", txtidTamaño.Text);

                CONEXION.Open();
                Actualizar.ExecuteNonQuery();
                MessageBox.Show("Tamaño Modificado.");
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

