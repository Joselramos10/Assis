using Koop.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koop
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Joser" && txtContrasena.Text == "Joser")
            {
               FormPanelPpal frmInicio = new FormPanelPpal();
               this.Hide();
               frmInicio.Show();
            }
            
            else 
            {
                MessageBox.Show("Los datos ingresados son incorrectos.");
                txtUsuario.Clear();
                txtContrasena.Clear();
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //txtUsuario.Clear();
            //txtContrasena.Clear();
            Application.Exit();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            //Application.Exit();
        //}
    }
}
