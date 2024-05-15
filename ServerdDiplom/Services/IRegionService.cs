using ServerdDiplom.Model;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Services
{
    public interface IRegionService
    {
        Task<MainResponse> GetAllRegion();
        Task<MainResponse> AddRegion(RegionDTO regionDTO);
        Task<MainResponse> UpdateRegion(RegionDTO regionDTO);
        Task<MainResponse> DeleteRegion(DeleteRegionDTO deleteregionDTO);

    }
}
