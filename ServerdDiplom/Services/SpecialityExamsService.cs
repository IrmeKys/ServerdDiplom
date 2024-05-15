using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model.UpdateDTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Services
{
    public class SpecialityExamsService:ISpecialityExamsService
    {
        private readonly DiplomDbContext _context;
        public SpecialityExamsService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddSpecialityExams(SpecialityExamsDTO specialityExamsDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality.Where(f => f.Id ==specialityExamsDTO.SpecialityId ).FirstOrDefaultAsync();
                var exictingExams = await _context.Exams.Where(x => x.Id == specialityExamsDTO.ExamsId).FirstOrDefaultAsync();
                var existMtM = await _context.Speciality_Exams.Where(f => f.ExamsId == specialityExamsDTO.ExamsId)
                    .Where(x=>x.SpecialityId==specialityExamsDTO.SpecialityId).FirstOrDefaultAsync();
                
                    ;
                
                if (exictingExams != null && exictingSpeciality!=null && existMtM==null)
                {
                    await _context.AddAsync(new Speciality_Exams
                {
                    ExamsId = specialityExamsDTO.ExamsId,
                    SpecialityId = specialityExamsDTO.SpecialityId,

                });
                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Speciality and exam added";
                }
                else
                {
                    response.ErrorMessage = "Exam or Speciality not found or already exist";
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

        public async Task<MainResponse> DeleteSpecialityExams(DeleteSpecialityExamsDTO deleteSpecialityExamsDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality_Exams.Where(f => f.SpecialityId == deleteSpecialityExamsDTO.SpecialityId)
                    .Where(x=>x.ExamsId==deleteSpecialityExamsDTO.ExamsId).FirstOrDefaultAsync();
                if (exictingSpeciality!=null)
                {

                    _context.RemoveRange(exictingSpeciality);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Speciality and exam was deleted";
                }
                else
                {
                    response.ErrorMessage = "This speciality or exam wasn't founded";
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
        public async Task<MainResponse> GetAllSpecialityExams()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Speciality_Exams.ToListAsync();
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
