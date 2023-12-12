using Koop.DAL;
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
    public partial class FormProcedimientos : Form
    {
        public FormProcedimientos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }private void button2_Click(object sender, EventArgs e)

        {
            FormProcedimientos formProcedimientos = new FormProcedimientos();
            formProcedimientos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCausaCancelacionProcedimientos formCausaCancelacionProcedimientos = new FormCausaCancelacionProcedimientos();
            formCausaCancelacionProcedimientos.Show();
        }

        private void BtnCancelado_Click(object sender, EventArgs e)
        {
            FormCausaCancelacionProcedimientos formCausaCancelacionProcedimientos = new FormCausaCancelacionProcedimientos();
            formCausaCancelacionProcedimientos.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FormProcedimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBSistemaDataSet1._Table_' Puede moverla o quitarla según sea necesario.
            this.table_TableAdapter.Fill(this.dBSistemaDataSet1._Table_);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
