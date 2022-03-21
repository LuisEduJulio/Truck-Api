using System.Collections.Generic;
using System.Threading.Tasks;
using Truck.Domain.Entities;

namespace Truck.Domain.Repositories
{
    public interface ITruckRepository
    {
        Task<TruckEntity> AddAsync(TruckEntity truckEntity);

        Task<TruckEntity> GetIdAsync(int Id);

        Task<List<TruckEntity>> GetAllAsync(int page, int count);

        Task<int> GetAllCountAsync();

        Task<TruckEntity> UpdateAsync(TruckEntity truckEntity);

        Task DeleteAsync(TruckEntity truckEntity);
    }
}