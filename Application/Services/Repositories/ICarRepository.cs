
using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ICarRepository : Core.Persistance.Repositories.IAsyncRepository<Car, Guid>, IRepository<Car, Guid>
{
}
