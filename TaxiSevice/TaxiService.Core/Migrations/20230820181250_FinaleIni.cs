using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiService.Core.Migrations
{
    public partial class FinaleIni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarClassId = table.Column<int>(type: "int", nullable: true),
                    CarColorId = table.Column<int>(type: "int", nullable: true),
                    DriverId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarInfo_AspNetUsers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarInfo_CarClass_CarClassId",
                        column: x => x.CarClassId,
                        principalTable: "CarClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarInfo_CarColor_CarColorId",
                        column: x => x.CarColorId,
                        principalTable: "CarColor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClientResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientResponse_Marks_MarkId",
                        column: x => x.MarkId,
                        principalTable: "Marks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    ClientResponseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_CarInfo_CarId",
                        column: x => x.CarId,
                        principalTable: "CarInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_ClientResponse_ClientResponseId",
                        column: x => x.ClientResponseId,
                        principalTable: "ClientResponse",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35b1ea46-ee4f-4240-aa42-b4b2e3e28e15", "7344bec8-aa8d-4df9-8e26-4cc95e24d472", "Driver", "DRIVER" },
                    { "777972fb-f79f-423d-b53d-0edf8f9dafe1", "1ee931fa-1647-432a-9fd1-9c815ecba4a0", "Admin", "ADMIN" },
                    { "ffd7bf94-ac20-4a33-9a1f-39be05ee5d09", "3adbc0b7-71ae-4980-92ab-3f3cee44adf0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06e36b8b-d8db-44e8-a284-489782f887c9", 0, "bfb0b971-1b41-473a-b9ce-527320db2069", "admin@taxiseervice.com", true, null, null, false, null, "ADMIN@TAXISEERVICE.COM", "ADMIN@TAXISEERVICE.COM", "AQAAAAEAACcQAAAAEK7gH0HVxjKgGFp0bIyU54pzRNFd+pCgWu7koarUIxdGouJpJIJxWHMy3VI8vOgOPw==", null, false, "d7e0c27c-c3e9-4f22-b092-43d55592bc92", false, "admin@taxiseervice.com" },
                    { "c3d2ae00-622a-45f2-a957-c23852e8be1a", 0, "0c76bf65-b0b0-4992-8ad2-dc7eb44a5326", "driver@taxiseervice.com", true, null, null, false, null, "DRIVER@TAXISEERVICE.COM", "DRIVER@TAXISEERVICE.COM", "AQAAAAEAACcQAAAAEJee7RT4dMw4sZnijg1vvjosRypV12fl0D90GNguMHj6u3Zu2I04kZLFLOSujHcCZg==", null, false, "f5ff38a3-904e-464c-b904-c64dfafec299", false, "driver@taxiseervice.com" },
                    { "c697ad05-e3a2-4fc6-ba18-9e0cabd93c7e", 0, "ff837348-5d19-44fe-bf07-1274d9bf9693", "user@taxiseervice.com", true, null, null, false, null, "USER@TAXISEERVICE.COM", "USER@TAXISEERVICE.COM", "AQAAAAEAACcQAAAAENxrvd5d8jUDzUuyIkUt/6/UYiCyQnT1r/NYJXRnNuVWcAq2PA3WIJic7MnZWK7XIg==", null, false, "eee9432f-d368-41e0-82d7-77fd64bc060c", false, "user@taxiseervice.com" }
                });

            migrationBuilder.InsertData(
                table: "CarClass",
                columns: new[] { "Id", "CarClassName" },
                values: new object[,]
                {
                    { 1, "Економ-клас" },
                    { 2, "Комфорт-клас" },
                    { 3, "Бізнес-клас" }
                });

            migrationBuilder.InsertData(
                table: "CarColor",
                columns: new[] { "Id", "ColorName" },
                values: new object[,]
                {
                    { 1, "Синій" },
                    { 2, "Зелений" },
                    { 3, "Червоний" },
                    { 4, "Білий" },
                    { 5, "Сірий" },
                    { 6, "Чорний" }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "MarkName" },
                values: new object[,]
                {
                    { 1, "Відмінно" },
                    { 2, "Добре" },
                    { 3, "Не погано" },
                    { 4, "Погано" },
                    { 5, "Дуже погано" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "777972fb-f79f-423d-b53d-0edf8f9dafe1", "06e36b8b-d8db-44e8-a284-489782f887c9" },
                    { "35b1ea46-ee4f-4240-aa42-b4b2e3e28e15", "c3d2ae00-622a-45f2-a957-c23852e8be1a" },
                    { "777972fb-f79f-423d-b53d-0edf8f9dafe1", "c3d2ae00-622a-45f2-a957-c23852e8be1a" },
                    { "777972fb-f79f-423d-b53d-0edf8f9dafe1", "c697ad05-e3a2-4fc6-ba18-9e0cabd93c7e" },
                    { "ffd7bf94-ac20-4a33-9a1f-39be05ee5d09", "c697ad05-e3a2-4fc6-ba18-9e0cabd93c7e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarInfo_CarClassId",
                table: "CarInfo",
                column: "CarClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CarInfo_CarColorId",
                table: "CarInfo",
                column: "CarColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarInfo_DriverId",
                table: "CarInfo",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientResponse_MarkId",
                table: "ClientResponse",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CarId",
                table: "Order",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientResponseId",
                table: "Order",
                column: "ClientResponseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CarInfo");

            migrationBuilder.DropTable(
                name: "ClientResponse");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CarClass");

            migrationBuilder.DropTable(
                name: "CarColor");

            migrationBuilder.DropTable(
                name: "Marks");
        }
    }
}
