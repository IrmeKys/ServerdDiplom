﻿using ServerdDiplom.Model;

namespace ServerdDiplom.Services
{
    public interface IUniversityService
    {
        Task<MainResponse> AddUniversity(UniversityDTO addUniversityDTO);
        Task<MainResponse> UpdateUniversity(UpdateUniversityDTO updateUniversityDTO);
        Task<MainResponse> DeleteUniversity(DeleteUniversityDTO deleteUniversityDTO);
        Task<MainResponse> GetAllUniversity();
        public Task<MainResponse> GetAllUniversityNames();

		Task<SingleUniversityResponse> GetUniversityByName(string University_Name);


    }
}
