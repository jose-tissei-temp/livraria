using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Livraria.Aplicacao.ViewModels;
using Livraria.Dominio.Models;

namespace Livraria.Aplicacao.Mapeamentos
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Livro, LivroViewModel>().ReverseMap();
        }
    }
}
