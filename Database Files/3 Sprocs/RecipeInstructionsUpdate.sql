create or alter proc dbo.RecipeInstructionsUpdate(
	@InstructionsId int = 0 output,
	@RecipeId int = 0,
	@StepNum int = 0,
	@Instructions varchar(200) = ' ',
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @InstructionsId = isnull(@InstructionsId,0), @RecipeId = isnull(@RecipeId,0), @StepNum = isnull(@StepNum,0)

	If @InstructionsId = 0
	begin
		insert Instructions(RecipeId, StepNum, Instructions)
		values(@RecipeId, @StepNum, @Instructions)
		select @InstructionsId = SCOPE_IDENTITY()
	end
	else
	begin
		update Instructions
		set 
			RecipeId = @RecipeId,
			StepNum = @StepNum,
			Instructions = @Instructions
		where InstructionsId = @InstructionsId
	end

	return @return
end
go