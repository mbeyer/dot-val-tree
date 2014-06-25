namespace DotValTree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.XmlValidationTrees",
                c => new
                    {
                        ValidationId = c.Int(nullable: false, identity: true),
                        Notes = c.String(),
                        Tree = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ValidationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.XmlValidationTrees");
        }
    }
}
