using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ITransmissionRepository : Core.Persistance.Repositories.IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
{
}
