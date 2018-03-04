using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Livraria.CrossCutting.IoC.Container;
using Livraria.CrossCutting.IoC.Registros;
using NSubstitute;
using Xunit;

namespace Livraria.CrossCutting.IoC.Tests.Container
{
    public class ServicesContainerExtensionsTests
    {
        [Fact]
        public void Deve_carregar_todos_os_registros_no_container()
        {
            var tipos = new []
            {
                typeof(RegistroFake),
                typeof(FakeAbstractClass),
                typeof(IRegistroContainer)
            };
            var services = Substitute.For<IServicesContainer>();
            services.CarregarRegistros(tipos);

            services.ReceivedCalls().Should().ContainSingle();
            services.Received(1).AddScoped<IRegistroContainer, RegistroFake>();
        }
    }
}
