using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IPGManagement.Models
{
    public class IPGManagementDbContext : DbContext
    {
        public IPGManagementDbContext(DbContextOptions<IPGManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<IPGManagement.Models.Funcionario> Funcionarios { get; set; }
        public object Funcionario { get; internal set; }
    }
}
