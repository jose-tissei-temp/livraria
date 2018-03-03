using Livraria.CrossCutting.IoC.Container;
using Livraria.Dominio.Dados;
using Livraria.Infra.Dados.Contexto;
using Livraria.Infra.Dados.Repositorios;

namespace Livraria.CrossCutting.IoC.Registros
{
    public class RegistroDados : IRegistroContainer
    {
        public void Registrar(IServicesContainer servicesContainer)
        {
            servicesContainer.AddDbContext<LivrariaContexto>();
            servicesContainer.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));
        }
    }
}