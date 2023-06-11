using System.ComponentModel.DataAnnotations;

namespace LandLord.Models.Entities;

internal class RoleEntity
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Role { get; set; } = null!;

    public ICollection<EmployeEntity> Employe = new HashSet<EmployeEntity>();
}