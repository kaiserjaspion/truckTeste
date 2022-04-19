using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Volvo.Gerenciamento.Models;

namespace Teste.Volvo.Gerenciamento.Services.Interfaces
{
    public interface ITruckService
    {
        Task<List<Truck>> GetTruckList();
        Task<bool> EditTruck(Truck truck);
        Task<bool> DeleteTruck(Guid Id);
    }
}
