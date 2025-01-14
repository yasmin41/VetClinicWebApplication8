using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetClinicWebApplication8.Migrations
{
    /// <inheritdoc />
    public partial class pettabledeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DE_Date",
                table: "Owners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Deworming",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NextDe_Date",
                table: "Owners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NextVac_Date",
                table: "Owners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Pet_BD",
                table: "Owners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VacDose",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Vac_Date",
                table: "Owners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "DE_Date",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Deworming",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "NextDe_Date",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "NextVac_Date",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "PetName",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Pet_BD",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Species",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "VacDose",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Vac_Date",
                table: "Owners");

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DE_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deworming = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextDe_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextVac_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet_BD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VacDose = table.Column<int>(type: "int", nullable: false),
                    Vac_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                    table.ForeignKey(
                        name: "FK_Pets_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "OwnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");
        }
    }
}
