
using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IModelRepository : Core.Persistance.Repositories.IAsyncRepository<Model, Guid>, IRepository<Model, Guid>
{
}
