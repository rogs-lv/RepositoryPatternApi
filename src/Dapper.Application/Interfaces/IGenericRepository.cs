namespace Dapper.Application.Interfaces
{
    public interface IGenericRepository<TRequest, TResponse> 
        where TRequest : class
        where TResponse : class
    {
        Task<TResponse> GetByIdAsync(int id);
        Task<IReadOnlyList<TResponse>> GetAllAsync();
        Task<int> AddAsync(TRequest entity);
        Task<int> UpdateAsync(TRequest entity);
        Task<int> DeleteAsync(int id);
    }
}
