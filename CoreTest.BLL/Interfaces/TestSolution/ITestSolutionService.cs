using CoreTest.Common.Pagination;
using CoreTest.Shared.DTOs.TestSolution;

namespace CoreTest.Contracts.Interface.User;

public interface ITEstSolutionService
{
    Task<PagedList<TestSolutionForResultDTO>> GetAllAsync(TestSolutionCriteria criteria);
    Task<TestSolutionForResultDTO> GetByIdAsync(long id);
    Task<long> RegisterAsync(TestSolutionForCreateDTO newDTO);
    Task<bool> UpdateAsync(long id, TestSolutionForUpdateDTO updateDTO);
    Task<bool> DeleteAsync(long id);
}
