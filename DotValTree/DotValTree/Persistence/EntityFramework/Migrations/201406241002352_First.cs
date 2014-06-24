namespace DotValTree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbstractNodes",
                c => new
                    {
                        NodeId = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        ValidationType = c.String(),
                        ValidationValue = c.String(),
                        Evaluation = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.NodeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AbstractNodes");
        }
    }
}
