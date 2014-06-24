using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Persistence.EntityFramework
{
    class NodeDataContext : DbContext
    {
        public DbSet<AbstractNode> AbstractNodes { get; set; }

        public NodeDataContext()
            : base("Name=NodeModel")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            OnAbstractLogicalNodeModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void OnAbstractLogicalNodeModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbstractNode>().HasKey(m => m.NodeId);
            modelBuilder.Entity<AbstractNode>().Property(m => m.NodeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
