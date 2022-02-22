using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class initSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("e4f70024-4e82-465c-9ad7-70d7407dafc9"), "drinks", "London", new DateTime(2021, 11, 27, 14, 26, 20, 887, DateTimeKind.Local), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("cadcf63e-4d07-4ac1-8e62-ae5516b7ac26"), "culture", "Paris", new DateTime(2021, 12, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("07dd2b98-13bc-4ab1-a264-33904657ccdc"), "culture", "London", new DateTime(2022, 2, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("e344fc47-3575-49cc-af12-a872ca482a5c"), "music", "London", new DateTime(2022, 3, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("8d6447f6-0d7f-4c57-9457-8b351826870a"), "drinks", "London", new DateTime(2022, 4, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("e914ee11-906e-46ba-a15e-4ffe2377ab34"), "drinks", "London", new DateTime(2022, 5, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("8cd87b22-1b08-4020-a25f-699c5e5ca9ec"), "drinks", "London", new DateTime(2022, 6, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("2dad67b6-0e9a-451a-8edb-b8430380635f"), "music", "London", new DateTime(2022, 7, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("2a69e10d-baf3-4291-a32a-99413f389029"), "travel", "London", new DateTime(2022, 8, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("54d1d7b8-3c40-4b39-9fb0-da91e792ea58"), "film", "London", new DateTime(2022, 9, 27, 14, 26, 20, 889, DateTimeKind.Local), "Activity 8 months in future", "Future Activity 8", "Cinema" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("07dd2b98-13bc-4ab1-a264-33904657ccdc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2a69e10d-baf3-4291-a32a-99413f389029"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2dad67b6-0e9a-451a-8edb-b8430380635f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("54d1d7b8-3c40-4b39-9fb0-da91e792ea58"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8cd87b22-1b08-4020-a25f-699c5e5ca9ec"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8d6447f6-0d7f-4c57-9457-8b351826870a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("cadcf63e-4d07-4ac1-8e62-ae5516b7ac26"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e344fc47-3575-49cc-af12-a872ca482a5c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e4f70024-4e82-465c-9ad7-70d7407dafc9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e914ee11-906e-46ba-a15e-4ffe2377ab34"));
        }
    }
}
