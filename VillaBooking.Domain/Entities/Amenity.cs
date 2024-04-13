using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VillaBooking.Domain.Entities;

public class Amenity
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }
    public string? Description { get; set; }

    [ForeignKey("Villa")]
    public required int VillaId { get; set; }
    public Villa? Villa { get; set; }

    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
}
