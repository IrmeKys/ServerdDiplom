using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public class PassingScoreDayFreeFMService:IPassingScoreDayFreeFMService
    {
        private readonly DiplomDbContext _context;
        public PassingScoreDayFreeFMService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddPassingScoreFreeFM(PassingScoreDayFreeFMDTO PassingScoreDayFreeFMDTO)
        {
            var response = new MainResponse();
            try
            {
                var existScore = await _context.PassingScoreDayFreeFMs.Where(f => f.PassingScoreValueDayFree == PassingScoreDayFreeFMDTO.PassingScoreValueDayFree)
                    .Where(x=>x.PassingScoreValueDayForMoney==PassingScoreDayFreeFMDTO.PassingScoreValueDayForMoney).FirstOrDefaultAsync();
                if (existScore != null)
                {
                    response.ErrorMessage = "Score already exist";
                    response.IsSuccess = false;
                }
                else
                {
                    
                await _context.AddAsync(new PassingScoreDayFreeFM
                {
                    
                    PassingScoreValueDayFree = PassingScoreDayFreeFMDTO.PassingScoreValueDayFree,
                    PassingScoreValueDayForMoney = PassingScoreDayFreeFMDTO.PassingScoreValueDayForMoney,
                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Passing score added";

                }
            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdatePassingScoreFreeFM(UpdatePassingScoreDayFreeFMDTO updatePassingScoreDayFreeFMDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingPassingScoreFreeFM = await _context.PassingScoreDayFreeFMs.Where(f => f.ScoreFreeId == updatePassingScoreDayFreeFMDTO.ScoreFreeId).FirstOrDefaultAsync();
                if (exictingPassingScoreFreeFM != null)
                {
                    exictingPassingScoreFreeFM.PassingScoreValueDayFree = updatePassingScoreDayFreeFMDTO.PassingScoreValueDayFree;
                    exictingPassingScoreFreeFM.PassingScoreValueDayForMoney = updatePassingScoreDayFreeFMDTO.PassingScoreValueDayForMoney;
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
        public async Task<MainResponse> DeletePassingScoreFreeFM(DeletePassingScoreDayFreeFMDTO deletePassingScoreDayFreeFMDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingPassingScoreFreeFM = await _context.PassingScoreDayFreeFMs.Where(f => f.ScoreFreeId == deletePassingScoreDayFreeFMDTO.ScoreFreeId).FirstOrDefaultAsync();
                if (exictingPassingScoreFreeFM != null)
                {

                    _context.Remove(exictingPassingScoreFreeFM);
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

        public async Task<MainResponse> GetAllPassingScoreFreeFM()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.PassingScoreDayFreeFMs.ToListAsync();
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
