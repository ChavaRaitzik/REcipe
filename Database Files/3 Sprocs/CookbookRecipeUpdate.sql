create or alter proc dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int = 0 output,
	@CookbookId int = 0,
	@RecipeId int = 0,
	@RecipeNum int = 0,
	@Message varchar(500) = '' output
)
as
begin
	select @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull(@CookbookId,0), @RecipeId = isnull(@RecipeId,0), @RecipeNum = isnull(@RecipeNum,0)

	If @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(CookbookId, RecipeId, RecipeNum)
		values(@CookbookId, @RecipeId, @RecipeNum)
		select @CookbookRecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update CookbookRecipe
		set 
			CookbookId = @CookbookId,
			RecipeId = @RecipeId,
			RecipeNum = @RecipeNum
		where CookbookRecipeId = @CookbookRecipeId
	end
end
go