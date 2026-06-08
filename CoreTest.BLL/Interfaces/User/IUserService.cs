using CoreTest.Common.Pagination;
using CoreTest.Contracts.Criteria.User;
using CoreTest.Shared.DTOs.User;

namespace CoreTest.Contracts.Interface.User;

public interface IUserService
{
Task<PagedList<UserForResultDto>> GetAllAsync(OptionrCriteria criteria);
    Task<UserForResultDto> GetByIdAsync(long id);
    Task<long> RegisterAsync(UserForCreateDto newDTO);
    Task<bool> UpdateAsync(long id, UserForUpdateDto updateDTO);
    Task<bool> DeleteAsync(long id);
}
