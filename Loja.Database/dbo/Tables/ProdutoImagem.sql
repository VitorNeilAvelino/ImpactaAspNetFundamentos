CREATE TABLE [dbo].[ProdutoImagem] (
    [ProdutoId]   INT             NOT NULL,
    [Bytes]       VARBINARY (MAX) NULL,
    [ContentType] NVARCHAR (50)   NOT NULL,
    CONSTRAINT [PK_dbo.ProdutoImagem] PRIMARY KEY CLUSTERED ([ProdutoId] ASC),
    CONSTRAINT [FK_dbo.ProdutoImagem_dbo.Produto_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [dbo].[Produto] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ProdutoId]
    ON [dbo].[ProdutoImagem]([ProdutoId] ASC);

