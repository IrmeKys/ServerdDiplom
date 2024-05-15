using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;
using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly DiplomDbContext _context;
        public FacultyService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddFaculty(FacultyDTO addFacultyDTO)
        {
            var response = new MainResponse();
            try
            {
                var existFacilty=await _context.Faculties.Where(f=>f.FacultyName==addFacultyDTO.FacultyName).FirstOrDefaultAsync();
                if (existFacilty!=null) {
                    response.ErrorMessage = "Faculty already exist";
                    response.IsSuccess = false;
                }
                else
                {
                    
                await _context.AddAsync(new Faculty
                {
                    FacultyName = addFacultyDTO.FacultyName,
                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Faculty added";

                }
            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdateFaculty(UpdateFacultyDTO updateFacultyDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingFaculty = await _context.Faculties.Where(f => f.Id == updateFacultyDTO.Id).FirstOrDefaultAsync();
                if (exictingFaculty != null)
                {
                    exictingFaculty.FacultyName = updateFacultyDTO.FacultyName;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Faculty updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Faculty not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeleteFaculty(DeleteFacultyDTO deleteFacultyDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingFaculty = await _context.Faculties.Where(f => f.Id == deleteFacultyDTO.Id).FirstOrDefaultAsync();
                if (exictingFaculty != null)
                {

                    _context.Remove(exictingFaculty);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Faculty was deleted";
                }
                else
                {
                    response.ErrorMessage = "This Faculty wasn't founded";
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

        public async Task<MainResponse> GetAllFaculty()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Faculties.ToListAsync();
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
