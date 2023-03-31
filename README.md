# C# Sharp MVC ASP.NET 4.8 CRUD + Fluent API 

FrontPagePosts.cs ( Modelo C# Sharp )

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using do0.Models;
using System.Web.Mvc;
using System.Data.Entity.ModelConfiguration;

namespace do0.Models
{
    public class FrontPagePosts
    {
        public FrontPagePosts()
        {
            this.FrontPagePostLista = new HashSet<FrontPagePostLista>();
        }

        [Key]
        public int do0FrontPagePostsId { get; set; }
        public IEnumerable<FrontPagePostLista> FrontPagePostLista { get; set; }
        [Display(Name = "do0Avatar")]
        public string do0AvatarName { get; set; }
        [Display(Name = "do0User")]
        public string do0UserName { get; set; }

        public bool Rascunho { get; set; }

        [Display(Name = "AUTOR")]
        public string Autor { get; set; }
        [Display(Name = "DATA")]
        public DateTime? Data { get; set; }
        [Display(Name = "TÍTULO")]
        public string Titulo { get; set; }
        [AllowHtml]
        [StringLength(200, MinimumLength = 0, ErrorMessage = "Número máximo de 200 caracteres !")]
        [Display(Name = "INTRODUÇÃO")]
        public string Introducao { get; set; }
        [AllowHtml]
        [StringLength(4000, MinimumLength = 0, ErrorMessage = "Número máximo de 4000 caracteres !")]
        [Display(Name = "DESCRIÇÃO")]
        public string Descricao { get; set; }
        [Display(Name = "PASTA")]
        public string Pasta { get; set; }

        [Display(Name = "LINK EXTERNO?")]
        public bool LinkExterno { get; set; }

        [Display(Name = "ENDEREÇO URL LINK")]
        public string LinkUrl { get; set; }
        public bool Reserva1 { get; set; }
    }
}

public class FrontPagePostsMap : EntityTypeConfiguration<FrontPagePosts> 
{
    public FrontPagePostsMap()
    {
        // Tabela
        this.ToTable("FrontPagePosts");

        // Chave primária
        this.HasKey(x => x.do0FrontPagePostsId);

        // Relacionamentos
       // this.HasMany(x => x.FrontPagePostLista);

        // Propriedades
        this.Property(x => x.do0AvatarName).HasColumnName("do0Avatar").HasMaxLength(100);
        this.Property(x => x.do0UserName).HasColumnName("do0User").HasMaxLength(100);
        this.Property(x => x.Autor).HasMaxLength(100);
        this.Property(x => x.Data);
        this.Property(x => x.Titulo).HasMaxLength(100);
        this.Property(x => x.Introducao).HasMaxLength(200);
        this.Property(x => x.Descricao).HasMaxLength(4000);
        this.Property(x => x.Pasta).HasMaxLength(100);
        this.Property(x => x.LinkUrl).HasMaxLength(1000);


    }
}

public partial class Configo
{
    public string URL0 { get; set; }
}
public partial class urlDominio : Configo
{
    public string URL { get; set; }
}

public partial class title : Configo
{
    public void startConfigo()
    {
        MetaEntity = new MetaEntity();
    }

    public MetaEntity MetaEntity { get; set; }
}

public class MetaEntity
{
    public System.DateTime Time { get; set; }
    public string Location { get; set; }
    public string title { get; set; }
    public string subTitle { get; set; }

}
```

Sub-Título - FrontPagePostListas.cs  ( Modelo C# Sharp )


```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using do0.Models;
using System.Web.Mvc;
using System.Data.Entity.ModelConfiguration;

namespace do0.Models
{
    public class FrontPagePostLista
    {
        [Key]
        public int FrontPagePostListaId { get; set; }
        public int do0FrontPagePostsId { get; set; }
        public FrontPagePosts FrontPagePosts { get; set; }

        [Display(Name = "do0Avatar")]
        public string do0AvatarName { get; set; }
        [Display(Name = "do0User")]
        public string do0UserName { get; set; }

        public bool Rascunho { get; set; }
        [Display(Name = "AUTOR")]
        public string Autor { get; set; }
        [Display(Name = "DATA")]
        public DateTime? Data { get; set; }
        [Display(Name = "TÍTULO")]
        public string Titulo { get; set; }
        [AllowHtml]
        [StringLength(200, MinimumLength = 0, ErrorMessage = "Número máximo de 200 caracteres !")]
        [Display(Name = "INTRODUÇÃO")]
        public string Introducao { get; set; }
        [AllowHtml]
        [StringLength(4000, MinimumLength = 0, ErrorMessage = "Número máximo de 4000 caracteres !")]
        [Display(Name = "DESCRIÇÃO")]
        public string Descricao { get; set; }
        [Display(Name = "PASTA")]
        public string Pasta { get; set; }

        [Display(Name = "LINK EXTERNO?")]
        public bool LinkExterno { get; set; }

        [Display(Name = "ENDEREÇO URL LINK")]
        public string LinkUrl { get; set; }
        public bool Reserva1 { get; set; }
    }


    public class FrontPagePostListaMap : EntityTypeConfiguration<FrontPagePostLista>
    {
        public FrontPagePostListaMap()
        {
            // Tabela
            this.ToTable("FrontPagePostLista");

            // Chave primária
            this.HasKey(x => x.do0FrontPagePostsId);

            // Relacionamentos
            //this.HasMany(x => x.FrontPagePosts);

            // Propriedades
            this.Property(x => x.do0AvatarName).HasColumnName("do0Avatar").HasMaxLength(100);
            this.Property(x => x.do0UserName).HasColumnName("do0User").HasMaxLength(100);
            this.Property(x => x.Autor).HasMaxLength(100);
            this.Property(x => x.Data);
            this.Property(x => x.Titulo).HasMaxLength(100);
            this.Property(x => x.Introducao).HasMaxLength(200);
            this.Property(x => x.Descricao).HasMaxLength(4000);
            this.Property(x => x.Pasta).HasMaxLength(100);
            this.Property(x => x.LinkUrl).HasMaxLength(1000);
        }
    }


}
```
Context:
```
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
```

