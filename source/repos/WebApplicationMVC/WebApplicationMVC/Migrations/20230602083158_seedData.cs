using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplicationMVC.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Employes",
                columns: new[] { "Id", "Age", "Departement", "Email", "Image", "Name" },
                values: new object[,]
                {
                    { 2, 25, 0, "employe1@gmail.com", "/Images/e1.jpg", "Employe1" },
                    { 3, 30, 2, "employe2@gmail.com", "/Images/e2.png", "Employe2" },
                    { 4, 32, 1, "employe3@gmail.com", "/Images/e3.png", "Employe3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Employes",
                columns: new[] { "Id", "Age", "Departement", "Email", "Image", "Name" },
                values: new object[,]
                {
                    { -3, 32, 1, "employe3@gmail.com", "/Images/e3.png", "Employe3" },
                    { -2, 30, 2, "employe2@gmail.com", "/Images/e2.png", "Employe2" },
                    { -1, 25, 0, "employe1@gmail.com", "/Images/e1.jpg", "Employe1" }
                });
        }
    }
}
