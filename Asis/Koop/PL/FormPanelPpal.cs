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
    public partial class FormPanelPpal : Form
    {
        public FormPanelPpal()
        {
            InitializeComponent();
        }

        private void AbrirFormInicioInPanel(object Formhijo)

        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void BtnDatosPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormInicioInPanel(new FormDatosPaciente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInicioInPanel(new FormIndicadores());
        }
    }
}
