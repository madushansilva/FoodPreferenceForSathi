namespace FoodPreference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Ic", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Ic", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
