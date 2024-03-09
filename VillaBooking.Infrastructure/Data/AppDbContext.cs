using Microsoft.EntityFrameworkCore;
using VillaBooking.Domain.Entities;

namespace VillaBooking.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Villa> Villas { get; set; }
    public DbSet<VillaNumber> VillaNumbers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Villa>().HasData(
        new Villa(){
            Id = 1,
            Name = "Royal Villa",
            Description = "The superior services and facilities offered at Maitri Retreat will make for a memorable stay. Parking is provided free of charge for guests. Smoking may only take place in restricted designated areas. Guests are guaranteed a comfortable stay while at Maitri Retreat. To enhance your stay, some rooms at the bungalow come with linen service and air conditioning. The bungalow's in-room entertainment is second to none, with television and cable TV provided to guests in select rooms. You may be assured to know that instant coffee and instant tea are available in some select rooms. You can stay fresh and clean with toiletries and towels provided in some of the guest bathrooms.",
            ImageUrl = "https://placehold.co/600x400",
            Occupancy = 4,
            Price = 200,
            Sqft = 550,
            CreatedDateTime = DateTime.UtcNow,
            UpdatedDateTime = DateTime.UtcNow
        },
        new Villa()
        {
            Id = 2,
            Name = "Premium Pool Villa",
            Description = "Athithi homestay is a place with aesthetic ambience and offers a beautiful view of the garden and mountains along with mesmerizing view of the sunset. Homestay, where elegance and comfort meet to create an unforgettable experience. Situated in a serene and picturesque location, our villa offers a perfect retreat for those seeking tranquility and relaxation. You'll be greeted by a spacious and beautifully designed living area that exudes charm and sophistication. The interior is tastefully decorated with a blend of modern aesthetics and traditional elements, creating a warm and inviting atmosphere. Our friendly and attentive staff is dedicated to making your stay exceptional. From housekeeping services to arranging transportation or organizing excursions, we strive to meet your every need. Whether you're planning a family vacation, a romantic getaway, or a retreat with friends, our villa homestay provides the perfect setting for an unforgettable experience. Immerse yourself in luxury, comfort, and natural beauty, and create memories that will last a lifetime. Rooms are elegantly furnished and offer a serene atmosphere for a peaceful stay. They are equipped with either a king-size bed or twin beds, depending on your preference. The rooms are adorned with tasteful decor and provide ample space for relaxation.",
            ImageUrl = "https://placehold.co/600x401",
            Occupancy = 4,
            Price = 300,
            Sqft = 550,
            CreatedDateTime = DateTime.UtcNow,
            UpdatedDateTime = DateTime.UtcNow
        },
        new Villa()
        {
            Id = 3,
            Name = "Luxury Pool Villa",
            Description = "It's rare to find a place that's both historic and one of a kind. A 150-year old heritage property with its old world charm thoughtfully embellished with modern facilities, invites you to relax, unwind and leave totally rejuvenated.Set amidst a sprawling field of greenery.The chirping of the birds to wake you in the morning and enjoy the beauty of nature as butterflies float around you.Go on a hike, or sit by the fire. Meditate or simply watch the sunset. Come and Make Happy Memories! The space The property is stretched to 10+Acres with Forest Area, Livestock Areas, Garden Areas + Living Areas. The Living Areas include the Heritage Building with the ground floor accessible to guests and a Cottage accessible to guests who have booked the Cottage rooms. The Living Area also consists of a traditional wood fire kitchen. Guest access The Dining, Library, the Lounge, the recreational garden areas and the selected farming areas is also accessible to the Guests.",
            ImageUrl = "https://placehold.co/600x402",
            Occupancy = 4,
            Price = 400,
            Sqft = 750,
            CreatedDateTime = DateTime.UtcNow,
            UpdatedDateTime = DateTime.UtcNow
        });

        modelBuilder.Entity<VillaNumber>().HasData(
            new VillaNumber()
            {
                Villa_Number = 101,
                VillaId = 1,
            },
            new VillaNumber()
            {
                Villa_Number = 102,
                VillaId = 1,
            },
            new VillaNumber()
            {
                Villa_Number = 103,
                VillaId = 1,
            },
            new VillaNumber()
            {
                Villa_Number = 201,
                VillaId = 2,
            },
            new VillaNumber()
            {
                Villa_Number = 202,
                VillaId = 2,
            },
            new VillaNumber()
            {
                Villa_Number = 203,
                VillaId = 2,
            },
            new VillaNumber()
            {
                Villa_Number = 301,
                VillaId = 3,
            },
            new VillaNumber()
            {
                Villa_Number = 302,
                VillaId = 3,
            },
            new VillaNumber()
            {
                Villa_Number = 303,
                VillaId = 3,
            }
        );
    }
}
