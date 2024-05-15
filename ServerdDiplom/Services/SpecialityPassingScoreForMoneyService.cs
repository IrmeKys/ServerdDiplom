using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Services
{
    public class SpecialityPassingScoreForMoneyService : ISpecialityPassingScoreForMoneyService
    {
        private readonly DiplomDbContext _context;
        public SpecialityPassingScoreForMoneyService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddSpecialityPassingScoreForMoney(SpecialityPassingScoreForMoneyDTO specialityPassingScoreDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality.Where(f => f.Id == specialityPassingScoreDTO.SpecialityId).FirstOrDefaultAsync();
                var exictingScore = await _context.PassingScoreExtramuralFreeFMs.Where(x => x.ScoreForMoneyId == specialityPassingScoreDTO.ScoreForMoneyId).FirstOrDefaultAsync();

                if (exictingScore != null && exictingSpeciality != null)
                {
                    await _context.AddAsync(new Speciality_PassingScoreForMoney
                    {
                        ScoreForMoneyId = specialityPassingScoreDTO.ScoreForMoneyId,
                        SpecialityId = specialityPassingScoreDTO.SpecialityId,

                    });
                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Speciality and score added";
                }
                else
                {
                    response.ErrorMessage = "Speciality or score not found";
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

        public async Task<MainResponse> DeleteSpecialityPassingScoreForMoney(DeleteSpecialityPassingScoreForMoneyDTO deleteSpecialityPassingScoreDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality_PassingScoreForMoney.Where(f => f.SpecialityId == deleteSpecialityPassingScoreDTO.SpecialityId)
                    .Where(x=>x.ScoreForMoneyId==deleteSpecialityPassingScoreDTO.ScoreForMoneyId).FirstOrDefaultAsync();
                if ( exictingSpeciality != null)
                {

                    _context.RemoveRange( exictingSpeciality);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Speciality and score was deleted";
                }
                else
                {
                    response.ErrorMessage = "This speciality or score wasn't founded";
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
        public async Task<MainResponse> GetAllSpecialityScore()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Speciality_PassingScoreForMoney.ToListAsync();
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
