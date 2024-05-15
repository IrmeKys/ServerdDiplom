using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface ISpecialityPassingScoreForMoneyService
    {
        Task<MainResponse> AddSpecialityPassingScoreForMoney(SpecialityPassingScoreForMoneyDTO specialityPassingScoreDTO);
        Task<MainResponse> DeleteSpecialityPassingScoreForMoney(DeleteSpecialityPassingScoreForMoneyDTO deleteSpecialityPassingScoreDTO);
        Task<MainResponse> GetAllSpecialityScore();
    }
}
