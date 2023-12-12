using Koop.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koop.DAL
{
    class DatosPacientesDAL
    {
        ConexionDAL conexion;

        public DatosPacientesDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool Agregar(DatosPacienteBLL odatosPacientesBLL)
        {
            
            String sql = "INSERT INTO DatosPaciente Identificacion,Edad,Sexo,EAPB,FIngreso,Procedencia,FEgreso,EstadoEgreso,Tipo,IndiceCharlson,GRR,CEstanciaProl,EspTratante,PrcSolicitado,ObservacionEstancia) VALUES(@Identificacion, @Edad, @Sexo, @EAPB, @FIngreso, @Procedencia, @FEgreso, @EstadoEgreso, @Tipo, @IndiceCharlson, @GRR, @CEstanciaProl, @EspTratante, @PrcSolicitado, @ObservacionEstancia')";
            DatosPacienteBLL dp = odatosPacientesBLL;
            SqlConnection cnn = conexion.EstablecerConexion();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Identificacion", dp.Identificacion);
            cmd.Parameters.AddWithValue("@Edad", dp.Edad);
            cmd.Parameters.AddWithValue("@Sexo", dp.Sexo);
            cmd.Parameters.AddWithValue("@EAPB", dp.EAPB);
            cmd.Parameters.AddWithValue("@FIngreso", dp.FIngreso);
            cmd.Parameters.AddWithValue("@Procedencia", dp.Procedencia);
            cmd.Parameters.AddWithValue("@FEgreso", dp.FEgreso);
            cmd.Parameters.AddWithValue("@EEgreso", dp.EstadoEgreso);
            cmd.Parameters.AddWithValue("@Tipo", dp.Tipo);
            cmd.Parameters.AddWithValue("@ICharlson", dp.IndiceCharlson);
            cmd.Parameters.AddWithValue("@GRR", dp.GRR);
            cmd.Parameters.AddWithValue("@CEProlongada", dp.CEstanciaProl);
            cmd.Parameters.AddWithValue("@EspTratante", dp.EspTratante);
            cmd.Parameters.AddWithValue("@PSolicitado", dp.PrcSolicitado);
            cmd.Parameters.AddWithValue("@ObservacionEst", dp.ObservacionEstancia);

            bool rta = (int)cmd.ExecuteNonQuery() > 0;
            cnn.Close();
            return rta;
        }
        public DataSet MostrarDatosPaciente()

        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM DatosPaciente");
            return conexion.EjecutarSentencia(sentencia);
        }
        public int Eliminar(DatosPacienteBLL odatosPacienteBLL)
        {
            conexion.ejecutarComandoSinRetornoDatos("DELETE FROM DatosPacientes WHERE ID=" + odatosPacienteBLL.ID);
            return 1;
        }
    }
}