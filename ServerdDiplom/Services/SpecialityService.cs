using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public class SpecialityService : ISpecialityService
    {
        private readonly DiplomDbContext _context;
        public SpecialityService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddSpeciality(SpecialityDTO addSpecialityDTO)
        {
            var response = new MainResponse();
            try
            {
                var existingPeriod = await _context.TrainingPeriods.Where(f => f.TrainingPeriodValue == addSpecialityDTO.Trainin_Period).FirstOrDefaultAsync();
                var existSpeciality = await _context.Speciality.Where(f => f.SpecialityName == addSpecialityDTO.SpecialityName).FirstOrDefaultAsync();
                
                if (existingPeriod != null && existSpeciality!=null) { 
                await _context.AddAsync(new Speciality
                {
                    SpecialityName = addSpecialityDTO.SpecialityName,
                    Trainin_Period = addSpecialityDTO.Trainin_Period,
                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Speciality added";
                }
                else
                {
                    response.ErrorMessage = "Training period does not exist or speciality already exist";
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

        public async Task<MainResponse> UpdateSpeciality(UpdateSpecialityDTO updateSpecialityDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality.Where(f => f.Id == updateSpecialityDTO.Id).FirstOrDefaultAsync();
                var existingPeriod = await _context.TrainingPeriods.Where(f => f.TrainingPeriodValue == updateSpecialityDTO.Trainin_Period).FirstOrDefaultAsync();
                if (exictingSpeciality != null)
                {
                    exictingSpeciality.SpecialityName = updateSpecialityDTO.SpecialityName;
                    exictingSpeciality.Trainin_Period = updateSpecialityDTO.Trainin_Period;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Speciality updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Speciality not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeleteSpeciality(DeleteSpecialityDTO deleteSpecialityDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingSpeciality = await _context.Speciality.Where(f => f.Id == deleteSpecialityDTO.Id).FirstOrDefaultAsync();
                if (exictingSpeciality != null)
                {

                    _context.Remove(exictingSpeciality);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Speciality was deleted";
                }
                else
                {
                    response.ErrorMessage = "This speciality wasn't founded";
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

        public async Task<MainResponse> GetAllSpeciality()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Speciality.ToListAsync();
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
