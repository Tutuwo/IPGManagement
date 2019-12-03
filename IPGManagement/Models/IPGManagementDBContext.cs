using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IPGManagement.Models;

namespace IPGManagement.Models
{
    public class IPGManagementDBContext : DbContext
    {
        public IPGManagementDBContext(DbContextOptions<IPGManagementDBContext> options)
            : base(options)
        {
        }

        public DbSet<IPGManagement.Models.Funcionario> Funcionarios { get; set; }

        public DbSet<IPGManagement.Models.Cargo> Cargos { get; set; }

        public DbSet<IPGManagement.Models.Departamento> Departamentos { get; set; }

        public DbSet<IPGManagement.Models.Horario> Horarios { get; set; }


    }
}
