using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmTarjeta : Form
    {
        public frmTarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el textbox está vacío
                if (string.IsNullOrEmpty(CantidadTarjeta.Text))
                {
                    throw new Exception("Por favor, ingrese la cantidad de tarjeta.");
                }

                // Llamado a la forma de ticket
                frmTicket ticket = new frmTicket();

                // Mostrar el formulario de ticket
                ticket.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
