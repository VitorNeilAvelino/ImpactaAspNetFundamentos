CREATE TABLE [dbo].[UsuarioPerfis] (
    [UserId] NVARCHAR (128) NOT NULL,
    [RoleId] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.UsuarioPerfis] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_dbo.UsuarioPerfis_dbo.Perfil_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Perfil] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.UsuarioPerfis_dbo.Usuario_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Usuario] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[UsuarioPerfis]([UserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_RoleId]
    ON [dbo].[UsuarioPerfis]([RoleId] ASC);

