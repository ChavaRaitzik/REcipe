create or alter proc dbo.RecipeInstructionsGet(
	@InstructionsId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @InstructionsId = isnull(@InstructionsId, 0)
	select n.InstructionsId, n.RecipeId, n.Instructions, n.StepNum 
	from Instructions n
	where n.Instructionsid = @InstructionsId
	or n.RecipeId = @RecipeId
	or @all = 1

	return @return
end
go

--exec RecipeInstructionsGet @all = 1
--exec RecipeInstructionsGet @InstructionsId = 5