CREATE PROCEDURE [dbo].[TarefaSelecionar]
	@id int = null
AS
SELECT [Id]
      ,[Nome]
      ,[Prioridade]
      ,[Concluida]
      ,[Observacoes]
  FROM [dbo].[Tarefa]
  where Id = IsNull(@id, Id)
  Order by Concluida, Prioridade