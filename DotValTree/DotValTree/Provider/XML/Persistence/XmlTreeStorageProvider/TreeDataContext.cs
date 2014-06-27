using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider.XML
{
    public class TreeDataContext : DbContext
    {
        public DbSet<XmlValidationTree> ValidationTree { get; set; }

        public TreeDataContext()
            : base("Name=ValidationModel")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            OnValidationTreeModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void OnValidationTreeModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<XmlValidationTree>().HasKey(m => m.ValidationId);
            modelBuilder.Entity<XmlValidationTree>().Property(m => m.ValidationId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<XmlValidationTree>().Property(m => m.Tree).IsRequired();
        }
    }
}
