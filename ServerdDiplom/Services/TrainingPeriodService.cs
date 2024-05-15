using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Services
{
    public class TrainingPeriodService : ITrainingPeriodService
    {
        private readonly DiplomDbContext _context;
        public TrainingPeriodService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddTrainingPeriod(TrainingPeriodDTO trainingPeriodDTO)
        {
            var response = new MainResponse();
            try
            {
                var existoeriod = await _context.TrainingPeriods.Where(f => f.TrainingPeriodValue == trainingPeriodDTO.TrainingPeriodValue).FirstOrDefaultAsync();
                if (existoeriod != null)
                {
                    response.ErrorMessage = "Training period already exist";
                    response.IsSuccess = false;
                }
                else
                {
                    
                await _context.AddAsync(new TrainingPeriod
                {
                    TrainingPeriodValue = trainingPeriodDTO.TrainingPeriodValue,

                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Training period  added";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdateTrainingPeriod(TrainingPeriodDTO trainingPeriodDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingTrainingPeriod = await _context.TrainingPeriods.Where(f => f.Id == trainingPeriodDTO.Id).FirstOrDefaultAsync();
                if (exictingTrainingPeriod != null)
                {
                    exictingTrainingPeriod.TrainingPeriodValue = trainingPeriodDTO.TrainingPeriodValue;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Training period updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Training period not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeleteTrainingPeriod(DeleteTrainingPeriodDTO deleteTrainingPeriodDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingRegion = await _context.TrainingPeriods.Where(f => f.Id == deleteTrainingPeriodDTO.Id).FirstOrDefaultAsync();
                if (exictingRegion != null)
                {

                    _context.Remove(exictingRegion);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Region was deleted";
                }
                else
                {
                    response.ErrorMessage = "This region wasn't founded";
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

        public async Task<MainResponse> GetAllTrainingPeriod()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.TrainingPeriods.ToListAsync();
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
