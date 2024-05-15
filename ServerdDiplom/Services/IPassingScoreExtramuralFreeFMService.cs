using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface IPassingScoreExtramuralFreeFMService
    {
        Task<MainResponse> AddPassingScoreExtramuralFreeFM(PassingScoreExtramuralFreeFMDTO addPassingScoreExFreeFMDTO);
        Task<MainResponse> UpdatePassingScoreExtramuralFreeFM(UpdatePassingScoreExtramuralFreeFMDTO updatePassingScoreExFreeFMDTO);
        Task<MainResponse> DeletePassingScoreExtramuralFreeFM(DeletePassingScoreExtramuralFreeFMDTO deletePassingScoreExFreeFMDTO);
        Task<MainResponse> GetAllPassingScoreExtramuralFreeFM();
    }
}
