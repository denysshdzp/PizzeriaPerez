using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaPerez
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        //Codigo para mostrar en el panel
        //Codigo para abrir las formas en el menu principal
        public void AbrirFormEnPanel(object formhija)
        {
            if (this.pContenido.Controls.Count > 0)
                this.pContenido.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenido.Controls.Add(fh);
            this.pContenido.Tag = fh;
            fh.Show();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Llamado a las formas
        frmPizzaPedido pizza = new frmPizzaPedido();
        frmCombosPedido combo = new frmCombosPedido();
        frmComplementosPedido complementosPedido = new frmComplementosPedido();
        frmMenuAdmin menuadmin = new frmMenuAdmin();
        //Salir
        private void bnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPizzaPedido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPizzaPedido());
        }

        private void btnComboPedido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCombosPedido());
        }

        private void btnComplementoPedido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmComplementosPedido());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmMenuAdmin());
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'pizzeriaFDataSet13.SPObtenerTicket' Puede moverla o quitarla según sea necesario.
            //this.sPObtenerTicketTableAdapter.Fill(this.pizzeriaFDataSet13.SPObtenerTicket);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
