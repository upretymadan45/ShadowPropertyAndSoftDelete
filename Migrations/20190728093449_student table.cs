using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dropdown.Migrations
{
    public partial class studenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Sections",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 636, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "Sections",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Classes",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(5660),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "Classes",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserTokens",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(4090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserTokens",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 634, DateTimeKind.Local).AddTicks(7840),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserRoles",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(2680),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserRoles",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserLogins",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(1220),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserLogins",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserClaims",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 634, DateTimeKind.Local).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserClaims",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 618, DateTimeKind.Local).AddTicks(6310),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 238, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetRoleClaims",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 634, DateTimeKind.Local).AddTicks(5520),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetRoleClaims",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    RecStatus = table.Column<string>(nullable: false, defaultValue: "A"),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 636, DateTimeKind.Local).AddTicks(2210))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Sections",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(6840),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 636, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "Sections",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Classes",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "Classes",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserTokens",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 634, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserRoles",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(9570),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserRoles",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserLogins",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(8090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 635, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUserClaims",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(6090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 634, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 238, DateTimeKind.Local).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 618, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetRoles",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetRoleClaims",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(2260),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 19, 48, 634, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");
        }
    }
}
