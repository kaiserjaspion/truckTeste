using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Volvo.Gerenciamento.Contexts;
using Teste.Volvo.Gerenciamento.Models;

namespace Teste.Volvo.Gerenciamento.Repositories
{
    public class TruckRepository
    {
        public readonly Context _context;

        public TruckRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Truck>> GetTruckList()
        {
            try
            {
                return await _context.Truck
                    .Where(x => x.IsActive)
                    .ToListAsync();

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> EditTruck(Truck truck)
        {
            try
            {
                truck.IsActive = true;
                truck.Change = DateTime.Now;
                truck.ChangedBy = "Bruno";
                

                if(truck.Id == Guid.Empty ||  truck.Id == null)
                {
                    truck.Id = Guid.NewGuid();
                    truck.Created = DateTime.Now;
                    _context.Add<Truck>(truck);
                }
                else
                {
                    _context.Update<Truck>(truck);
                }
                return (await _context.SaveChangesAsync() > 0);

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
                var truck = await _context.Truck
                    .Where(x => x.IsActive && x.Id == Id)
                    .FirstAsync();

                truck.IsActive = false;

                _context.Update<Truck>(truck);
                return (await _context.SaveChangesAsync() > 0);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
