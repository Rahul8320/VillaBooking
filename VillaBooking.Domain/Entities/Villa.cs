using System.ComponentModel.DataAnnotations;

namespace VillaBooking.Domain.Entities;

public class Villa
{
    [Key]
    public int Id { get; init; }
    [MinLength(5)]
    [MaxLength(50)]
    public required string Name { get; init; }
    [MaxLength(5000)]
    public string? Description { get; init; }
    [Display(Name = "Price Per Night")]
    [Range(10,10000)]
    public required double Price { get; init; }
    [Range(100, 5000)]
    public required int Sqft { get; init; }
    [Range(1,10)]
    public required int Occupancy { get; init; }
    [Display(Name = "Image Url")]
    [Url]
    public string? ImageUrl { get; init; }
    public DateTime CreatedDateTime { get; init; }
    public DateTime UpdatedDateTime { get; init; }
}
