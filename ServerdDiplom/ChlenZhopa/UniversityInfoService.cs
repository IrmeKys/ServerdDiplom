using Microsoft.EntityFrameworkCore;
using ServerdDiplom.ChlenZhopa;
using ServerdDiplom.Context;
using ServerdDiplom.Model.DTO;

public class UniversityInfoService : IUniversityInfoService
{
    private readonly DiplomDbContext _context;

    public UniversityInfoService(DiplomDbContext context)
    {
        _context = context;
    }

    public async Task<UniversityInfoDTO> GetUniversityInfoAsync(string universityName, string facultyName, string specialityName)
    {
        var universityInfo = await _context.Universities
        .Where(u => u.UniversityName == universityName)
        .Select(u => new UniversityInfoDTO
        {
            UniversityName = u.UniversityName,
            UniversityDescription = u.UniversityDescription,
            UniversityLink = u.UniversityLink,
            Town_name = u.Town_name,
            FacultyName = facultyName,
            ComissionNumberInfo = _context.ComissionsNumber
                .Where(cn => cn.UniversityName == universityName)
                .Select(cn => new ComissionNumberInfoDTO
                {
                    ComissionNumber = cn.ComissionNumberValue,
                })
                .FirstOrDefault(),
            SpecialityInfo = _context.University_Faculties
                    .Where(uf => uf.UniversityId == u.Id && uf.Faculty.FacultyName == facultyName)
                    .Join(_context.Speciality_Faculties, uf => uf.FacultyId, sf => sf.FacultyId, (uf, sf) => new { uf, sf })
                    .Where(joined => joined.sf.Speciality.SpecialityName == specialityName)
                    .Join(_context.Speciality_PassingScoreFrees, joined => joined.sf.SpecialityId, sp => sp.SpecialityId, (joined, sp) => sp)
                    .Select(sp => new SpecialityInfoDTO
                    {
                        SpecialityName = specialityName,
                        PassingScore = sp.PassingScoreDayFreeFM.PassingScoreValueDayFree,
                        PassingScoreValueDayForMoney = sp.PassingScoreDayFreeFM.PassingScoreValueDayForMoney
                    })
                    .FirstOrDefault(),
            })
            .FirstOrDefaultAsync();

        return universityInfo;
    }






}
