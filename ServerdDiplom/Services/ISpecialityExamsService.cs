using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model.UpdateDTO;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface ISpecialityExamsService
    {
        Task<MainResponse> AddSpecialityExams(SpecialityExamsDTO specialityExamsDTO);
        Task<MainResponse> DeleteSpecialityExams(DeleteSpecialityExamsDTO deleteSpecialityExamsDTO);
        Task<MainResponse> GetAllSpecialityExams();
    }
}
