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
    public partial class frmFormaDePago : Form
    {
        public frmFormaDePago()
        {
            InitializeComponent();
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de tam
            frmTicket tick = new frmTicket();
            //Mostrarla
            tick.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de tam
            frmTarjeta tar = new frmTarjeta();
            //Mostrarla
            tar.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
