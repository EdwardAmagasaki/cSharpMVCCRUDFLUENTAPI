CREATE TABLE [FrontPagePostComponente] (
  [FrontPagePostComponenteId] int IDENTITY (1,1) NOT NULL
, [FrontPagePostTitulosId] int NOT NULL
, [Grupo] nvarchar(4000) NULL
, [Membro] nvarchar(4000) NULL
, [Rascunho] bit NOT NULL
, [Autor] nvarchar(4000) NULL
, [Data] datetime NULL
, [Componente] nvarchar(4000) NULL
, [Introducao] nvarchar(200) NULL
, [Descricao] nvarchar(4000) NULL
, [Pasta] nvarchar(4000) NULL
, [LinkExterno] bit NOT NULL
, [LinkUrl] nvarchar(4000) NULL
);
GO
ALTER TABLE [FrontPagePostTitulos] ADD CONSTRAINT [PK_dbo.FrontPagePostTitulos] PRIMARY KEY ([FrontPagePostTitulosId]);
GO
CREATE INDEX [IX_FrontPagePostComponenteId] ON [FrontPagePostTitulos] ([FrontPagePostComponenteId] ASC);
GO
ALTER TABLE [FrontPagePostTitulos] ADD CONSTRAINT [FK_dbo.FrontPagePostTitulos_dbo.FrontPagePostComponente_FrontPagePostComponenteId] FOREIGN KEY ([FrontPagePostComponenteId]) REFERENCES [FrontPagePostComponente]([FrontPagePostComponenteId]) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
