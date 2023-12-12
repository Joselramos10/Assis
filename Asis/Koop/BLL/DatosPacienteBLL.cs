using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koop.BLL;


namespace Koop.BLL
{
    class DatosPacienteBLL
    {
        public int ID { get; set; }
        public string Identificacion { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string EAPB { get; set; }
        public DateTime FIngreso { get; set; }
        public string Procedencia { get; set; }
        public DateTime FEgreso { get; set; }
        public string EstadoEgreso { get; set; }
        public string Tipo { get; set; }
        public string IndiceCharlson { get; set; }
        public string GRR { get; set; }
        public string CEstanciaProl { get; set; }
        public string EspTratante { get; set; }
        public string PrcSolicitado { get; set; }
        public string ObservacionEstancia { get; set; }
        
    }
}
