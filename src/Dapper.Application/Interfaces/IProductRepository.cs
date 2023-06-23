
using Dapper.Contracts;
using Dapper.Core.Entities;

namespace Dapper.Application.Interfaces
{
    public interface IProductRepository : IGenericRepository<ProductRequest, Product>
    {
    }
}
