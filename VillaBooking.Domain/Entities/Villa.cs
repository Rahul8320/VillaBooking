using System.ComponentModel.DataAnnotations;

namespace VillaBooking.Domain.Entities;

public class Villa
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    [Display(Name = "Price Per Night")]
    public double Price { get; set; }
    public int Sqft { get; set; }
    public int Occupancy { get; set; }
    [Display(Name = "Image Url")]
    public string? ImageUrl { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
}
