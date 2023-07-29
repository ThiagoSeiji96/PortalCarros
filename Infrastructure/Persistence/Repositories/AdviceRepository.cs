using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Repository.Persistence;

namespace Infrastructure.Persistence.Repositories
{
    public class AdviceRepository : IAdviceRepository
    {
        private PortalCarrosDbContext _dbContext;
        public AdviceRepository(PortalCarrosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Advice> GetById(int id)
        {
            return await _dbContext.Advices.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Advice>> GetAdvices()
        {
                return await _dbContext.Advices.ToListAsync();
        }
        public async Task AddAdvice(Advice advice)
        {
            await _dbContext.Advices.AddAsync(advice);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateAdvice(Advice advice)
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAdvice(int id)
        {
            var advice = await _dbContext.Advices.FirstOrDefaultAsync(x => x.Id == id);
            advice.FinishAdvice();
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
