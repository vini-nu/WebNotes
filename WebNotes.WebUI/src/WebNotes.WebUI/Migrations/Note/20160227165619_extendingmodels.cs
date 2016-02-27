using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace WebNotes.WebUI.Migrations.Note
{
    public partial class extendingmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_NoteResources_Note_NoteId", table: "NoteResources");
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Notebook",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Note",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddForeignKey(
                name: "FK_NoteResources_Note_NoteId",
                table: "NoteResources",
                column: "NoteId",
                principalTable: "Note",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_NoteResources_Note_NoteId", table: "NoteResources");
            migrationBuilder.DropColumn(name: "UserID", table: "Notebook");
            migrationBuilder.DropColumn(name: "UserID", table: "Note");
            migrationBuilder.AddForeignKey(
                name: "FK_NoteResources_Note_NoteId",
                table: "NoteResources",
                column: "NoteId",
                principalTable: "Note",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
