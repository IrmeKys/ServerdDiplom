using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Services
{
    public class SpecialityPassingScoreFreeService:ISpecialityPassingScoreFreeService
    {
        private readonly DiplomDbContext _context;
        public SpecialityPassingScoreFreeService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddSpecialityPassingScoreForFree(SpecialityPassingScoreFreeDTO specialityPassingScoreFreeDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality.Where(f => f.Id == specialityPassingScoreFreeDTO.SpecialityId).FirstOrDefaultAsync();
                var exictingScore = await _context.PassingScoreDayFreeFMs.Where(x => x.ScoreFreeId == specialityPassingScoreFreeDTO.ScoreFreeId).FirstOrDefaultAsync();
                var existMtM = await _context.Speciality_PassingScoreFrees.Where(f => f.SpecialityId == specialityPassingScoreFreeDTO.SpecialityId).
                    Where(x=>x.ScoreFreeId==specialityPassingScoreFreeDTO.ScoreFreeId).FirstOrDefaultAsync();
               
                if (exictingScore != null && exictingSpeciality != null && existMtM==null)
                {
                    await _context.AddAsync(new Speciality_PassingScoreFree
                    {
                        ScoreFreeId = specialityPassingScoreFreeDTO.ScoreFreeId,
                        SpecialityId = specialityPassingScoreFreeDTO.SpecialityId,

                    });
                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Speciality and score added";
                }
                else
                {
                    response.ErrorMessage = "Speciality or score not found or already exist";
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

        public async Task<MainResponse> DeleteSpecialityPassingScoreForFree(DeleteSpecialityPassingScoreFreeDTO deleteSpecialityPassingScoreFreeDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality_PassingScoreFrees.Where(f => f.SpecialityId == deleteSpecialityPassingScoreFreeDTO.SpecialitId)
                    .Where(x=>x.ScoreFreeId==deleteSpecialityPassingScoreFreeDTO.ScoreFreeId).FirstOrDefaultAsync();
                if (exictingSpeciality != null)
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
        public async Task<MainResponse> GetAllSpecialityScoreFree()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Speciality_PassingScoreFrees.ToListAsync();
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
