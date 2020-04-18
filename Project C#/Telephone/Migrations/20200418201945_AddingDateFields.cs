using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Telephone.Migrations
{
    public partial class AddingDateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id_city = table.Column<int>(nullable: false),
                    name_city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    rate_pm = table.Column<string>(fixedLength: true, maxLength: 15, nullable: true),
                    rate_am = table.Column<string>(fixedLength: true, maxLength: 15, nullable: true),
                    discount_percent = table.Column<string>(fixedLength: true, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__City__5E31E358DB595405", x => x.Id_city);
                });

            migrationBuilder.CreateTable(
                name: "Subscribe",
                columns: table => new
                {
                    Id_abonent = table.Column<int>(nullable: false),
                    number_phone = table.Column<string>(maxLength: 15, nullable: false),
                    INPP = table.Column<string>(fixedLength: true, maxLength: 15, nullable: false),
                    street = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    bank_account = table.Column<string>(fixedLength: true, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Subscrib__FC7E124B42073673", x => x.Id_abonent);
                });

            migrationBuilder.CreateTable(
                name: "Talk",
                columns: table => new
                {
                    Id_talk = table.Column<int>(nullable: false),
                    Id_abonent = table.Column<int>(nullable: false),
                    Id_city = table.Column<int>(nullable: false),
                    time_talk = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    ddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    time_of_date = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Talk__629752E85ED897B0", x => x.Id_talk);
                    table.ForeignKey(
                        name: "FK__Talk__Id_abonent__2A4B4B5E",
                        column: x => x.Id_abonent,
                        principalTable: "Subscribe",
                        principalColumn: "Id_abonent",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Talk__Id_city__2B3F6F97",
                        column: x => x.Id_city,
                        principalTable: "City",
                        principalColumn: "Id_city",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cost",
                columns: table => new
                {
                    Id_talk = table.Column<int>(nullable: false),
                    cost = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__Cost__Id_talk__2C3393D0",
                        column: x => x.Id_talk,
                        principalTable: "Talk",
                        principalColumn: "Id_talk",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cost_Id_talk",
                table: "Cost",
                column: "Id_talk");

            migrationBuilder.CreateIndex(
                name: "IX_Talk_Id_abonent",
                table: "Talk",
                column: "Id_abonent");

            migrationBuilder.CreateIndex(
                name: "IX_Talk_Id_city",
                table: "Talk",
                column: "Id_city");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cost");

            migrationBuilder.DropTable(
                name: "Talk");

            migrationBuilder.DropTable(
                name: "Subscribe");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
