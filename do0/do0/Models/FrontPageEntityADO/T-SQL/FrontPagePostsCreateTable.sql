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
