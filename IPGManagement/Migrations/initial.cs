using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPGManagement.Migrations
{
    
        public partial class initial : Migration
        {
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.CreateTable(
                    name: "Funcionarios",
                    columns: table => new
                    {
                        IdFuncionarios = table.Column<int>(nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        NomeFuncionario = table.Column<string>(maxLength: 60, nullable: false),
                        DataNascimento = table.Column<string>(nullable: false),
                        Sexo = table.Column<string>(nullable: false),
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Funionarios", x => x.IdFuncionarios);
                    });
            }

            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropTable(
                    name: "Funcionarios");
            }
        }
    
}
