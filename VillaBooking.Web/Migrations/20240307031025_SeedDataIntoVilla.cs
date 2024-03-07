using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaBooking.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDateTime", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The superior services and facilities offered at Maitri Retreat will make for a memorable stay. Parking is provided free of charge for guests. Smoking may only take place in restricted designated areas. Guests are guaranteed a comfortable stay while at Maitri Retreat. To enhance your stay, some rooms at the bungalow come with linen service and air conditioning. The bungalow's in-room entertainment is second to none, with television and cable TV provided to guests in select rooms. You may be assured to know that instant coffee and instant tea are available in some select rooms. You can stay fresh and clean with toiletries and towels provided in some of the guest bathrooms.", "https://placehold.co/600x400", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Athithi homestay is a place with aesthetic ambience and offers a beautiful view of the garden and mountains along with mesmerizing view of the sunset. Homestay, where elegance and comfort meet to create an unforgettable experience. Situated in a serene and picturesque location, our villa offers a perfect retreat for those seeking tranquility and relaxation. You'll be greeted by a spacious and beautifully designed living area that exudes charm and sophistication. The interior is tastefully decorated with a blend of modern aesthetics and traditional elements, creating a warm and inviting atmosphere. Our friendly and attentive staff is dedicated to making your stay exceptional. From housekeeping services to arranging transportation or organizing excursions, we strive to meet your every need. Whether you're planning a family vacation, a romantic getaway, or a retreat with friends, our villa homestay provides the perfect setting for an unforgettable experience. Immerse yourself in luxury, comfort, and natural beauty, and create memories that will last a lifetime. Rooms are elegantly furnished and offer a serene atmosphere for a peaceful stay. They are equipped with either a king-size bed or twin beds, depending on your preference. The rooms are adorned with tasteful decor and provide ample space for relaxation.", "https://placehold.co/600x401", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It's rare to find a place that's both historic and one of a kind. A 150-year old heritage property with its old world charm thoughtfully embellished with modern facilities, invites you to relax, unwind and leave totally rejuvenated.Set amidst a sprawling field of greenery.The chirping of the birds to wake you in the morning and enjoy the beauty of nature as butterflies float around you.Go on a hike, or sit by the fire. Meditate or simply watch the sunset. Come and Make Happy Memories! The space The property is stretched to 10+Acres with Forest Area, Livestock Areas, Garden Areas + Living Areas. The Living Areas include the Heritage Building with the ground floor accessible to guests and a Cottage accessible to guests who have booked the Cottage rooms. The Living Area also consists of a traditional wood fire kitchen. Guest access The Dining, Library, the Lounge, the recreational garden areas and the selected farming areas is also accessible to the Guests.", "https://placehold.co/600x402", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
