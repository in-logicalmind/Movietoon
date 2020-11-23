namespace Movietoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCostAndUnitsForMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Movies", "AmountAvailable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AmountAvailable");
            DropColumn("dbo.Movies", "Price");
        }
    }
}
