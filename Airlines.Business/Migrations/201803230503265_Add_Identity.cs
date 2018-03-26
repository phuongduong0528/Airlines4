namespace Airlines.Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Identity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Airline");
            AlterColumn("dbo.Airline", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Airline", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Airline");
            AlterColumn("dbo.Airline", "id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Airline", "id");
        }
    }
}
