using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Volvo.Gerenciamento.Models;
using Teste.Volvo.Gerenciamento.Repositories;
using Teste.Volvo.Gerenciamento.Services.Interfaces;

namespace Teste.Volvo.Gerenciamento.Services
{
    public class TruckService : ITruckService
    {
        public readonly TruckRepository _repository;
        public TruckService(TruckRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Truck>> GetTruckList()
        {
            try
            {
                return await _repository.GetTruckList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> EditTruck(Truck truck)
        {
            try
            {
                return await _repository.EditTruck(truck);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteTruck(Guid Id)
        {
            try
            {
                return await _repository.DeleteTruck(Id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
