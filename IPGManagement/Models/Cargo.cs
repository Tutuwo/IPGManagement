using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGManagement.Models
{
    public class Cargo
    {
        public int IdCargo { get; set; }

        public string NomeCargo { get; set; }

        public int RankHierarquia { get; set; }

        public string Descricao { get; set; }
    }
}
