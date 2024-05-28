using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.Data;
using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public class UniversityService: IUniversityService
    {
        private readonly DiplomDbContext _context;
        public UniversityService(DiplomDbContext context)
        {
            _context = context;
        }
        public async Task<MainResponse> AddUniversity(UniversityDTO addUniversityDTO)
        {
            var response = new MainResponse();
            try
            {
                var existingTown = await _context.Towns.Where(f => f.TownName == addUniversityDTO.Town_name).FirstOrDefaultAsync();
                var existuniversity = await _context.Universities.Where(f => f.UniversityName == addUniversityDTO.UniversityName)
                    .Where(x=>x.UniversityLink==addUniversityDTO.UniversityLink)
                    .Where(s=>s.UniversityDescription==addUniversityDTO.UniversityDescription).FirstOrDefaultAsync();
                
                if (existingTown != null && existuniversity==null)
                {

                await _context.AddAsync(new University
                {
                    UniversityName = addUniversityDTO.UniversityName,
                    UniversityDescription = addUniversityDTO.UniversityDescription,
                    UniversityLink = addUniversityDTO.UniversityLink,
                    Town_name = addUniversityDTO.Town_name,

                });

                await _context.SaveChangesAsync();

                response.IsSuccess = true;
                response.Content = "University added";
                }
                else
                {
                    response.ErrorMessage = "Town was not found";
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

        public async Task<MainResponse> UpdateUniversity(UpdateUniversityDTO updateUniversityDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingUnivesrity = await _context.Universities.Where(f => f.Id == updateUniversityDTO.Id).FirstOrDefaultAsync();
                if (exictingUnivesrity != null)
                {
                    exictingUnivesrity.UniversityName = updateUniversityDTO.UniversityName;
                    exictingUnivesrity.UniversityLink = updateUniversityDTO.UniversityLink;
                    await _context.SaveChangesAsync();
                    response.IsSuccess = true;
                    response.Content = "University updated";
                }
                else
                {
                    response.IsSuccess = false;
                    response.Content = "University not founds";
                }

            }
            catch (Exception ex)
            {

                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        public async Task<MainResponse> DeleteUniversity(DeleteUniversityDTO deleteUniversityDTO)
        {
            var response = new MainResponse();
            try
            {
                var exictingUnivesrity = await _context.Universities.Where(f => f.Id == deleteUniversityDTO.Id).FirstOrDefaultAsync();
                if (exictingUnivesrity != null)
                {

                    _context.Remove(exictingUnivesrity);
                    await _context.SaveChangesAsync();


                    response.IsSuccess = true;
                    response.Content = "University was deleted";
                }
                else
                {
                    response.ErrorMessage = "This university wasn't founded";
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

        public async Task<MainResponse> GetAllUniversity()
        {
            var response = new MainResponse();
            try
            {
                response.Content = await _context.Universities.ToListAsync();
                response.IsSuccess = true;

            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }

		public async Task<MainResponse> GetAllUniversityNames()
		{
			var response = new MainResponse();
			try
			{
                var list = await _context.Universities.ToListAsync();
                var names = new List<string>();
                foreach (var item in list)
                {
                    names.Add(item.UniversityName);
                }
                response.Content = names;
				response.IsSuccess = true;

			}
			catch (Exception ex)
			{
				response.ErrorMessage = ex.Message;
				response.IsSuccess = false;
			}
			return response;
		}

		public async Task<SingleUniversityResponse> GetUniversityByName(string University_Name)
        {
            var response = new SingleUniversityResponse();
            try
            {
                var university = await _context.Universities
                    .Where(c => c.UniversityName == University_Name).
                    FirstOrDefaultAsync();


                if (university != null)
                {
                    var universityDTO = new UniversityDTO
                    {
                        UniversityName = university.UniversityName,
                        UniversityDescription = university.UniversityDescription,
                        UniversityLink = university.UniversityLink,
                        Town_name = university.Town_name,
                    };

                    response.University = universityDTO;
                    response.IsSuccess = true;
                }
                else
                {
                    response.ErrorMessage = "University not found";
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

    }
}
