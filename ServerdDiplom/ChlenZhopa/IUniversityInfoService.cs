namespace ServerdDiplom.ChlenZhopa
{
    public interface IUniversityInfoService
    {
        Task<UniversityInfoDTO> GetUniversityInfoAsync(string universityName, string facultyName, string specialityName);
    }
}
