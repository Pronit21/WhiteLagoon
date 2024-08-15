using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class villa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_Villa_Id",
                table: "VillaNumbers");

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 404);

            migrationBuilder.RenameColumn(
                name: "Villa_Id",
                table: "VillaNumbers",
                newName: "VillaId");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_Villa_Id",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_VillaId");

            migrationBuilder.AlterColumn<int>(
                name: "Villa_Number",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "VillaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "VillaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                columns: new[] { "SpecialDetails", "VillaId" },
                values: new object[] { "Special Details for Villa 2", 3 });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "Villa_Number", "SpecialDetails", "VillaId" },
                values: new object[,]
                {
                    { 102, "Special Details for Villa 2", 1 },
                    { 103, "Special Details for Villa 1", 1 },
                    { 201, "Special Details for Villa 2", 2 },
                    { 203, "Special Details for Villa 2", 2 },
                    { 301, "Special Details for Villa 2", 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301);

            migrationBuilder.RenameColumn(
                name: "VillaId",
                table: "VillaNumbers",
                newName: "Villa_Id");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_Villa_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Villa_Number",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Villa_Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Villa_Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                columns: new[] { "SpecialDetails", "Villa_Id" },
                values: new object[] { "Special Details for Villa 1", 0 });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "Villa_Number", "SpecialDetails", "Villa_Id" },
                values: new object[] { 404, "Special Details for Villa 2", 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_Villa_Id",
                table: "VillaNumbers",
                column: "Villa_Id",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
