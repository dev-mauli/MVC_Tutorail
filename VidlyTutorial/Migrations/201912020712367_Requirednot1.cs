namespace VidlyTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Requirednot1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "extra1", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "del_flag", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "del_flag");
            DropColumn("dbo.Customers", "extra1");
        }
    }
}
