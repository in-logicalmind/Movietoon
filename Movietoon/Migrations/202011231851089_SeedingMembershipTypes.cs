namespace Movietoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Description, DiscountPct, Months) VALUES('Pay as you go', 0, 0)");
            Sql("INSERT INTO MembershipTypes(Description, DiscountPct, Months) VALUES('Monthly', 10, 1)");
            Sql("INSERT INTO MembershipTypes(Description, DiscountPct, Months) VALUES('Quarterly', 20, 3)");
            Sql("INSERT INTO MembershipTypes(Description, DiscountPct, Months) VALUES('Yearly', 50, 12)");
        }
        
        public override void Down()
        {
        }
    }
}
