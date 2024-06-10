create or alter proc dbo.CookbookListGet(
	@CookbookId int = 0,
	@All bit = 0,
	@message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @CookbookId = isnull(@cookbookid,0), @all = isnull(@all,0)

	select b.CookbookId, b.CookbookName, Author = s."User", NumRecipes = count(br.CookbookRecipeId), b.Price
	from Cookbook b 
	join Staff s 
	on b.StaffId = s.StaffId
	left join CookbookRecipe br 
	on b.CookbookId = br.CookbookId
	where b.CookbookId = @cookbookid
	or @All = 1
	group by b.CookbookId, b.CookbookName, s."User", b.Price
	order by b.CookbookName 

	return @return
end
go 

--Exec CookbookListGet