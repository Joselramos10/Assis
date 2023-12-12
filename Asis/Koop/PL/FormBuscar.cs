using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koop.PL
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        /*private void AbrirFormInicioInPanel(object Formhijo)

        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }*/

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
           // AbrirFormInicioInPanel(new FormDatosPaciente());
        }

        /*private void BtnCEP_Click(object sender, EventArgs e)
        {
            FormCausaEstanciaProlongada formCausaEstanciaProlongada = new FormCausaEstanciaProlongada();
            formCausaEstanciaProlongada.Show();
        }

        private void BtnSolInterconsulta_Click(object sender, EventArgs e)
        {
            FormInterconsulta formInterconsulta = new FormInterconsulta();
            formInterconsulta.Show();
        }

        private void btnNvoProcedimiento_Click(object sender, EventArgs e)
        {
            FormSolicitudDeProcedimientos formFormSolicitudDeProcedimientos = new FormSolicitudDeProcedimientos();
            formFormSolicitudDeProcedimientos.Show();
        }*/

        private void BtnCEP_Click_1(object sender, EventArgs e)
        {
            FormCausaEstanciaProlongada formCausaEstanciaProlongada = new FormCausaEstanciaProlongada();
            formCausaEstanciaProlongada.Show();
        }

        private void BtnSolInterconsulta_Click_1(object sender, EventArgs e)
        {
            FormInterconsulta formInterconsulta = new FormInterconsulta();
            formInterconsulta.Show();
        }

        private void btnNvoProcedimiento_Click_1(object sender, EventArgs e)
        {
            FormProcedimientos formFormSolicitudDeProcedimientos = new FormProcedimientos();
            formFormSolicitudDeProcedimientos.Show();
        }
    }
}
