using System.ComponentModel.DataAnnotations;

namespace LandLord.Models.Entities;

internal class EmployeEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int PersonId { get; set; }
    public PersonEntity Person { get; set; } = null!;

    [Required]
    public int RoleId { get; set; }
    public RoleEntity Role { get; set; } = null!;

    public ICollection<OrderEntity> Orders = new HashSet<OrderEntity>();
}