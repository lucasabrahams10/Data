using System.ComponentModel.DataAnnotations;

namespace LandLord.Models.Entities
{
    internal class StatusCodeEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string StatusCode { get; set; } = null!;

    }
}