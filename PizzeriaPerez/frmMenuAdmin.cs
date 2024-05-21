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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnTamaño_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de tam
            frmTamañoAdmin tam = new frmTamañoAdmin();
            //Mostrarla
            tam.Show();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de especialidad
            frmEspecialidadAdmin esp = new frmEspecialidadAdmin();
            //Mostrarla
            esp.Show();
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de Ingrediente extra
            frmIngredienteExtraAdmin ex = new frmIngredienteExtraAdmin();
            //Mostrarla
            ex.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de combo
           frmComboAdmin combo = new frmComboAdmin();
            //Mostrarla
            combo.Show();
        }

        private void btnComplementos_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de complementos
            frmComplementosAdmin comple = new frmComplementosAdmin();
            //Mostrarla
            comple.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Llamado a la forma de promociones
            frmPromocionesAdmin prom = new frmPromocionesAdmin();
            //Mostrarla
            prom.Show();
        }
    }
}
