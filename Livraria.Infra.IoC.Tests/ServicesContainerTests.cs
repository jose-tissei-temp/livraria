using Xunit;

namespace Livraria.Infra.IoC.Tests
{
    public class ServicesContainerTests
    {
        [Fact(Skip = "TODO")]
        public void Deve_ser_possivel_de_resolver_todos_os_objetos_do_container()
        {
            // Na maioria dos outros containers (Nunit, Ninject, AutoFac..) esse teste é simples de se fazer
            // porém o container nativo do aspnet core, injeta varios componentes processo de criação
            // do service provider, que não podem ser resolvidos fora do contexto da aplicação mvc.
        }
    }
}
