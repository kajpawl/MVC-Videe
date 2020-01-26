namespace Videe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Epics')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Musical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Science-Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'War')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Western')");
        }

        public override void Down()
        {
        }
    }
}
