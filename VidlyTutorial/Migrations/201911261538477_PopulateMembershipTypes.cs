namespace VidlyTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes(Id,SignUpfee,Durationinmonths,discountrate) values (1,0,0,0)");

            Sql("Insert into MembershipTypes(Id,SignUpfee,Durationinmonths,discountrate) values (2,30,1,10)");

            Sql("Insert into MembershipTypes(Id,SignUpfee,Durationinmonths,discountrate) values (3,90,3,15)");

            Sql("Insert into MembershipTypes(Id,SignUpfee,Durationinmonths,discountrate) values (4,200,5,20)");
        }
        
        public override void Down()
        {
        }
    }
}
