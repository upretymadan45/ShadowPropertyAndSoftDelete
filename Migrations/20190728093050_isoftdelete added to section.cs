using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dropdown.Migrations
{
    public partial class isoftdeleteaddedtosection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Sections",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(6840),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 770, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "Sections",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDelete",
                table: "Sections",
                nullable: true,
                defaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Classes",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(7470));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(980),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(6050));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 768, DateTimeKind.Local).AddTicks(9940));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(9570),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(4680));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(8090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(3230));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(6090),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(1670));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 238, DateTimeKind.Local).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 754, DateTimeKind.Local).AddTicks(110));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(2260),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 768, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetRoleClaims",
                nullable: false,
                defaultValue: "A",
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSoftDelete",
                table: "Sections");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Sections",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 770, DateTimeKind.Local).AddTicks(1890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(6840));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(7470),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(2550));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(6050),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 255, DateTimeKind.Local).AddTicks(980));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 768, DateTimeKind.Local).AddTicks(9940),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(4290));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(4680),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(9570));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(3230),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(8090));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 769, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(6090));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 754, DateTimeKind.Local).AddTicks(110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 238, DateTimeKind.Local).AddTicks(7440));

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
                defaultValue: new DateTime(2019, 7, 28, 15, 14, 44, 768, DateTimeKind.Local).AddTicks(8060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 28, 15, 15, 50, 254, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.AlterColumn<string>(
                name: "RecStatus",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "A");
        }
    }
}
