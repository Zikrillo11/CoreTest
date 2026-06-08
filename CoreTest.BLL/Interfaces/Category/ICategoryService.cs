using CoreTest.Common.Pagination;
using CoreTest.Contracts.Criteria.Category;
using CoreTest.Shared.DTOs.Categories;

namespace CoreTest.Contracts.Interface.Categories;

public interface ICategoryService
{
    Task<PagedList<CategoryForResultDTo>> GetAllAsync(CategoryCriteria criteria);
    Task<CategoryForResultDTo> GetByIdAsync(long id);
    Task<long> CreateAsync(CategoryForCreateDTO newDTO);
    Task<bool> UpdateAsync(CategoryForUpdateDTO updateDTO);
    Task<bool> DeleteAsync(long id);
}