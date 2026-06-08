using CoreTest.Common.Pagination;
using CoreTest.Contracts.Criteria.User;
using CoreTest.Shared.DTOs.UserTestSolutions;

namespace CoreTest.Contracts.Interface.UserTestSolution;

public interface IUserTestSolutionService
{
Task<PagedList<UserTestSolutionsForResultDto>> GetAllAsync(UserCriteria criteria);
    Task<UserTestSolutionsForResultDto> GetByIdAsync(long id);
    Task<long> RegisterAsync(UserTestSolutionsForCreateDto newDTO);
    Task<bool> UpdateAsync(long id, UserTestSolutionsForUpdateDto updateDTO);
    Task<bool> DeleteAsync(long id);
}
