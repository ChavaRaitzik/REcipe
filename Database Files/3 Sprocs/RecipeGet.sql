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

	select @All = isnull(@All, 0), @RecipeId = isnull(@RecipeId, 0)

	if @all = 1
	begin
		Select r.RecipeId, r.RecipeName, 'Status' = r.RecipeStatus, 'User' = s."User", r.Calories, NumIngredients = count(distinct ri.IngredientId), r.RecipePic
		from Recipe r 
		join Staff s 
		on r.StaffId = s.StaffId
		left join RecipeIngredient ri 
		on r.RecipeId = ri.RecipeId
		where @all = 1
		group by r.RecipeId, r.RecipeName, r.RecipeStatus, s."User", r.Calories, r.RecipePic
		order by r.RecipeStatus desc, r.RecipeName 
	end
	else
	begin
		select r.RecipeId, r.StaffId, r.CuisineId, r.RecipeName, r.Calories, DateDrafted = convert(Date, r.DateDrafted), DatePublished = convert(Date, r.DatePublished), DateArchived = convert(date,r.DateArchived), r.RecipeStatus
		from Recipe r
		where @recipeid = r.RecipeId
		or (@recipename <> '' and r.RecipeName like '%' + @recipename + '%')
		union select 0, 0, 0, ' ', 0, ' ', ' ', ' ', ' '
		where @includeblank = 1
		order by r.RecipeName
	end

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