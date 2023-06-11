using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LandLord.Models.Entities;

internal class OrderEntity
{
    [Key]
    public int Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public int TenantId { get; set; }
    public TenantEntity Tenant { get; set; } = null!;

    [AllowNull]
    public int EmployeId { get; set; }
    public EmployeEntity Employe { get; set; } = null!;


    public ICollection<OrderRowEntity> OrderRows = new HashSet<OrderRowEntity>();
}