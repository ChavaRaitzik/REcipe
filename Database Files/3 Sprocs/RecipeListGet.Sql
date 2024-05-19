create or alter proc dbo.RecipeListGet(
	@recipeid int = 0,
	@all bit = 0,
	@message varchar(500) = '' output
)
as
begin 
	declare @return int = 0
	select @All = isnull(@All, 0), @RecipeId = isnull(@RecipeId, 0)
	Select r.RecipeId, r.RecipeName, 'Status' = r.RecipeStatus, 'User' = s.UserName, r.Calories, NumIngredients = count(distinct ri.IngredientId)
	from Recipe r 
	left join Staff s 
	on r.StaffId = s.StaffId
	left join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @recipeid 
	or @all = 1
	group by r.RecipeId, r.RecipeName, r.RecipeStatus, s.UserName, r.Calories
	order by r.RecipeStatus desc, r.RecipeName 
	return @return
end
go 

Exec RecipeListGet