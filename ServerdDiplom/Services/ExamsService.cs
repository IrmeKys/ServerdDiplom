using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;
using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Services
{
    public class ExamsService : IExamsService
    {
        private readonly DiplomDbContext _context;
        public ExamsService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddExams(ExamsDTO addExamsDTO)
        {
            var response = new MainResponse();
            try
            {
                var existExam = await _context.Exams.Where(f => f.Exams_Name == addExamsDTO.Exams_Name).FirstOrDefaultAsync();
                if (existExam!=null)
                {
                    response.ErrorMessage = "Exam already exist";
                    response.IsSuccess = false;
                }
                else { 

                await _context.AddAsync(new Exams
                {
                    Exams_Name = addExamsDTO.Exams_Name,

                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Exam added";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdateExams(ExamsDTO updateExamsDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingExams = await _context.Exams.Where(f => f.Id == updateExamsDTO.Id).FirstOrDefaultAsync();
                if (exictingExams != null)
                {
                    exictingExams.Exams_Name = updateExamsDTO.Exams_Name;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Exam updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Exam not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeleteExams(ExamsDTO deleteExamsDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingExams = await _context.Exams.Where(f => f.Exams_Name == deleteExamsDTO.Exams_Name).FirstOrDefaultAsync();
                if (exictingExams != null)
                {

                    _context.Remove(exictingExams);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Exam was deleted";
                }
                else
                {
                    response.ErrorMessage = "This Exam wasn't founded";
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
        public async Task<MainResponse> GetAllExams()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Exams.ToListAsync();
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
