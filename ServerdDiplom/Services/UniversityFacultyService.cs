using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Services
{
    public class UniversityFacultyService:IUniversityFacultyService
    {
        private readonly DiplomDbContext _context;
        public UniversityFacultyService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddUniversityFaculty(UniversityFacultyDTO universityFacultyDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingUniversity = await _context.Universities.Where(f => f.Id == universityFacultyDTO.UniversityId).FirstOrDefaultAsync();
                var exictingFaculty = await _context.Faculties.Where(x => x.Id == universityFacultyDTO.FacultyId).FirstOrDefaultAsync();
                var existMtM = await _context.University_Faculties.Where(f => f.FacultyId == universityFacultyDTO.FacultyId)
                    .Where(x=>x.UniversityId==universityFacultyDTO.UniversityId).FirstOrDefaultAsync();
               
                if (exictingFaculty != null && exictingUniversity != null && existMtM==null)
                {
                    await _context.AddAsync(new University_Faculty
                    {
                        UniversityId = universityFacultyDTO.UniversityId,
                        FacultyId = universityFacultyDTO.FacultyId,

                    });
                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "University and faculty added";
                }
                else
                {
                    response.ErrorMessage = "University or Faculty not found or already exist";
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

        public async Task<MainResponse> DeleteUniversityFaculty(DeleteUniversityFacultyDTO deleteUniversityFacultyDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingUniversity = await _context.University_Faculties.Where(f => f.UniversityId == deleteUniversityFacultyDTO.UniversityId)
                    .Where(x=>x.FacultyId==deleteUniversityFacultyDTO.FacultyId).FirstOrDefaultAsync();
                
                if (exictingUniversity != null )
                {

                    _context.Remove(exictingUniversity);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "University and faculty was deleted";
                }
                else
                {
                    response.ErrorMessage = "This University and faculty wasn't founded";
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
        public async Task<MainResponse> GetAllUniversityFaculty()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.University_Faculties.ToListAsync();
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
