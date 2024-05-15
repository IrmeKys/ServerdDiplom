using ServerdDiplom.Model;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Services
{
    public interface ITrainingPeriodService
    {
        Task<MainResponse> AddTrainingPeriod(TrainingPeriodDTO trainingPeriodDTO);
        Task<MainResponse> UpdateTrainingPeriod(TrainingPeriodDTO trainingPeriodDTO);
        Task<MainResponse> DeleteTrainingPeriod(DeleteTrainingPeriodDTO deleteTrainingPeriodDTO);
        Task<MainResponse> GetAllTrainingPeriod();
    }
}
