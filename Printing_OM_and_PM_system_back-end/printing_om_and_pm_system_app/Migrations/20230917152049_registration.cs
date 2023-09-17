using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace printing_om_and_pm_system_app.Migrations
{
    /// <inheritdoc />
    public partial class registration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Billing_Zipcode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Last_Name",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "First_Name",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Billing_City",
                table: "Users",
                newName: "BillingCity");

            migrationBuilder.RenameColumn(
                name: "Billing_Address",
                table: "Users",
                newName: "BillingAddress");

            migrationBuilder.AddColumn<int>(
                name: "BillingZipCode",
                table: "Users",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Roles",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingZipCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "Last_Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "First_Name");

            migrationBuilder.RenameColumn(
                name: "BillingCity",
                table: "Users",
                newName: "Billing_City");

            migrationBuilder.RenameColumn(
                name: "BillingAddress",
                table: "Users",
                newName: "Billing_Address");

            migrationBuilder.AddColumn<int>(
                name: "Billing_Zipcode",
                table: "Users",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
