using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingAPI.Migrations
{
    /// <inheritdoc />
    public partial class addingSomeRelationsAndChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "TraderProfiles");

            migrationBuilder.DropColumn(
                name: "Governorate",
                table: "TraderProfiles");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "TraderProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "TraderProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GovernorateId",
                table: "TraderProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TraderProfiles_BranchId",
                table: "TraderProfiles",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_TraderProfiles_CityId",
                table: "TraderProfiles",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TraderProfiles_GovernorateId",
                table: "TraderProfiles",
                column: "GovernorateId");

            migrationBuilder.AddForeignKey(
                name: "FK_TraderProfiles_Branches_BranchId",
                table: "TraderProfiles",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TraderProfiles_Cities_CityId",
                table: "TraderProfiles",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TraderProfiles_Governorates_GovernorateId",
                table: "TraderProfiles",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TraderProfiles_Branches_BranchId",
                table: "TraderProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TraderProfiles_Cities_CityId",
                table: "TraderProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TraderProfiles_Governorates_GovernorateId",
                table: "TraderProfiles");

            migrationBuilder.DropIndex(
                name: "IX_TraderProfiles_BranchId",
                table: "TraderProfiles");

            migrationBuilder.DropIndex(
                name: "IX_TraderProfiles_CityId",
                table: "TraderProfiles");

            migrationBuilder.DropIndex(
                name: "IX_TraderProfiles_GovernorateId",
                table: "TraderProfiles");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "TraderProfiles");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "TraderProfiles");

            migrationBuilder.DropColumn(
                name: "GovernorateId",
                table: "TraderProfiles");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "TraderProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Governorate",
                table: "TraderProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
