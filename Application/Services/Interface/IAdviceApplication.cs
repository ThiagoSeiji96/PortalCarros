using Application.InputModels;
using Application.ViewModels;

namespace Application.Services.Interface
{
    public interface IAdviceApplication
    {
        Task<List<AdviceViewModel>> GetAdvices();
        Task<AdviceDetailsViewModel> GetById(int id);
        Task AddAdvice(AdviceInputModel advice);
        Task<bool> UpdateAdvice(AdviceUpdateInputModel advice);
        Task DeleteAdvice(int id);
    }
}
