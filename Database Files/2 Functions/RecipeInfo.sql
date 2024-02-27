create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(165)
as 
begin
	declare @value varchar(165) = ''

	select @value = concat(r.RecipeName, ' (', c.CuisineName, ') has ', count(distinct ri.IngredientId), ' ingredients and ', count(distinct n.InstructionsId), ' steps.')
	from Recipe r 
	join Cuisine c 
	on r.CuisineId = c.CuisineId
	left join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	left join Instructions n 
	on r.RecipeId = n.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName, c.CuisineName

	return @value
end
go

select RecipeInfo = dbo.RecipeInfo(r.RecipeId), r.*
from Recipe r
