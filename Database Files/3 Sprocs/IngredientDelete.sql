create or alter proc dbo.IngredientDelete(
	@IngredientId int = 0 output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @IngredientId = ISNULL(@IngredientId, 0)

--LB: No need to delete recipe, instructions etc. in order to delete ingredient. Please remove all unnecessary statements. 
	begin try
		begin tran
			delete RecipeIngredient where IngredientId = @IngredientId

			delete Ingredient where IngredientId = @IngredientId
		commit
	end try
	begin catch
		throw
		rollback
	end catch

	return @return
end