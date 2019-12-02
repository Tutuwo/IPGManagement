using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPGManagement.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "Por favor, introduza o Id")]
        public int IdFuncionarios { get; set; }

        [Required(ErrorMessage = "Por favor, introduza o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, introduza a data")]
        public string DataNascimento { get; set; }

        [Required(ErrorMessage = "Por favor, introduza o género do funcionário")]
        public String Sexo { get; set; }

        public int IdCargo { get; set; }

        public int IdDepartamento { get; set; }

        public int IdHorario { get; set; }
    }
}
