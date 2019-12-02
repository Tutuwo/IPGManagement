using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGManagement.Models
{
    public class Horario
    {
        public int IdHorario { get; set; }

        public DateTime HInicio { get; set; }

        public DateTime HInicioIntervalo { get; set; }

        public DateTime HFimIntervalo { get; set; }

        public DateTime HFim { get; set; }
    }
}
