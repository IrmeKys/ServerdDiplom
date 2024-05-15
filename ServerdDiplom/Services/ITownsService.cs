using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface ITownsService
    {
        Task<MainResponse> AddTown(TownsDTO townsDTO);

        Task<MainResponse> UpdateTown(UpdateTownsDTO townsDTO);

        Task<MainResponse> DeleteTown(DeleteTownsDTO townsDTO);
        Task<MainResponse> GetAllTowns();



    }
}
