using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model.UpdateDTO;

namespace ServerdDiplom.Services
{
    public class ComisssionNumberService:IComissionNumberService
    {
        private readonly DiplomDbContext _context;
        public ComisssionNumberService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddNumber(ComissionNumberDTO addComissionNumberDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingUniversity = await _context.Universities.Where(f => f.UniversityName == addComissionNumberDTO.UniversityName).FirstOrDefaultAsync();
                var existNumber = await _context.ComissionsNumber.Where(f => f.ComissionNumberValue == addComissionNumberDTO.ComissionNumberValue).FirstOrDefaultAsync();
                if (exictingUniversity == null || existNumber != null)
                { response.ErrorMessage="University does not found or number already exist";
                    response.IsSuccess= false;
                }

                else
                {
                    await _context.AddAsync(new ComissionNumber
                    {

                        ComissionNumberValue = addComissionNumberDTO.ComissionNumberValue,
                        UniversityName = addComissionNumberDTO.UniversityName,

                    });
                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Comission number added";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdateNumber(UpdateComissionNumberDTO updateComissionNumberDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingNumber = await _context.ComissionsNumber.Where(f => f.Id == updateComissionNumberDTO.Id).FirstOrDefaultAsync();
                if (exictingNumber != null)
                {
                    exictingNumber.ComissionNumberValue = updateComissionNumberDTO.ComissionNumberValue;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Number updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Number not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeleteNumber(DeleteComissionNumberDTO deleteComissionNumberDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingExams = await _context.ComissionsNumber.Where(f => f.Id == deleteComissionNumberDTO.Id).FirstOrDefaultAsync();
                if (exictingExams != null)
                {

                    _context.Remove(exictingExams);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Number was deleted";
                }
                else
                {
                    response.ErrorMessage = "This Number wasn't founded";
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
        public async Task<MainResponse> GetAllComissionNumber()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.ComissionsNumber.ToListAsync();
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
