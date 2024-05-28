using ServerdDiplom.Context;
using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using Microsoft.EntityFrameworkCore;
using ServerdDiplom.HyuPizda;

namespace ServerdDiplom.ZalupaVagina
{
    public class UniversitySearchService : IUniversitySearchService
    {
        private readonly DiplomDbContext _context;

        public UniversitySearchService(DiplomDbContext context)
        {
            _context = context;
        }

        public async Task<List<UniversityAdmissionResponseDTO>> SearchUniversitiesAsync(string searchTerm)
        {
            return await _context.Universities
                .Where(u => u.UniversityName.Contains(searchTerm))
                .Select(u => new UniversityAdmissionResponseDTO
				{
                    UniversityName = u.UniversityName,
                    Faculties = u.University_Faculties.Select(uf => new NewFacultyDTO
                    {
                        FacultyName = uf.Faculty.FacultyName,
                        Specialties = uf.Faculty.Speciality_Faculties.Select(sf => new NewSpecialityDTO
                        {
                            SpecialtyName = sf.Speciality.SpecialityName
                        }).ToList()
                    }).ToList()
                }).ToListAsync();
        }
    }
}

