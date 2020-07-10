namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopularGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'SciFi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5,'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6,'Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
