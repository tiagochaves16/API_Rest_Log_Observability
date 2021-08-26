﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProduto.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Estoque", "Nome", "Preco" },
                values: new object[] { 1, 10, "Caderno", 7.95m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Estoque", "Nome", "Preco" },
                values: new object[] { 2, 30, "Borracha", 2.45m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Estoque", "Nome", "Preco" },
                values: new object[] { 3, 15, "Estojo", 6.25m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
