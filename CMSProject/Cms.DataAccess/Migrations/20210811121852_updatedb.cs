using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cms.DataAccess.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contactforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameSurname = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Tel = table.Column<string>(type: "text", nullable: true),
                    FormContent = table.Column<string>(type: "text", nullable: true),
                    IsReaded = table.Column<bool>(type: "boolean", nullable: false),
                    IsAnswered = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LanguageTag = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pagecontainers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    texteditor = table.Column<string>(type: "text", nullable: true),
                    language = table.Column<string>(type: "text", nullable: true),
                    isactive = table.Column<bool>(type: "boolean", nullable: false),
                    createddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagecontainers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pagecontents",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pagetitle = table.Column<string>(type: "text", nullable: true),
                    pagedescription = table.Column<string>(type: "text", nullable: true),
                    pagedetails = table.Column<string>(type: "text", nullable: true),
                    isactive = table.Column<bool>(type: "boolean", nullable: false),
                    titleid = table.Column<int>(type: "integer", nullable: false),
                    createddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagecontents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pagetitles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    menutitle = table.Column<string>(type: "text", nullable: true),
                    link = table.Column<string>(type: "text", nullable: true),
                    menudescription = table.Column<string>(type: "text", nullable: true),
                    targetselection = table.Column<string>(type: "text", nullable: true),
                    currentslanguage = table.Column<string>(type: "text", nullable: true),
                    rownumber = table.Column<int>(type: "integer", nullable: false),
                    rootid = table.Column<int>(type: "integer", nullable: false),
                    isdeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagetitles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "panelusers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    RePassword = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_panelusers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PageTitle = table.Column<string>(type: "text", nullable: true),
                    PageDescription = table.Column<string>(type: "text", nullable: true),
                    WebServerAddress = table.Column<string>(type: "text", nullable: true),
                    WebServerPort = table.Column<string>(type: "text", nullable: true),
                    SMTPServerAddress = table.Column<string>(type: "text", nullable: true),
                    SMTPServerPort = table.Column<string>(type: "text", nullable: true),
                    WebMailUserName = table.Column<string>(type: "text", nullable: true),
                    WebMailPassword = table.Column<string>(type: "text", nullable: true),
                    Tel = table.Column<string>(type: "text", nullable: true),
                    Gsm = table.Column<string>(type: "text", nullable: true),
                    Fax = table.Column<string>(type: "text", nullable: true),
                    CompanyAddress = table.Column<string>(type: "text", nullable: true),
                    Location_Lat = table.Column<string>(type: "text", nullable: true),
                    Location_Lng = table.Column<string>(type: "text", nullable: true),
                    CompanyLogo = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "uploadfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Path = table.Column<string>(type: "text", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    Extension = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uploadfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    pagecontentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_categories_pagecontents_pagecontentId",
                        column: x => x.pagecontentId,
                        principalTable: "pagecontents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contentcontainers",
                columns: table => new
                {
                    contentid = table.Column<int>(type: "integer", nullable: false),
                    containerid = table.Column<int>(type: "integer", nullable: false),
                    pageContentid = table.Column<int>(type: "integer", nullable: true),
                    pageContainerid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contentcontainers", x => new { x.contentid, x.containerid });
                    table.ForeignKey(
                        name: "FK_contentcontainers_pagecontainers_pageContainerid",
                        column: x => x.pageContainerid,
                        principalTable: "pagecontainers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_contentcontainers_pagecontents_pageContentid",
                        column: x => x.pageContentid,
                        principalTable: "pagecontents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "titlecontents",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "integer", nullable: false),
                    ContentId = table.Column<int>(type: "integer", nullable: false),
                    pageTitleid = table.Column<int>(type: "integer", nullable: true),
                    pageContentid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titlecontents", x => new { x.ContentId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_titlecontents_pagecontents_pageContentid",
                        column: x => x.pageContentid,
                        principalTable: "pagecontents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_titlecontents_pagetitles_pageTitleid",
                        column: x => x.pageTitleid,
                        principalTable: "pagetitles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_pagecontentId",
                table: "categories",
                column: "pagecontentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contentcontainers_pageContainerid",
                table: "contentcontainers",
                column: "pageContainerid");

            migrationBuilder.CreateIndex(
                name: "IX_contentcontainers_pageContentid",
                table: "contentcontainers",
                column: "pageContentid");

            migrationBuilder.CreateIndex(
                name: "IX_titlecontents_pageContentid",
                table: "titlecontents",
                column: "pageContentid");

            migrationBuilder.CreateIndex(
                name: "IX_titlecontents_pageTitleid",
                table: "titlecontents",
                column: "pageTitleid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "contactforms");

            migrationBuilder.DropTable(
                name: "contentcontainers");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "panelusers");

            migrationBuilder.DropTable(
                name: "settings");

            migrationBuilder.DropTable(
                name: "titlecontents");

            migrationBuilder.DropTable(
                name: "uploadfiles");

            migrationBuilder.DropTable(
                name: "pagecontainers");

            migrationBuilder.DropTable(
                name: "pagecontents");

            migrationBuilder.DropTable(
                name: "pagetitles");
        }
    }
}
