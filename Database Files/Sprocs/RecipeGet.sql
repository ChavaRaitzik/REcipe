create or alter procedure dbo.RecipeGet(
	@recipeid int = 0,
	@recipename varchar(75) = '',
	@all bit = 0
)
as 
begin
	select r.RecipeId, r.StaffId, r.CuisineId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic
	from Recipe r
	where @recipeid = r.RecipeId
	or @all = 1
	or (@recipename <> '' and r.RecipeName like '%' + @recipename + '%')
	order by r.RecipeName
end

/*
exec RecipeGet 

declare @recipeid int 
Select top 1 @recipeid = r.recipeid from recipe r 
exec RecipeGet @recipeid = @recipeid

exec RecipeGet @recipename = null
exec RecipeGet @recipename = 'ap'

exec RecipeGet @all = 0
exec RecipeGet @all = 1
*/