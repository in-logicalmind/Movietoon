namespace Movietoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDefinitionMoviesAndGenre : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Genres");
            AddColumn("dbo.Genres", "GenreName", c => c.String());
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Genres", "GenretName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "GenretName", c => c.String());
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "GenreId");
            DropColumn("dbo.Genres", "GenreName");
            AddPrimaryKey("dbo.Genres", "Id");
        }
    }
}
