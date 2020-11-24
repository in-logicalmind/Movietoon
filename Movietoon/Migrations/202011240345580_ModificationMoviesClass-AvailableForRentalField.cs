namespace Movietoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationMoviesClassAvailableForRentalField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AvailableForRental", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "ReturnedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "ReturnedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "AvailableForRental");
        }
    }
}
