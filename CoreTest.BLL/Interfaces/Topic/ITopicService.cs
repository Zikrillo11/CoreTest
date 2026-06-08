using CoreTest.Common.Pagination;
using CoreTest.Contracts.Criteria.User;
using CoreTest.Shared.DTOs.Topic;
using CoreTest.Shared.DTOs.User;

namespace CoreTest.Contracts.Interface.User;

public interface ITopicService
{
    Task<PagedList<TopicForResultDTO>> GetAllAsync(TopicCriteria criteria);
    Task<TopicForResultDTO> GetByIdAsync(long id);
    Task<long> RegisterAsync(TopicForCreateDTO newDTO);
    Task<bool> UpdateAsync(long id, TopicForUpdateDTO updateDTO);
    Task<bool> DeleteAsync(long id);
}
