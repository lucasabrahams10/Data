using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace LandLord.Models.Entities;

internal class TenantEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int PersonId { get; set; }
    public PersonEntity Person { get; set; } = null!;

    [Required]
    public int ApartmentId { get; set; }

    public ApartmentEntity Apartment { get; set; } = null!;

    public ICollection<OrderEntity> Order = new HashSet<OrderEntity>();
}