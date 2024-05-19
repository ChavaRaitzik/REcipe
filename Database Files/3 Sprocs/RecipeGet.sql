create or alter procedure dbo.RecipeGet(
	@recipeid int = 0,
	@recipename varchar(75) = '',
	@all bit = 0,
	@includeblank bit = 0,
	@message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	select @recipeid = isnull(@recipeid,0), @all = isnull(@all,0)
	select r.RecipeId, r.StaffId, r.CuisineId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePic,
		RecipeInfo = dbo.RecipeInfo(r.RecipeId)
	from Recipe r
	where @recipeid = r.RecipeId
	or @all = 1
	or (@recipename <> '' and r.RecipeName like '%' + @recipename + '%')
	union select 0, 0, 0, ' ', 0, ' ', ' ', ' ', ' ', ' ', ' '
	where @includeblank = 1
	order by r.RecipeName
	return @return
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