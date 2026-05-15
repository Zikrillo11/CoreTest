namespace CoreTest.Contracts.Criteria;

public class BaseCriteria
{
    public string? Search { get; set; }
    public long? CreatedBy { get; set; }
    public long? UpdatedBy { get; set; }
    public DateTime? CreatedFrom { get; set; }
    public DateTime? CreatedTo { get; set; }
    public bool IsGetAll { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public bool IsDescending { get; set; } = true;
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}
