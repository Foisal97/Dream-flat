using System;
using DreamFlat.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DreamFlat.DAL
{
    public class DreamFlatContext : DbContext, IDisposable
    {

        public DreamFlatContext() : base("DreamFlatContextS")
        {
        }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}