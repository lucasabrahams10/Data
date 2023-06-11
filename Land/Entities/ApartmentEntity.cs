using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LandLord.Models.Entities;

internal class ApartmentEntity
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string City { get; set; } = null!;

    [Column(TypeName = "char(6)")]
    public string ZipCode { get; set; } = null!;

    [StringLength(70)]
    public string StreetName { get; set; } = null!;

    [Column(TypeName = "tinyint")]
    public byte HouseNumber { get; set; }

    [Column(TypeName = "char(1)")]
    public string Entrance { get; set; } = null!;

    [Column(TypeName = "smallint")]
    public short ApartmentNumber { get; set; }

    public ICollection<TenantEntity> Tenant = new HashSet<TenantEntity>();
}