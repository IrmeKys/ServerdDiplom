namespace ServerdDiplom.HyuPizda
{
    public interface IUniversityAdmissionService
    {
        Task<List<UniversityAdmissionResponseDTO>> GetUniversitiesBySubjectsAsync(List<string> subjectNames, int? passingScore = null);
    }
}
