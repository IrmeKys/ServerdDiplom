using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface ISpecialityFacultyService
    {
        Task<MainResponse> AddSpecialityFaculty(SpecialityFacultyDTO specialityFacultyDTO);
        Task<MainResponse> DeleteSpecialityFaculty(DeleteSpecialityFacultyDTO deleteSpecialityFacultyDTO);
        Task<MainResponse> GetAllSpecialityFaculty();
    }
}
