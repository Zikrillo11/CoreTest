using CoreTest.Common.Pagination;
using CoreTest.Contracts.Criteria.Questions;
using CoreTest.Shared.DTOs.Questions;

namespace CoreTest.Contracts.Interface.Question
{
    public interface IQuestionService
    {
        Task<PagedList<QuestionForResultDTO>> GetAllAsync(QuestionsCriteria criteria);
        Task<QuestionForResultDTO> GetByIdAsync(long id);
         Task<long> CreateAsync(QuestionForCreateDTO newDTO);
         Task<bool> UpdateAsync(QuestionForUpdateDTO updateDTO);
         Task<bool> DeleteAsync(long id);
    }
}
