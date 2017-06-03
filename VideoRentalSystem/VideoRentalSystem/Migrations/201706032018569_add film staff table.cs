namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfilmstafftable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FilmStaffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        OriginePlace_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.OriginePlace_Id)
                .Index(t => t.OriginePlace_Id);
            
            CreateTable(
                "dbo.FilmFilmStaffs",
                c => new
                    {
                        Film_Id = c.Int(nullable: false),
                        FilmStaff_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_Id, t.FilmStaff_Id })
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .ForeignKey("dbo.FilmStaffs", t => t.FilmStaff_Id, cascadeDelete: true)
                .Index(t => t.Film_Id)
                .Index(t => t.FilmStaff_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmStaffs", "OriginePlace_Id", "dbo.Countries");
            DropForeignKey("dbo.FilmFilmStaffs", "FilmStaff_Id", "dbo.FilmStaffs");
            DropForeignKey("dbo.FilmFilmStaffs", "Film_Id", "dbo.Films");
            DropIndex("dbo.FilmFilmStaffs", new[] { "FilmStaff_Id" });
            DropIndex("dbo.FilmFilmStaffs", new[] { "Film_Id" });
            DropIndex("dbo.FilmStaffs", new[] { "OriginePlace_Id" });
            DropTable("dbo.FilmFilmStaffs");
            DropTable("dbo.FilmStaffs");
        }
    }
}
