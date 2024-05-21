create or alter proc dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @RecipeIngredientId = isnull(@RecipeIngredientId, 0), @RecipeId = isnull(@RecipeId, 0)

	select ri.RecipeIngredientId, ri.RecipeId, ri.MeasurementId, ri.IngredientId, ri.Quantity, ri.IngredientNum
	from RecipeIngredient ri
	where ri.RecipeIngredientId = @RecipeIngredientId
	or ri.RecipeId = @RecipeId
	or @all = 1;

--LB: It would be nice to order by IngredientNum so that it shows up in the right order in the front end.
	return @return
end
go

--exec RecipeIngredientGet @all = 1
--exec RecipeIngredientGet @recipeingredientid = 10