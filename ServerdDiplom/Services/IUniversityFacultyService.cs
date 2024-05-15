using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface IUniversityFacultyService
    {
        Task<MainResponse> AddUniversityFaculty(UniversityFacultyDTO universityFacultyDTO);
        Task<MainResponse> DeleteUniversityFaculty(DeleteUniversityFacultyDTO deleteUniversityFacultyDTO);
        Task<MainResponse> GetAllUniversityFaculty();
    }
}
