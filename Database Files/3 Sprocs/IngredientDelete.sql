create or alter proc dbo.IngredientDelete(
	@IngredientId int = 0 output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @IngredientId = ISNULL(@IngredientId, 0)

	begin try
	begin tran
		delete br 
		from Ingredient i
		join RecipeIngredient ri 
		on i.IngredientId = ri.IngredientId
		join CookbookRecipe br 
		on ri.RecipeId = br.RecipeId
		where i.IngredientId = @IngredientId

		delete mcr 
		from Ingredient i
		join RecipeIngredient ri 
		on i.IngredientId = ri.IngredientId
		join MealCourseRecipe mcr
		on ri.RecipeId = mcr.RecipeId
		where i.IngredientId = @IngredientId

		delete n 
		from Ingredient i
		join RecipeIngredient ri 
		on i.IngredientId = ri.IngredientId
		join Instructions n 
		on ri.RecipeId = n.RecipeId
		where i.IngredientId = @IngredientId

		delete RecipeIngredient where IngredientId = @IngredientId

		delete r
		from Ingredient i 
		join RecipeIngredient ri
		on i.IngredientId = ri.IngredientId
		join Recipe r 
		on ri.RecipeId = r.RecipeId
		where i.IngredientId = @IngredientId

		delete Ingredient where IngredientId = @IngredientId
		commit
	end try
	begin catch
		throw
		rollback
	end catch

	return @return
end