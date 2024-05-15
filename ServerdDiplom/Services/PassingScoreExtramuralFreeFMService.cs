using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public class PassingScoreExtramuralFreeFMService:IPassingScoreExtramuralFreeFMService
    {
        private readonly DiplomDbContext _context;
        public PassingScoreExtramuralFreeFMService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddPassingScoreExtramuralFreeFM(PassingScoreExtramuralFreeFMDTO addPassingScoreExFreeFMDTO)
        {
            var response = new MainResponse();
            try
            {
                await _context.AddAsync(new PassingScoreExtramuralFreeFM
                {
                    PassingScoreValueExtramuralFree = addPassingScoreExFreeFMDTO.PassingScoreValueExtramuralFree,
                    PassingScoreValueExtramuralForMoney = addPassingScoreExFreeFMDTO.PassingScoreValueExtramuralForMoney,
                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Passing score added";

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdatePassingScoreExtramuralFreeFM(UpdatePassingScoreExtramuralFreeFMDTO updatePassingScoreExFreeFMDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingPassingScoreExFreeFM = await _context.PassingScoreExtramuralFreeFMs.Where(f => f.ScoreForMoneyId == updatePassingScoreExFreeFMDTO.ScoreForMoneyId).FirstOrDefaultAsync();
                if (exictingPassingScoreExFreeFM != null)
                {
                    exictingPassingScoreExFreeFM.PassingScoreValueExtramuralFree = updatePassingScoreExFreeFMDTO.PassingScoreValueExtramuralFree;
                    exictingPassingScoreExFreeFM.PassingScoreValueExtramuralForMoney = updatePassingScoreExFreeFMDTO.PassingScoreValueExtramuralFree;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Passing score updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Id not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeletePassingScoreExtramuralFreeFM(DeletePassingScoreExtramuralFreeFMDTO deletePassingScoreExFreeFMDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingPassingScoreExFreeFM = await _context.PassingScoreExtramuralFreeFMs.Where(f => f.ScoreForMoneyId == deletePassingScoreExFreeFMDTO.ScoreForMoneyId).FirstOrDefaultAsync();
                if (exictingPassingScoreExFreeFM != null)
                {

                    _context.Remove(exictingPassingScoreExFreeFM);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Passing score was deleted";
                }
                else
                {
                    response.ErrorMessage = "This passing score wasn't founded";
                    response.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }

        public async Task<MainResponse> GetAllPassingScoreExtramuralFreeFM()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.PassingScoreExtramuralFreeFMs.ToListAsync();
                response.IsSuccess = true;

            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }
    }
}
