using CoreTest.Common.Pagination;
using CoreTest.Contracts.Criteria.User;
using CoreTest.Shared.DTOs;

namespace CoreTest.Contracts.Interface.User;

public interface IOptionService
{
    Task<PagedList<OptionForResultDTO>> GetAllAsync(OptionrCriteria criteria);
    Task<OptionForResultDTO> GetByIdAsync(long id);
    Task<long> RegisterAsync(OptionForCreateDTO newDTO);
    Task<bool> UpdateAsync(long id, OptionForUpdateDTO updateDTO);
    Task<bool> DeleteAsync(long id);
}
