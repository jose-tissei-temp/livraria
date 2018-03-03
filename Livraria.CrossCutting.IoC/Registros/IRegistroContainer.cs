using Livraria.CrossCutting.IoC.Container;

namespace Livraria.CrossCutting.IoC.Registros
{
    public interface IRegistroContainer
    {
        void Registrar(IServicesContainer servicesContainer);
    }
}