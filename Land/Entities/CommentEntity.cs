using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandLord.Models.Entities;

internal class CommentEntity
{
    [Key]
    public int Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime WrittenAt { get; set; } = DateTime.UtcNow;

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [Required]
    public int OrderRowId { get; set; }
    public OrderRowEntity OrderRow { get; set; } = null!;

    [Required]
    public int PersonId { get; set; }
    public PersonEntity Person { get; set; } = null!;
}