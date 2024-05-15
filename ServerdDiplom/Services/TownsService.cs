using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public class TownsService : ITownsService
    {
        private readonly DiplomDbContext _context;
        public TownsService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddTown(TownsDTO townsDTO)
        {
            var response = new MainResponse();
            try
            {
                var existingRegion = await _context.Regions.Where(f=>f.Region==townsDTO.Regions_Name).ToListAsync();
                var existTown = await _context.Towns.
                    Where(f => f.TownName == townsDTO.TownName).
                    Where(x=>x.StreetName==townsDTO.StreetName).
                    Where(a=>a.Regions_Name==townsDTO.Regions_Name).FirstOrDefaultAsync();
       
                if (existingRegion != null && existTown==null) { 
                await _context.AddAsync(new Towns
                {
                    StreetName = townsDTO.StreetName,
                    TownName = townsDTO.TownName,
                    Regions_Name=townsDTO.Regions_Name,
                    
                });
                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "Towns added";
                }
                else
                {
                    response.ErrorMessage = "This region dont exist";
                  response.IsSuccess= false;

                }


            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> UpdateTown(UpdateTownsDTO townsDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingTown = await _context.Towns.Where(f => f.Id == townsDTO.Id).FirstOrDefaultAsync();
               
                if (exictingTown !=null)
                {
                    exictingTown.StreetName = townsDTO.StreetName;
                    exictingTown.TownName = townsDTO.TownName;  
                     await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "Towns updated";
                }
                else
                {
                    response.IsSuccess= false;
                    response.Content = "Towns not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }

        public async Task<MainResponse> DeleteTown(DeleteTownsDTO deletetownsDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingTowns = await _context.Towns.Where(f => f.Id == deletetownsDTO.Id).FirstOrDefaultAsync();

                if (exictingTowns != null)
                {
                    
                    _context.Remove(exictingTowns);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "Town was deleted";
                }
                else
                {
                    response.ErrorMessage = "This town's street name wasn't founded";
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

        public async Task<MainResponse> GetAllTowns()
        {
            var response = new MainResponse();
            try
            {
                    response.Content = await _context.Towns.ToListAsync();
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
