using ServerdDiplom.Model;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model.UpdateDTO;

namespace ServerdDiplom.Services
{
    public interface IComissionNumberService
    {
        Task<MainResponse> AddNumber(ComissionNumberDTO addComissionNumberDTO);
        Task<MainResponse> UpdateNumber(UpdateComissionNumberDTO updateComissionNumberDTO);
        Task<MainResponse> DeleteNumber(DeleteComissionNumberDTO deleteComissionNumberDTO);
        Task<MainResponse> GetAllComissionNumber();
    }
}
