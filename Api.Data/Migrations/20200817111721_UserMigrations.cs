using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UserMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Email",
                table: "User");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b0bfe80-ed74-444b-b99c-c0627540c319"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Nome", "UpdateAt" },
                values: new object[] { new Guid("b0c8a7be-ecca-450b-a20e-b66fbaafa572"), new DateTime(2020, 8, 17, 8, 17, 17, 771, DateTimeKind.Local).AddTicks(7527), "homero.maduro@eccusinformatica.com.br", "Administrador", new DateTime(2020, 8, 17, 8, 17, 17, 778, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Email",
                table: "User");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b0c8a7be-ecca-450b-a20e-b66fbaafa572"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Nome", "UpdateAt" },
                values: new object[] { new Guid("6b0bfe80-ed74-444b-b99c-c0627540c319"), new DateTime(2020, 8, 17, 8, 20, 22, 10, DateTimeKind.Local).AddTicks(6313), "homero.maduro@eccusinformatica.com.br", "Administrador", new DateTime(2020, 8, 17, 8, 20, 22, 12, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }
    }
}
