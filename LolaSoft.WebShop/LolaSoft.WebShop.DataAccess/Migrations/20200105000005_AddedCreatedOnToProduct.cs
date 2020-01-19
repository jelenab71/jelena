﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LolaSoft.WebShop.DataAccess.Migrations
{
    public partial class AddedCreatedOnToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Products");
        }
    }
}
