create or alter proc dbo.DashboardSummaryGet(
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select Type = 'Recipes', Number = count(r.RecipeId)
	from Recipe r 
	union select 'Meals', count(m.MealId)
	from Meal m 
	union select 'Cookbooks', count(c.CookbookId)
	from Cookbook c 
	order by Type desc
	return @return
end
go

exec DashboardSummaryGet