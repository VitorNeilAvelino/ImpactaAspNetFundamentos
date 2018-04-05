CREATE TABLE [dbo].[UsuarioPermissoes] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [UserId]     NVARCHAR (128) NOT NULL,
    [ClaimType]  NVARCHAR (MAX) NULL,
    [ClaimValue] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.UsuarioPermissoes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.UsuarioPermissoes_dbo.Usuario_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Usuario] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[UsuarioPermissoes]([UserId] ASC);

