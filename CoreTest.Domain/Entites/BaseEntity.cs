using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTest.Domain.Entites;

public class BaseEntity
{
    [Key]
    public long Id { get; set; }
    [Column("created_by")]
    public long? CreatedBy { get; set; }
    [Column("updated_by")]
    public long? UpdatedBy { get; set; }
    [Column("deleted_by")]
    public long? DeletedBy { get; set; }
    [Column("is_deleted")]
    public bool IsDeleted { get; set; } = false;
    [Column("is_active")]
    public bool IsActive { get; set; } = true;
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(5);
    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}
