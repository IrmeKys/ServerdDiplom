using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface ISpecialityService
    {
        Task<MainResponse> AddSpeciality(SpecialityDTO addSpecialityDTO);
        Task<MainResponse> UpdateSpeciality(UpdateSpecialityDTO updateSpecialityDTO);
        Task<MainResponse> DeleteSpeciality(DeleteSpecialityDTO deleteSpecialityDTO);
        Task<MainResponse> GetAllSpeciality();
    }
}
