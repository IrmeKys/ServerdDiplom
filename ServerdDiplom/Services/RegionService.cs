using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;
using ServerdDiplom.Model.DeleteDTO;
using ServerdDiplom.Model.DTO;

namespace ServerdDiplom.Services
{
    public class RegionService : IRegionService
    {


        private readonly DiplomDbContext _context;
        public RegionService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddRegion(RegionDTO regionDTO)
        {
            var response = new MainResponse();
            try
            {
                var existRegion = await _context.Regions.Where(f => f.Region == regionDTO.Region).FirstOrDefaultAsync();
                if (existRegion != null)
                {
                    response.ErrorMessage = "Region already exist";
                    response.IsSuccess = false;
                }
                else
                {
                    
                await _context.AddAsync(new Regions
                {
                    Region = regionDTO.Region,

                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Region added added";

                }
            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdateRegion(RegionDTO regionDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingRegion = await _context.Regions.Where(f => f.Id == regionDTO.Id).FirstOrDefaultAsync();
                if (exictingRegion != null)
                {
                    exictingRegion.Region = regionDTO.Region;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Region updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "Region not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeleteRegion(DeleteRegionDTO deleteRegionDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingRegion = await _context.Regions.Where(f => f.Id == deleteRegionDTO.Id).FirstOrDefaultAsync();
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

        public async Task<MainResponse> GetAllRegion()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Regions.ToListAsync();
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
