namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRemarkToRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Remark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "Remark");
        }
    }
}
