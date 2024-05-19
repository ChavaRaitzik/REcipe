create or alter proc dbo.RecipeInstructionsDelete(
	@InstructionsId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @InstructionsId = isnull(@InstructionsId, 0)

	delete Instructions where InstructionsId = @InstructionsId

	return @return
end 
go