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
	select (select r.RecipeId from Recipe r where r.RecipeId = @NewRecipeId), ri.IngredientId, ri.MeasurementId, ri.IngredientNum, ri.Quantity
	from RecipeIngredient ri  
	join Recipe r 
	on ri.RecipeId = r.RecipeId
	where r.RecipeId = @RecipeId
	
	Insert Instructions(RecipeId, StepNum, Instructions)
	select (select r.RecipeId from Recipe r where r.RecipeId = @NewRecipeId), i.StepNum, i.Instructions 
	from Instructions i  
	join Recipe r 
	on i.RecipeId = r.RecipeId
	where r.RecipeId = @RecipeId

	return @NewRecipeId
end