CREATE TABLE [FrontPagePostTitulos] (
  [FrontPagePostTitulosId] int IDENTITY (1,1) NOT NULL
, [FrontPagePostCategoriaId] int NOT NULL
, [Grupo] nvarchar(4000) NULL
, [Membro] nvarchar(4000) NULL
, [Rascunho] bit NOT NULL
, [Autor] nvarchar(4000) NULL
, [Data] datetime NULL
, [Titulo] nvarchar(4000) NULL
, [Introducao] nvarchar(200) NULL
, [Descricao] nvarchar(4000) NULL
, [Pasta] nvarchar(4000) NULL
, [LinkExterno] bit NOT NULL
, [LinkUrl] nvarchar(4000) NULL
);
GO
ALTER TABLE [FrontPagePostTitulos] ADD CONSTRAINT [PK_dbo.FrontPagePostTitulos] PRIMARY KEY ([FrontPagePostTitulosId]);
GO
CREATE INDEX [IX_FrontPagePostComponentesId] ON [FrontPagePostTitulos] ([FrontPagePostComponentesId] ASC);
GO
ALTER TABLE [FrontPagePostTitulos] ADD CONSTRAINT [FK_dbo.FrontPagePostTitulos_dbo.FrontPagePostComponentes_FrontPagePostComponentesId] FOREIGN KEY ([FrontPagePostComponentesId]) REFERENCES [FrontPagePostComponentes]([FrontPagePostComponentesId]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
