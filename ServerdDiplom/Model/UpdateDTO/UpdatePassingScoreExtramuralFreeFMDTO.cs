using System.ComponentModel.DataAnnotations;

namespace ServerdDiplom.Model
{
    public class UpdatePassingScoreExtramuralFreeFMDTO
    {
        public required int ScoreForMoneyId { get; set; }

        public int PassingScoreValueExtramuralFree { get; set; }

        public int PassingScoreValueExtramuralForMoney { get; set; }
    }
}
