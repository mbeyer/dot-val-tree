namespace DotValTree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.XmlValidationTrees", "Description", c => c.String());
            DropColumn("dbo.XmlValidationTrees", "Notes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.XmlValidationTrees", "Notes", c => c.String());
            DropColumn("dbo.XmlValidationTrees", "Description");
        }
    }
}
