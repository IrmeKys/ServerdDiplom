using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface IPassingScoreDayFreeFMService
    {
        Task<MainResponse> AddPassingScoreFreeFM(PassingScoreDayFreeFMDTO PassingScoreDayFreeFMDTO);
        Task<MainResponse> UpdatePassingScoreFreeFM(UpdatePassingScoreDayFreeFMDTO updatePassingScoreDayFreeFMDTO);
        Task<MainResponse> DeletePassingScoreFreeFM(DeletePassingScoreDayFreeFMDTO deletePassingScoreDayFreeFMDTO);
        Task<MainResponse> GetAllPassingScoreFreeFM();
    }
}
