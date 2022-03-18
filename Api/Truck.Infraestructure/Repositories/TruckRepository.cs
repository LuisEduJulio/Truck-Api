using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Truck.Domain.Entities;
using Truck.Domain.Repositories;
using Truck.Infraestructure.Factory;

namespace Truck.Infraestructure.Repositories
{
    public class TruckRepository : ITruckRepository
    {
        private readonly AppDbContext _dbContext;

        public TruckRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TruckEntity> AddAsync(TruckEntity truckEntity)
        {
            var truck = await _dbContext.TruckEntities.AddAsync(truckEntity);

            await _dbContext.SaveChangesAsync();

            return truck.Entity;
        }

        public async Task DeleteAsync(TruckEntity truckEntity)
        {
            _dbContext.TruckEntities.Remove(truckEntity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<TruckEntity>> GetAllAsync(int page, int count)
        {
            var truck = await _dbContext
                   .TruckEntities
                   .OrderBy(m => m.Id)
                   .Skip(count * (page - 1))
                   .Take(count)
                   .ToListAsync();

            return truck;
        }

        public async Task<TruckEntity> GetIdAsync(int Id)
        {
            var truck = await _dbContext
                .TruckEntities
                .FirstOrDefaultAsync(t => t.Id == Id);

            return truck;
        }

        public async Task<TruckEntity> UpdateAsync(TruckEntity truckEntity)
        {
            var truck = _dbContext.TruckEntities.Update(truckEntity);

            await _dbContext.SaveChangesAsync();

            return truck.Entity;
        }
    }
}