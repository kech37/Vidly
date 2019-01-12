namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMembershipTypIdOnCustomerTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MembershipTypId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypId", c => c.Byte(nullable: false));
        }
    }
}
