using Microsoft.EntityFrameworkCore.Migrations;

namespace SPMSOJT.Server.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    middle_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barangay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phonenum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    citizenship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    schoolemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    college = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    schoolname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    school_barangay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    school_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    school_province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    school_zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_info", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_info");
        }
    }
}
