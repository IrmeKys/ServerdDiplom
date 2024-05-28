using ServerdDiplom.Context;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.ZalupaVagina
{
    public class UniversitySearchService:IUniversitySearchService
    {
        private readonly DiplomDbContext _context;

        public UniversitySearchService(DiplomDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SearchUniversityDTO>> SearchUniversitiesAsync(string searchTerm)
        {
            return await _context.Universities
                .Where(u => u.UniversityName.Contains(searchTerm))
                .Select(u => new SearchUniversityDTO
                {
                    UniversityName = u.UniversityName,
                    UniversityDescription = u.UniversityDescription,
                    UniversityLink = u.UniversityLink,
                    Faculties = u.University_Faculties.Select(uf => new SearchFacultyDTO
                    {
                        FacultyName = uf.Faculty.FacultyName,
                        Specialities = uf.Faculty.Speciality_Faculties.Select(sf => new SearchSpecialityDTO
                        {
                            SpecialityName = sf.Speciality.SpecialityName
                        }).ToList()
                    }).ToList()
                }).ToListAsync();
        }
    }
}

