CREATE TABLE [dbo].[Usuario] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Login] NVARCHAR (50) NOT NULL,
    [Senha] BINARY (64)   NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC)
);

