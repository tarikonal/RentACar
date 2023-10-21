using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IFuelRepository : Core.Persistance.Repositories.IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
{
}
