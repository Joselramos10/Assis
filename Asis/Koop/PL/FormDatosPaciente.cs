using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Koop.DAL;
using Koop.BLL;
using System.Data.Odbc;

namespace Koop.PL
{
    public partial class FormDatosPaciente : Form
    {
        public FormDatosPaciente()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            FormIndiceCharlson FormIndiceCharlson = new FormIndiceCharlson();
            FormIndiceCharlson.Show();
        }

        private void BtnSolInterconsulta_Click(object sender, EventArgs e)
        {
            FormInterconsulta formInterconsulta = new FormInterconsulta();
            formInterconsulta.Show();
        }

        private void BtnCEP_Click(object sender, EventArgs e)
        {
            FormCausaEstanciaProlongada formCausaEstanciaProlongada = new FormCausaEstanciaProlongada();
            formCausaEstanciaProlongada.Show();
        }

        private void btnNvoProcedimiento_Click(object sender, EventArgs e)
        {
            FormProcedimientos formFormSolicitudDeProcedimientos = new FormProcedimientos();
            formFormSolicitudDeProcedimientos.Show();

        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            RecuperarInformacion();
            ConexionDAL conexion = new ConexionDAL();
            MessageBox.Show("Conectado.." + conexion.ejecutarComandoSinRetornoDatos("INSERT INTO DatosPaciente Identificacion,Edad,Sexo,EAPB,FIngreso,Procedencia,FEgreso,EstadoEgreso,Tipo,IndiceCharlson,GRR,CEstanciaProl,EspTratante,PrcSolicitado,ObservacionEstancia) VALUES(@Identificacion, @Edad, @Sexo, @EAPB, @FIngreso, @Procedencia, @FEgreso, @EstadoEgreso, @Tipo, @IndiceCharlson, @GRR, @CEstanciaProl, @EspTratante, @PrcSolicitado, @ObservacionEstancia')"));
            
        }

        private DatosPacienteBLL RecuperarInformacion()
        {
            DatosPacienteBLL oDatosPacienteBLL = new DatosPacienteBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDatosPacienteBLL.ID = ID;
            oDatosPacienteBLL.Identificacion = txtIdentificacion.Text;
            oDatosPacienteBLL.Edad = int.Parse(txtEdad.Text);
            oDatosPacienteBLL.Sexo = cmbSexo.Text;
            oDatosPacienteBLL.EAPB = cmbEAPB.Text;
            oDatosPacienteBLL.FIngreso = DtpIngreso.Value;
            oDatosPacienteBLL.Procedencia = cmbProcedencia.Text;
            oDatosPacienteBLL.FEgreso=DtpEgreso.Value;
            oDatosPacienteBLL.EstadoEgreso= CmbEEgreso.Text;
            oDatosPacienteBLL.Tipo = CmbTEgreso.Text;
            oDatosPacienteBLL.IndiceCharlson=txtICharlson.Text;
            oDatosPacienteBLL.GRR = CmbGRD.Text;
            oDatosPacienteBLL.EspTratante=cmbEspPTratante.Text;

            //MessageBox.Show(oDatosPaciente.ID.ToString());
            //MessageBox.Show(oDatosPaciente.Identificacion);
            //MessageBox.Show("Registro guardado");

            return oDatosPacienteBLL;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar FormBuscar = new FormBuscar();
            FormBuscar.Show();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void FormDatosPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'codigos_CUPSDataSet.CodigosCUPS' Puede moverla o quitarla según sea necesario.
            this.codigosCUPSTableAdapter.Fill(this.codigos_CUPSDataSet.CodigosCUPS);
            // TODO: esta línea de código carga datos en la tabla 'dBSistemaDataSet.DatosPaciente' Puede moverla o quitarla según sea necesario.
            this.datosPacienteTableAdapter.Fill(this.dBSistemaDataSet.DatosPaciente);

        }*/
    }
}
