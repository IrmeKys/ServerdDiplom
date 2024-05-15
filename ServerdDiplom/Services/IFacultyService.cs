using ServerdDiplom.Model;
using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Services
{
    public interface IFacultyService
    {
        Task<MainResponse> AddFaculty(FacultyDTO addFacultyDTO);
        Task<MainResponse> UpdateFaculty(UpdateFacultyDTO updateFacultyDTO);
        Task<MainResponse> DeleteFaculty(DeleteFacultyDTO deleteFacultyDTO);
        Task<MainResponse> GetAllFaculty();
    }
}
