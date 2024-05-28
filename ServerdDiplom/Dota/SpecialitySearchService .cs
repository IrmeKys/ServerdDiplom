using ServerdDiplom.Context;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using ServerdDiplom.ZalupaVagina;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.Dota
{
    public class SpecialitySearchService : ISpecialitySearchService
    {
        private readonly DiplomDbContext _context;

        public SpecialitySearchService(DiplomDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SearchUniversityDTO>> SearchUniversitiesBySpecialityAsync(string searchTerm)
        {
            var universities = await _context.Speciality
                .Where(s => s.SpecialityName.Contains(searchTerm))
                .SelectMany(s => s.Speciality_Faculties)
                .Select(sf => sf.Faculty)
                .SelectMany(f => f.University_Faculties)
                .Select(uf => new SearchUniversityDTO
                {
                    UniversityName = uf.University.UniversityName,
                    UniversityDescription = uf.University.UniversityDescription,
                    UniversityLink = uf.University.UniversityLink,
                    Faculties = uf.University.University_Faculties.Select(uf => new SearchFacultyDTO
                    {
                        FacultyName = uf.Faculty.FacultyName,
                        Specialities = uf.Faculty.Speciality_Faculties
                            .Where(sf => sf.Speciality.SpecialityName.Contains(searchTerm))
                            .Select(sf => new SearchSpecialityDTO
                            {
                                SpecialityName = sf.Speciality.SpecialityName
                            }).ToList()
                    }).ToList()
                }).ToListAsync();

            // Apply distinct logic in memory
            var distinctUniversities = universities
                .GroupBy(u => u.UniversityName)
                .Select(g => g.First())
                .ToList();

            return distinctUniversities;
        }
    }
}
 
