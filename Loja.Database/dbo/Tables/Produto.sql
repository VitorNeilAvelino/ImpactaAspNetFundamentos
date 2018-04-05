CREATE TABLE [dbo].[Produto] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Nome]         NVARCHAR (200) NOT NULL,
    [Preco]        DECIMAL (9, 2) NOT NULL,
    [Estoque]      INT            NOT NULL,
    [Categoria_Id] INT            NULL,
    [Ativo]        BIT            DEFAULT ((1)) NOT NULL,
    [EmLeilao]     BIT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.Produto] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Produto_dbo.Categoria_Categoria_Id] FOREIGN KEY ([Categoria_Id]) REFERENCES [dbo].[Categoria] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Categoria_Id]
    ON [dbo].[Produto]([Categoria_Id] ASC);

