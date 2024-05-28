using Microsoft.EntityFrameworkCore;
using ServerdDiplom.Context;
using ServerdDiplom.HyuPizda;

namespace ServerdDiplom.Dota
{
	public class SpecialitySearchService : ISpecialitySearchService
	{
		private readonly DiplomDbContext _context;

		public SpecialitySearchService(DiplomDbContext context)
		{
			_context = context;
		}

		public async Task<List<UniversityAdmissionResponseDTO>> SearchUniversitiesBySpecialityAsync(string searchTerm)
		{
			var universities = await _context.Speciality
				.Where(s => s.SpecialityName.Contains(searchTerm))
				.SelectMany(s => s.Speciality_Faculties)
				.Select(sf => sf.Faculty)
				.SelectMany(f => f.University_Faculties)
				.Select(uf => new UniversityAdmissionResponseDTO
				{
					UniversityName = uf.University.UniversityName,
					Faculties = uf.University.University_Faculties
					.Select(uf => new NewFacultyDTO
					{
						FacultyName = uf.Faculty.FacultyName,
						Specialties = uf.Faculty.Speciality_Faculties
							.Where(sf => sf.Speciality.SpecialityName.Contains(searchTerm))
							.Select(sf => new NewSpecialityDTO
							{
								SpecialtyName = sf.Speciality.SpecialityName
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

