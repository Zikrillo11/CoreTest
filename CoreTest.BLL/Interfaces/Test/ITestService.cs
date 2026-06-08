using CoreTest.Common.Pagination;
using CoreTest.Contracts.Criteria.Test;
using CoreTest.Shared.DTOs.Tests;

namespace CoreTest.Contracts.Interface.Test
{
    public interface ITestService
    {
        Task<PagedList<TestForResultDTO>> GetAllAsync(TestCriteria criteria);
        Task<TestForResultDTO> GetByIdAsync(long id);
        Task<long> CreateAsync(TestForCreateDTO newDTO);
        Task<bool> UpdateAsync(TestForUpdateDTO newDTO);
        Task<bool> DeleteAsync(long id);
    }
}
