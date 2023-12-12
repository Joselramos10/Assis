using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koop.BLL
{
    internal class CancelacionDeProcedimientosBLL
    {
        public int ID { get; set; }
        public DateTime FReporte { get; set; }
        public string cmbCausaCancelacion { get; set; }
        public string txtCObservacion { get; set; }

    }
}
