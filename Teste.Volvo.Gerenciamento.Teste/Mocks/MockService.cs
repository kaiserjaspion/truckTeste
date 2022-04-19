using System;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teste.Volvo.Gerenciamento.Services.Interfaces;
using Teste.Volvo.Gerenciamento.Contexts;
using Teste.Volvo.Gerenciamento.Controllers;
using Teste.Volvo.Gerenciamento.Models;
using Teste.Volvo.Gerenciamento.Services;
using System.Data.Entity.Infrastructure;
using Teste.Volvo.Gerenciamento.Teste.AsyncQuery;

namespace Teste.Volvo.Gerenciamento.Teste.Mocks
{
    public class MockService
    {
        public ITruckService getMockService()
        {
            var data = new List<Truck>
            {
                new Truck
                {
                    Id = Guid.Parse("695c24ca-7b90-4ade-9c06-615d7d94d3e4"),
                    Model ="FH",
                    ManufactureYear = Convert.ToDateTime("2022-04-19T18:29:25.655"),
                    ModelYear = Convert.ToDateTime("2022-01-01T03:00:00"),
                    IsActive =true,
                    Created = Convert.ToDateTime("2022-04-19T15:29:35.1854202"),
                    Change = Convert.ToDateTime("2022-04-19T15:29:35.1853589"),
                    ChangedBy ="Bruno"
                },
                new Truck
                {
                    Id = Guid.Parse("9d9322af-ef7a-47fb-b2d0-654b357ee285"),
                    Model ="FM",
                    ManufactureYear = Convert.ToDateTime("2022-01-01T03:00:00"),
                    ModelYear = Convert.ToDateTime("2023-01-01T03:00:00"),
                    IsActive = true,
                    Created = Convert.ToDateTime("2022-04-19T16:14:18.4355601"),
                    Change = Convert.ToDateTime("2022-04-19T16:14:18.4355375"),
                    ChangedBy = "Bruno"
                },
                new Truck
                {
                    Id = Guid.Parse("dbbd64f3-5f9d-41c3-bfe4-f4f2ffbea7d3"),
                    Model = "FH",
                    ManufactureYear = Convert.ToDateTime("2022-01-01T03:00:00"),
                    ModelYear = Convert.ToDateTime("2023-01-01T03:00:00"),
                    IsActive = true,
                    Created = Convert.ToDateTime("2022-04-19T16:16:56.9844275"),
                    Change = Convert.ToDateTime("2022-04-19T16:16:56.9844046"),
                    ChangedBy = "Bruno"
                }
            }.AsQueryable();
            var mockContent = new Mock<DbSet<Truck>>();
            
            mockContent.As<IDbAsyncEnumerable<Truck>>().Setup(m => m.GetAsyncEnumerator()).Returns(new TestDbAsyncEnumerator<Truck>(data.GetEnumerator()));
            mockContent.As<IQueryable<Truck>>().Setup(m => m.Provider).Returns(new TestDbAsyncQueryProvider<Truck>( data.Provider));

            mockContent.As<IQueryable<Truck>>().Setup(m => m.Expression).Returns(data.Expression);
            mockContent.As<IQueryable<Truck>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockContent.As<IQueryable<Truck>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            var context = new Mock<Context>();
            context.Setup(c => c.Trucks).Returns(mockContent.Object);
            var repository = new Repositories.TruckRepository(context.Object);

            var service = new TruckService(repository);
            return service;
        }
    }
}
