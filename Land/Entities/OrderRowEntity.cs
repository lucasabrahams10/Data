using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LandLord.Models.Entities;

internal class OrderRowEntity
{
    [Key]
    public int Id { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdateAt { get; set; } = DateTime.UtcNow;

    [StringLength(1000)]
    public string Description { get; set; } = null!;

    [AllowNull]
    public int EmployeId { get; set; }
    public EmployeEntity Employe { get; set; } = null!;

    [Required]
    public int OrderId { get; set; }
    public OrderEntity OrdersId { get; set; } = null!;

    [Required]
    public int StatusId { get; set; } = 1;
    public StatusCodeEntity StatusCode { get; set; } = null!;

    public ICollection<CommentEntity> Comment = new HashSet<CommentEntity>();
    
}