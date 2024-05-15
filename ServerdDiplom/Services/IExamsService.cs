using ServerdDiplom.Model;
using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Services
{
    public interface IExamsService
    {
        Task<MainResponse> AddExams(ExamsDTO addExamsDTO);
        Task<MainResponse> UpdateExams(ExamsDTO updateExamsDTO);
        Task<MainResponse> DeleteExams(ExamsDTO deleteExamsDTO);
        Task<MainResponse> GetAllExams();
    }
}
