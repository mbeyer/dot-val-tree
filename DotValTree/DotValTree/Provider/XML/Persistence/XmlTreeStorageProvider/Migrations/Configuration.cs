namespace DotValTree.Migrations
{
    using DotValTree.Provider.XML;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TreeDataContext>
    {

        public Configuration()
        {
            MigrationsDirectory = @"Provider\XML\Persistence\EFNodeStorageProvider\Migrations";
        }

        protected override void Seed(TreeDataContext context)
        {

        }
    }
}
