using Livraria.Aplicacao.Services;
using Livraria.CrossCutting.IoC.Container;

namespace Livraria.CrossCutting.IoC.Registros
{
    public class RegistroAplicacao : IRegistroContainer
    {
        public void Registrar(IServicesContainer servicesContainer)
        {
            servicesContainer.AddScoped<ILivrosService, LivrosService>();
        }
    }
}