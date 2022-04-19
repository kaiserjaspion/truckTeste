using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using Teste.Volvo.Gerenciamento.Models;
using Teste.Volvo.Gerenciamento.Services.Interfaces;
using Teste.Volvo.Gerenciamento.Teste.Mocks;


namespace Teste.Volvo.Gerenciamento.Teste
{
    [TestClass]
    public class TruckServiceTest
    {
        [TestMethod]
        public async Task TestGet()
        {
            Assert.IsNotNull(await new MockService().getMockService().GetTruckList());
        }

        [TestMethod]
        public async Task TestEdit()
        {
            var truck = new Mock<Truck>();
            Assert.IsTrue(await new MockService().getMockService().EditTruck(truck.Object));
        }

        [TestMethod]
        public async Task TestDelete()
        {
            var truck = new Mock<Truck>();
            Assert.IsTrue(await new MockService().getMockService().DeleteTruck(truck.Object.Id));
        }
    }
}