

using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IBrandRepository : Core.Persistance.Repositories.IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
{
}
