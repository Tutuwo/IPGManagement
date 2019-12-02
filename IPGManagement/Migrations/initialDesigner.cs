using IPGManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGManagement.Migrations
{
    
        [DbContext(typeof(IPGManagementDbContext))]
        [Migration("20191106145416_initial")]
        partial class initial
        {
            protected override void BuildTargetModel(ModelBuilder modelBuilder)
            {
#pragma warning disable 612, 618
                modelBuilder
                    .HasAnnotation("ProductVersion", "3.0.0")
                    .HasAnnotation("Relational:MaxIdentifierLength", 128)
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                modelBuilder.Entity("IPGManagement.Models.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionarios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(60);

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(8);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(1);
                        

                    b.HasKey("IdFuncionarios");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
            }
        }
    
}
