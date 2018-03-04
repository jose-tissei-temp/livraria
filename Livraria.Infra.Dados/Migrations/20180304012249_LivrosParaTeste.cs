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
                    new Livro
                    {
                        Titulo = "Harry Potter e a Pedra Filosofal",
                        Autor = "J.K. Rowling",
                        Estoque = 1
                    },
                    new Livro
                    {
                        Titulo = "O Hobbit",
                        Autor = "J.R.R. Tolkien",
                        Estoque = 2
                    },
                    new Livro
                    {
                        Titulo = "As Crônicas de Gelo e Fogo: A Guerra dos Tronos",
                        Autor = "George R.R. Martin",
                        Estoque = 0
                    }
                );
                db.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
