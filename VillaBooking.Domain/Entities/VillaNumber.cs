using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VillaBooking.Domain.Entities;

public class VillaNumber
{
    [Key, DatabaseGenerated((DatabaseGeneratedOption.None))]
    public required int Villa_Number { get; set; }

    [ForeignKey("Villa")]
    public required int VillaId { get; set; }

    public Villa? Villa { get; set; }

    public string? SpecialDetails { get; set;}
}
