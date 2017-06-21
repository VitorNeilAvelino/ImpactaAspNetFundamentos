Create PROCEDURE [dbo].[TarefaSelecionarNaoConcluidas]
	@prioridade int
AS
SELECT [Id]
      ,[Nome]
      ,[Prioridade]
      ,[Concluida]
      ,[Observacoes]
  FROM [dbo].[Tarefa]
  where Prioridade = @prioridade
  and Concluida = 0
  Order by Concluida, Prioridade