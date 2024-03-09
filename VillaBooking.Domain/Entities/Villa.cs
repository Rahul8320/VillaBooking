using System.ComponentModel.DataAnnotations;

namespace VillaBooking.Domain.Entities;

public class Villa
{
    [Key]
    public int Id { get; set; }
    [MinLength(5)]
    [MaxLength(50)]
    public required string Name { get; set; }
    [MaxLength(5000)]
    public string? Description { get; set; }
    [Display(Name = "Price Per Night")]
    [Range(10,10000)]
    public required double Price { get; set; }
    [Range(100, 5000)]
    public required int Sqft { get; set; }
    [Range(1,10)]
    public required int Occupancy { get; set; }
    [Display(Name = "Image Url")]
    [Url]
    public string? ImageUrl { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
}
