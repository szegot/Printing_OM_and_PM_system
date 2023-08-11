using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace printing_om_and_pm_system_app.Migrations
{
    /// <inheritdoc />
    public partial class _230811 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemServices_Items_Item_ID1",
                table: "ItemServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemServices_Services_Service_ID1",
                table: "ItemServices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Items_Item_ID1",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_Order_ID1",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_User_ID1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessServices_Processes_Process_ID1",
                table: "ProcessServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessServices_Services_Service_ID1",
                table: "ProcessServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Machines_Machine_ID1",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Materials_Material_ID1",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_Machine_ID1",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_Material_ID1",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_ProcessServices_Process_ID1",
                table: "ProcessServices");

            migrationBuilder.DropIndex(
                name: "IX_ProcessServices_Service_ID1",
                table: "ProcessServices");

            migrationBuilder.DropIndex(
                name: "IX_Orders_User_ID1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_Item_ID1",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_Order_ID1",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_ItemServices_Item_ID1",
                table: "ItemServices");

            migrationBuilder.DropIndex(
                name: "IX_ItemServices_Service_ID1",
                table: "ItemServices");

            migrationBuilder.DropColumn(
                name: "Machine_ID1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Material_ID1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Process_ID1",
                table: "ProcessServices");

            migrationBuilder.DropColumn(
                name: "Service_ID1",
                table: "ProcessServices");

            migrationBuilder.DropColumn(
                name: "User_ID1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Item_ID1",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Order_ID1",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Item_ID1",
                table: "ItemServices");

            migrationBuilder.DropColumn(
                name: "Service_ID1",
                table: "ItemServices");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_Machine_ID",
                table: "Services",
                column: "Machine_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_Material_ID",
                table: "Services",
                column: "Material_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessServices_Process_ID",
                table: "ProcessServices",
                column: "Process_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessServices_Service_ID",
                table: "ProcessServices",
                column: "Service_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_User_ID",
                table: "Orders",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Item_ID",
                table: "OrderItems",
                column: "Item_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Order_ID",
                table: "OrderItems",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemServices_Item_ID",
                table: "ItemServices",
                column: "Item_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemServices_Service_ID",
                table: "ItemServices",
                column: "Service_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemServices_Items_Item_ID",
                table: "ItemServices",
                column: "Item_ID",
                principalTable: "Items",
                principalColumn: "Item_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemServices_Services_Service_ID",
                table: "ItemServices",
                column: "Service_ID",
                principalTable: "Services",
                principalColumn: "Service_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Items_Item_ID",
                table: "OrderItems",
                column: "Item_ID",
                principalTable: "Items",
                principalColumn: "Item_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_Order_ID",
                table: "OrderItems",
                column: "Order_ID",
                principalTable: "Orders",
                principalColumn: "Order_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_User_ID",
                table: "Orders",
                column: "User_ID",
                principalTable: "Users",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessServices_Processes_Process_ID",
                table: "ProcessServices",
                column: "Process_ID",
                principalTable: "Processes",
                principalColumn: "Process_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessServices_Services_Service_ID",
                table: "ProcessServices",
                column: "Service_ID",
                principalTable: "Services",
                principalColumn: "Service_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Machines_Machine_ID",
                table: "Services",
                column: "Machine_ID",
                principalTable: "Machines",
                principalColumn: "Machine_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Materials_Material_ID",
                table: "Services",
                column: "Material_ID",
                principalTable: "Materials",
                principalColumn: "Material_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemServices_Items_Item_ID",
                table: "ItemServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemServices_Services_Service_ID",
                table: "ItemServices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Items_Item_ID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_Order_ID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_User_ID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessServices_Processes_Process_ID",
                table: "ProcessServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessServices_Services_Service_ID",
                table: "ProcessServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Machines_Machine_ID",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Materials_Material_ID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Services_Machine_ID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_Material_ID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_ProcessServices_Process_ID",
                table: "ProcessServices");

            migrationBuilder.DropIndex(
                name: "IX_ProcessServices_Service_ID",
                table: "ProcessServices");

            migrationBuilder.DropIndex(
                name: "IX_Orders_User_ID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_Item_ID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_Order_ID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_ItemServices_Item_ID",
                table: "ItemServices");

            migrationBuilder.DropIndex(
                name: "IX_ItemServices_Service_ID",
                table: "ItemServices");

            migrationBuilder.AddColumn<int>(
                name: "Machine_ID1",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Material_ID1",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Process_ID1",
                table: "ProcessServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Service_ID1",
                table: "ProcessServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "User_ID1",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Item_ID1",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order_ID1",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Item_ID1",
                table: "ItemServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Service_ID1",
                table: "ItemServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_Machine_ID1",
                table: "Services",
                column: "Machine_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Services_Material_ID1",
                table: "Services",
                column: "Material_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessServices_Process_ID1",
                table: "ProcessServices",
                column: "Process_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessServices_Service_ID1",
                table: "ProcessServices",
                column: "Service_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_User_ID1",
                table: "Orders",
                column: "User_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Item_ID1",
                table: "OrderItems",
                column: "Item_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Order_ID1",
                table: "OrderItems",
                column: "Order_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemServices_Item_ID1",
                table: "ItemServices",
                column: "Item_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemServices_Service_ID1",
                table: "ItemServices",
                column: "Service_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemServices_Items_Item_ID1",
                table: "ItemServices",
                column: "Item_ID1",
                principalTable: "Items",
                principalColumn: "Item_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemServices_Services_Service_ID1",
                table: "ItemServices",
                column: "Service_ID1",
                principalTable: "Services",
                principalColumn: "Service_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Items_Item_ID1",
                table: "OrderItems",
                column: "Item_ID1",
                principalTable: "Items",
                principalColumn: "Item_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_Order_ID1",
                table: "OrderItems",
                column: "Order_ID1",
                principalTable: "Orders",
                principalColumn: "Order_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_User_ID1",
                table: "Orders",
                column: "User_ID1",
                principalTable: "Users",
                principalColumn: "User_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessServices_Processes_Process_ID1",
                table: "ProcessServices",
                column: "Process_ID1",
                principalTable: "Processes",
                principalColumn: "Process_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessServices_Services_Service_ID1",
                table: "ProcessServices",
                column: "Service_ID1",
                principalTable: "Services",
                principalColumn: "Service_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Machines_Machine_ID1",
                table: "Services",
                column: "Machine_ID1",
                principalTable: "Machines",
                principalColumn: "Machine_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Materials_Material_ID1",
                table: "Services",
                column: "Material_ID1",
                principalTable: "Materials",
                principalColumn: "Material_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
