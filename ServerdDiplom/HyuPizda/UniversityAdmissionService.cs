using ServerdDiplom.Model.DTO;
using ServerdDiplom.Model;
using ServerdDiplom.Context;
using Microsoft.EntityFrameworkCore;

namespace ServerdDiplom.HyuPizda
{
    public class UniversityAdmissionService : IUniversityAdmissionService
    {
        private readonly DiplomDbContext _context;

        public UniversityAdmissionService(DiplomDbContext context)
        {
            _context = context;
        }

        public async Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesBySubjectsAsync(List<string> subjectNames, int? passingScore = null)
        {
            var specialityIds = await _context.Speciality_Exams
                .Where(se => subjectNames.Contains(se.Exams.Exams_Name))
                .Select(se => se.SpecialityId)
                .ToListAsync();

            if (passingScore.HasValue)
            {
                var passingScoreIds = await _context.Speciality_PassingScoreFrees
                    .Where(sp => sp.PassingScoreDayFreeFM.PassingScoreValueDayFree <= passingScore || sp.PassingScoreDayFreeFM.PassingScoreValueDayForMoney <= passingScore)
                    .Select(sp => sp.SpecialityId)
                    .ToListAsync();

                specialityIds = await _context.Speciality_Faculties
                    .Where(sf => specialityIds.Contains(sf.SpecialityId) && passingScoreIds.Contains(sf.SpecialityId))
                    .Select(sf => sf.SpecialityId)
                    .ToListAsync();
            }

            var facultyIds = await _context.Speciality_Faculties
                .Where(sf => specialityIds.Contains(sf.SpecialityId))
                .Select(sf => sf.FacultyId)
                .ToListAsync();

            var universityIds = await _context.University_Faculties
                .Where(uf => facultyIds.Contains(uf.FacultyId))
                .Select(uf => uf.UniversityId)
                .ToListAsync();

            var universities = await _context.Universities
                .Where(u => universityIds.Contains(u.Id))
                .ToListAsync();

            var universityDtos = universities.Select(u => new UniversityAdmissionResponseDTO
            {
                UniversityName = u.UniversityName,
                Faculties = _context.University_Faculties
                    .Where(uf => uf.UniversityId == u.Id && facultyIds.Contains(uf.FacultyId))
                    .Select(uf => new NewFacultyDTO
                    {
                        FacultyName = _context.Faculties
                            .Where(f => f.Id == uf.FacultyId)
                            .Select(f => f.FacultyName)
                            .FirstOrDefault(),
                        Specialties = _context.Speciality_Faculties
                            .Where(sf => sf.FacultyId == uf.FacultyId && specialityIds.Contains(sf.SpecialityId))
                            .Select(sf => new NewSpecialityDTO
                            {
                                SpecialtyName = _context.Speciality
                                    .Where(s => s.Id == sf.SpecialityId)
                                    .Select(s => s.SpecialityName)
                                    .FirstOrDefault()
                            })
                            .ToList()
                    })
                    .ToList()
            }).ToList();

            return universityDtos;
        }




    }
}
