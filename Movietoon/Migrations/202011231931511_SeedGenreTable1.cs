namespace Movietoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(12, 'Adventure')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(14, 'Fantasy')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(16, 'Animation')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(18, 'Drama')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(27, 'Horror')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(28, 'Action')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(35, 'Comedy')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(36, 'History')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(37, 'Western')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(53, 'Thriller')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(80, 'Crime')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(99, 'Documentary')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(878, 'Science Fiction')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(9648, 'Mystery')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(10402, 'Music')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(10749, 'Romance')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(10751, 'Family')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(10752, 'War')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(10770, 'TV Movie')");
        }

        public override void Down()
        {
        }
    }
}
