CREATE TABLE [FrontPagePostContent] (
  [FrontPagePostContentId] int IDENTITY (1,1) NOT NULL
, [FrontPagePostContentCategoriasId] int NOT NULL
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
ALTER TABLE [FrontPagePostContent] ADD CONSTRAINT [PK_dbo.FrontPagePostContent] PRIMARY KEY ([FrontPagePostContentId]);
GO
CREATE INDEX [IX_FrontPagePostContentCategoriasId] ON [FrontPagePostContent] ([FrontPagePostContentCategoriasId] ASC);
GO
ALTER TABLE [FrontPagePostContent] ADD CONSTRAINT [FK_dbo.FrontPagePostContent_dbo.FrontPagePostContentCategorias_FrontPagePostContentCategoriasId] FOREIGN KEY ([FrontPagePostCodeCategoriasId]) REFERENCES [FrontPagePostContentCategorias]([FrontPagePostContentCategoriasId]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
