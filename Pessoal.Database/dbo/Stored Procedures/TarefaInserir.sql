CREATE PROCEDURE [dbo].[TarefaInserir] 
	@nome nvarchar(200),
	@prioridade int,
	@concluida bit,
	@observacoes nvarchar(1000)
AS
	INSERT INTO [dbo].[Tarefa]
           ([Nome]
           ,[Prioridade]
           ,[Concluida]
           ,[Observacoes])
	 output INSERTED.Id
     VALUES
           (@nome
           ,@Prioridade
           ,@Concluida
           ,@Observacoes)