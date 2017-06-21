CREATE TABLE [dbo].[Tarefa] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Nome]        NVARCHAR (200)  NOT NULL,
    [Prioridade]  INT             NOT NULL,
    [Concluida]   BIT             CONSTRAINT [DF_Tarefa_Concluida] DEFAULT ((0)) NOT NULL,
    [Observacoes] NVARCHAR (1000) NULL,
    CONSTRAINT [PK_Tarefa] PRIMARY KEY CLUSTERED ([Id] ASC)
);

