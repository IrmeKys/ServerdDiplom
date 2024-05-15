using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Services
{
    public class SpecialityFacultyService : ISpecialityFacultyService
    {
        private readonly DiplomDbContext _context;
        public SpecialityFacultyService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddSpecialityFaculty(SpecialityFacultyDTO specialityFacultyDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality.Where(f => f.Id == specialityFacultyDTO.SpecialityId).FirstOrDefaultAsync();
                var exictingFaculty = await _context.Faculties.Where(x => x.Id == specialityFacultyDTO.FacultyId).FirstOrDefaultAsync();
                var existMtM = await _context.Speciality_Faculties.Where(f => f.FacultyId == specialityFacultyDTO.FacultyId)
                    .Where(x=>x.SpecialityId==specialityFacultyDTO.SpecialityId).FirstOrDefaultAsync();
                
                if (exictingFaculty != null && exictingSpeciality != null && existMtM==null)
                {
                    await _context.AddAsync(new Speciality_Faculty
                    {
                        SpecialityId = specialityFacultyDTO.SpecialityId,
                        FacultyId = specialityFacultyDTO.FacultyId,

                    });
                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Speciality and faculty added";
                }
                else
                {
                    response.ErrorMessage = "Speciality or faculty not found or already exist";
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

        public async Task<MainResponse> DeleteSpecialityFaculty(DeleteSpecialityFacultyDTO deleteSpecialityFacultyDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality_Faculties.Where(f => f.SpecialityId == deleteSpecialityFacultyDTO.SpecialityId)
                    .Where(x=>x.FacultyId==deleteSpecialityFacultyDTO.FacultysId).FirstOrDefaultAsync();
                if (exictingSpeciality != null)
                {

                    _context.RemoveRange(exictingSpeciality);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Speciality and faculty was deleted";
                }
                else
                {
                    response.ErrorMessage = "This speciality or faculty wasn't founded";
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
        public async Task<MainResponse> GetAllSpecialityFaculty()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Speciality_Faculties.ToListAsync();
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
