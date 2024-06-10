create or alter proc dbo.RecipeClone(
	@RecipeId int,
	@message varchar(500) = '' output
)
as
begin
	declare @NewRecipeId int = 0

	select @RecipeId = isnull(@RecipeId,0)

	Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
	select r.StaffId, r.CuisineId, concat(r.RecipeName, ' - Clone'), r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
	from Recipe r 
	where r.RecipeId = @RecipeId
	
	select @NewRecipeId = SCOPE_IDENTITY();

	Insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, IngredientNum, Quantity)
	select @NewRecipeId, ri.IngredientId, ri.MeasurementId, ri.IngredientNum, ri.Quantity
	from RecipeIngredient ri  
	where ri.RecipeId = @RecipeId
	
	Insert Instructions(RecipeId, StepNum, Instructions)
	select @NewRecipeId, i.StepNum, i.Instructions 
	from Instructions i  
	where i.RecipeId = @RecipeId

	return @NewRecipeId
end