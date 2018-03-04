using Livraria.CrossCutting.IoC.Container;
using Livraria.CrossCutting.IoC.Registros;

namespace Livraria.CrossCutting.IoC.Tests.Container
{
    public class RegistroFake : IRegistroContainer
    {
        public void Registrar(IServicesContainer servicesContainer)
        {
            servicesContainer.AddScoped<IRegistroContainer, RegistroFake>();
        }
    }
}