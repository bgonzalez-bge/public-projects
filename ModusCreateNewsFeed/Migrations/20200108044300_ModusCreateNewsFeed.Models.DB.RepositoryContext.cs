using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModusCreateNewsFeed.Migrations
{
    public partial class ModusCreateNewsFeedModelsDBRepositoryContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    URL = table.Column<string>(maxLength: 500, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    FeedCategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feeds_FeedCategories_FeedCategoryId",
                        column: x => x.FeedCategoryId,
                        principalTable: "FeedCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feeds_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subcriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    FeedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcriptions_Feeds_FeedId",
                        column: x => x.FeedId,
                        principalTable: "Feeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subcriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FeedCategories",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Sports" },
                    { 2, "Entertainment" },
                    { 3, "Politics" },
                    { 4, "My feeds" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[] { 1, "ModusCreate", "ModusCreate" });

            migrationBuilder.InsertData(
                table: "Feeds",
                columns: new[] { "Id", "Description", "FeedCategoryId", "Title", "URL", "UserId" },
                values: new object[,]
                {
                    { 1, "Follow us to keep up with the news on Football, Golf, Rugby, Cricket, Tennis, F1, Boxing and more from Sky Sports", 1, "SkySports", "https://www.skysports.com/rss/12040", null },
                    { 2, "The latest sports news, video, analysis, scores and better info. Covering the NFL, MLB, NBA, NHL, NASCAR, college football and basketball, soccer and more.", 1, "Sporting News", "http://www.sportingnews.com/us/rss", null },
                    { 3, "Realtime rumors, news and gossip from thousands of sports blogs ", 1, "Yardbarker", "https://www.yardbarker.com/rss/rumors", null },
                    { 4, "Covering the greatest heroes of the big and small screen ranging from comic book legends to iconic characters in cinema. ", 2, "Heroic Hollywood", "https://heroichollywood.com/feed", null },
                    { 5, "Deadline.com is always the first to break up-to-the-minute entertainment, Hollywood and media news, with an unfiltered, no-holds-barred analysis of events. The site is the go-to source for breaking news about the business of TV, film, media and other entertainment ", 2, "Deadline", "https://deadline.com/feed/", null },
                    { 6, "The Black Hollywood Education and Resource Center, a nonprofit, public benefit organization, is designed to advocate, educate, research, develop, and preserve the history, and the future, of blacks in the film and television industries.", 2, "Black Hollywood", "https://bherc.org/feed", null },
                    { 7, "News, opinion and multimedia on politics and government.", 3, "The New York Times", "https://rss.nytimes.com/services/xml/rss/nyt/Politics.xml", null },
                    { 8, "Essential political coverage from California and the presidential campaign, including in-depth commentary, analysis and election results.", 3, "Los Angeles Times", "https://www.latimes.com/politics/rss2.0.xml", null }
                });

            migrationBuilder.InsertData(
                table: "Subcriptions",
                columns: new[] { "Id", "FeedId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Subcriptions",
                columns: new[] { "Id", "FeedId", "UserId" },
                values: new object[] { 2, 4, 1 });

            migrationBuilder.InsertData(
                table: "Subcriptions",
                columns: new[] { "Id", "FeedId", "UserId" },
                values: new object[] { 3, 7, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Feeds_FeedCategoryId",
                table: "Feeds",
                column: "FeedCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Feeds_UserId",
                table: "Feeds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcriptions_FeedId",
                table: "Subcriptions",
                column: "FeedId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcriptions_UserId",
                table: "Subcriptions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subcriptions");

            migrationBuilder.DropTable(
                name: "Feeds");

            migrationBuilder.DropTable(
                name: "FeedCategories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
