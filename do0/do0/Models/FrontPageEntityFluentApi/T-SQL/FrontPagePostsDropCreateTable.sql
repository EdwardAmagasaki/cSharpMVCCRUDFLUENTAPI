DROP TABLE [FrontPagePosts];
GO
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