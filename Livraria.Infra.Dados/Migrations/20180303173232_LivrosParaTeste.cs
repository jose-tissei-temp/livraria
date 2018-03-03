using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Livraria.Dominio.Models;
using Livraria.Infra.Dados.Contexto;

namespace Livraria.Infra.Dados.Migrations
{
    public partial class LivrosParaTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var db = new LivrariaContexto())
            {
                db.Livros.AddRange(
                    new Livro { Titulo = "Harry Potter e a Pedra Filosofal" },
                    new Livro { Titulo = "O Hobbit" }
                );
                db.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
