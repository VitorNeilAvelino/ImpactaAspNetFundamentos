CREATE TABLE [dbo].[Categoria] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Nome] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_dbo.Categoria] PRIMARY KEY CLUSTERED ([Id] ASC)
);

