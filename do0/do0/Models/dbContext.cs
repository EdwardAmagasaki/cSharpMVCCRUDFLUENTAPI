using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using do0.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
//using do0.Migrations;

namespace do0.Models
{
    public class do0Context : DbContext
    {
      public do0Context()
    : base("do0Context")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<do0Context, Configuration>());
            //Database.SetInitializer<do0Context>(new DropCreateDatabaseIfModelChanges<do0Context>());
            //Database.SetInitializer<do0Context>(new DropCreateDatabaseAlways<do0Context>());
            //Database.SetInitializer<do0Context>(new DropCreateDatabaseIfModelChanges<do0Context>());
            //Database.SetInitializer<do0Context>(new DropCreateDatabaseAlways<do0Context>());
            Database.SetInitializer<do0Context>(new do0DbInicializador1());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FrontPagePostsMap());
            modelBuilder.Configurations.Add(new FrontPagePostListaMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            //Map entity to table
            modelBuilder.Entity<FrontPagePosts>().ToTable("FrontPagePosts");
            modelBuilder.Entity<FrontPagePostLista>().ToTable("FrontPagePostLista", "dbo");
        }

        public DbSet<FrontPagePosts> FrontPagePosts { get; set; }
        public DbSet<FrontPagePostLista> FrontPagePostLista { get; set; }

    }
}