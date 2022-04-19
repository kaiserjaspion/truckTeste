using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using Teste.Volvo.Gerenciamento.Controllers;
using Teste.Volvo.Gerenciamento.Models;
using Teste.Volvo.Gerenciamento.Teste.Mocks;

namespace Teste.Volvo.Gerenciamento.Teste
{
    [TestClass]
    public class TruckControllerTest
    {

        [TestMethod]
        public async Task TestGet()
        {
            var result = await new TruckController(new MockService().getMockService()).List();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task TestEdit()
        {
            var truck = new Mock<Truck>();
            Assert.AreEqual(true, await new TruckController(new MockService().getMockService()).Edit(truck.Object));
        }

        [TestMethod]
        public async Task TestDelete()
        {
            var truck = new Mock<Truck>();
            Assert.AreEqual(true,await new TruckController(new MockService().getMockService()).Delete(truck.Object.Id));
        }
    }
}
