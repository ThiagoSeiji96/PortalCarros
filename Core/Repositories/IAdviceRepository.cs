using Core.Entities;

namespace Core.Repositories
{
    public interface IAdviceRepository
    {
        Task<List<Advice>> GetAdvices();
        Task<Advice> GetById(int id);
        Task AddAdvice(Advice advice);
        Task UpdateAdvice(Advice advice);
        Task DeleteAdvice(int id);
        Task SaveChangesAsync();

    }
}
