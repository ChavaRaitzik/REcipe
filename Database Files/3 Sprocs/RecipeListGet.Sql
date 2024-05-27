create or alter proc dbo.RecipeListGet(
	@recipeid int = 0,
	@all bit = 0,
	@message varchar(500) = '' output
)
as
begin 
	declare @return int = 0
--LB: Formatting tip: Add line break before the select statement and after the select statement.

	select @All = isnull(@All, 0), @RecipeId = isnull(@RecipeId, 0)
	Select r.RecipeId, r.RecipeName, 'Status' = r.RecipeStatus, 'User' = s."User", r.Calories, NumIngredients = count(distinct ri.IngredientId)
	from Recipe r 
--LB: No need to left join staff, staff can not be null.
	left join Staff s 
	on r.StaffId = s.StaffId
	left join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @recipeid 
	or @all = 1
	group by r.RecipeId, r.RecipeName, r.RecipeStatus, s."User", r.Calories
	order by r.RecipeStatus desc, r.RecipeName 
	return @return
end
go 

Exec RecipeListGet