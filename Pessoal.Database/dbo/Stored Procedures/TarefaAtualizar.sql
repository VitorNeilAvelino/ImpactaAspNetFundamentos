CREATE PROCEDURE TarefaAtualizar 
	@id int,
	@nome nvarchar(200),
	@prioridade int,
	@concluida bit,
	@observacoes nvarchar(1000)
AS
UPDATE [dbo].[Tarefa]
   SET [Nome] = @nome
      ,[Prioridade] = @Prioridade
      ,[Concluida] = @Concluida
      ,[Observacoes] = @Observacoes
 WHERE Id = @id