using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface ISpecialityPassingScoreFreeService
    {
        Task<MainResponse> AddSpecialityPassingScoreForFree(SpecialityPassingScoreFreeDTO specialityPassingScoreFreeDTO);
        Task<MainResponse> DeleteSpecialityPassingScoreForFree(DeleteSpecialityPassingScoreFreeDTO deleteSpecialityPassingScoreFreeDTO);
        Task<MainResponse> GetAllSpecialityScoreFree();
    }
}
