using Application.InputModels;
using Application.Services.Interface;
using Application.ViewModels;
using Core.Entities;
using Core.Enums;
using Core.Repositories;

namespace Application.Services
{
    public class AdviceService //: IAdviceApplication
    {
        private IAdviceRepository _AdviceRepository;
        public AdviceService(IAdviceRepository adviceRepository)
        {
            _AdviceRepository = adviceRepository;
        }
        //public async Task<AdviceDetailsViewModel> GetById(int id)
        //{
        //    var advice = await _AdviceRepository.GetById(id);
        //    var adviceDetails = new AdviceDetailsViewModel(
        //        advice.Id,
        //        advice.Model,
        //        advice.Brand,
        //        advice.Year,
        //        advice.Color,
        //        advice.Transmission,
        //        advice.Hodometer);

        //    return adviceDetails;
        //}

        //public async Task<List<AdviceViewModel>> GetAdvices()
        //{
        //    var advice = await _AdviceRepository.GetAdvices();
        //    var adviceViewModelList = advice.Select(a => new AdviceViewModel(a.Id, a.Model, a.Brand, a.Year)).ToList();

        //    return adviceViewModelList;
        //}

        //public async Task AddAdvice(AdviceInputModel model)
        //{
        //    if (model == null) throw new Exception("Erro ao criar novo anúncio.");
            
        //    var modelBoolToInt = int.Parse(model.Transmission.ToString());

        //    var advice = new Advice(
        //        model.Id,
        //        model.Model,
        //        model.Brand,
        //        int.Parse(model.Year),
        //        model.Color,
        //        (VehicleTransmissionTypeEnum)modelBoolToInt,
        //        model.Hodometer,
        //        int.Parse(model.IdUser),
        //        model.Description);

        //    await _AdviceRepository.AddAdvice(advice);
        //}
        //public async Task<bool> UpdateAdvice(AdviceUpdateInputModel inputModel)
        //{
        //    var advice = await _AdviceRepository.GetById(inputModel.Id);
            
        //    if (advice == null)
        //    {
        //        return false;
        //    }

        //    advice.UpdateDescription(inputModel.Description);
        //    await _AdviceRepository.UpdateAdvice(advice);

        //    return true;
        //}

        //public async Task DeleteAdvice(int id)
        //{
        //    var advice = await _AdviceRepository.GetById(id);
        //    advice.FinishAdvice();
        //    await _AdviceRepository.SaveChangesAsync();
        //}
    }
}
