using Xunit;

namespace Livraria.Infra.IoC.Tests
{
    public class ServicesContainerTests
    {
        [Fact(Skip = "TODO")]
        public void Deve_ser_possivel_de_resolver_todos_os_objetos_do_container()
        {
            // Na maioria dos outros containers (Nunit, Ninject, AutoFac..) esse teste � simples de se fazer
            // por�m o container nativo do aspnet core, injeta varios componentes processo de cria��o
            // do service provider, que n�o podem ser resolvidos fora do contexto da aplica��o mvc.
        }
    }
}
