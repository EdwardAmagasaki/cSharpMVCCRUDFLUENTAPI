# C# Sharp MVC ASP.NET 4.8 CRUD + Datatable 

FrontPagePosts.cs ( Modelo C# Sharp )

```
CREATE TABLE [FrontPagePosts] (
  [do0FrontPagePostsId] int IDENTITY (1,1) NOT NULL
, [do0AvatarName] nvarchar(4000) NULL
, [do0UserName] nvarchar(4000) NULL
, [Rascunho] bit NOT NULL
, [Autor] nvarchar(4000) NULL
, [Data] datetime NULL
, [Titulo] nvarchar(4000) NULL
, [Introducao] nvarchar(200) NULL
, [Descricao] nvarchar(4000) NULL
, [Pasta] nvarchar(4000) NULL
, [LinkExterno] bit NOT NULL
, [LinkUrl] nvarchar(4000) NULL
, [Reserva1] bit NOT NULL
);
GO
ALTER TABLE [FrontPagePosts] ADD CONSTRAINT [PK_dbo.FrontPagePosts] PRIMARY KEY ([do0FrontPagePostsId]);
GO
```

```
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourNamespace
{
    public class FrontPagePosts
    {
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

```

Sub-Título - FrontPagePostListas.cs  ( Modelo C# Sharp )

```
CREATE TABLE [FrontPagePostListas] (
  [FrontPagePostListaId] int IDENTITY (1,1) NOT NULL
, [do0FrontPagePostsId] int NOT NULL
, [do0AvatarName] nvarchar(4000) NULL
, [do0UserName] nvarchar(4000) NULL
, [Rascunho] bit NOT NULL
, [Autor] nvarchar(4000) NULL
, [Data] datetime NULL
, [Titulo] nvarchar(4000) NULL
, [Introducao] nvarchar(200) NULL
, [Descricao] nvarchar(4000) NULL
, [Pasta] nvarchar(4000) NULL
, [LinkExterno] bit NOT NULL
, [LinkUrl] nvarchar(4000) NULL
, [Reserva1] bit NOT NULL
);
GO
ALTER TABLE [FrontPagePostListas] ADD CONSTRAINT [PK_dbo.FrontPagePostListas] PRIMARY KEY ([FrontPagePostListaId]);
GO
CREATE INDEX [IX_do0FrontPagePostsId] ON [FrontPagePostListas] ([do0FrontPagePostsId] ASC);
GO
ALTER TABLE [FrontPagePostListas] ADD CONSTRAINT [FK_dbo.FrontPagePostListas_dbo.FrontPagePosts_do0FrontPagePostsId] FOREIGN KEY ([do0FrontPagePostsId]) REFERENCES [FrontPagePosts]([do0FrontPagePostsId]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
```

Sub-Título - FrontPagePostListas.cs  ( Modelo C# Sharp )

```
public class FrontPagePostListas
{
    public int FrontPagePostListaId { get; set; }
    public int do0FrontPagePostsId { get; set; }
    public string do0AvatarName { get; set; }
    public string do0UserName { get; set; }
    public bool Rascunho { get; set; }
    public string Autor { get; set; }
    public DateTime? Data { get; set; }
    public string Titulo { get; set; }
    public string Introducao { get; set; }
    public string Descricao { get; set; }
    public string Pasta { get; set; }
    public bool LinkExterno { get; set; }
    public string LinkUrl { get; set; }
    public bool Reserva1 { get; set; }
}
```
Repositório:
```
public abstract class AbstractRepository<TEntity, TKey>
    where TEntity : class
{
    protected string StringConnection { get; } = WebConfigurationManager.ConnectionStrings["FrontPagePostsContext"].ConnectionString;

    ... >>>
```



O que poderá ser vinculádo de forma opcional? 

1. Vídeo Youtube
2. Link Externo
3. Midia Externa
4. Telegram
5. Twitter
6. Chat GPT
7. Mídia Instragram
8. Mídia Pinterinterest
9. E-Mail
10. 