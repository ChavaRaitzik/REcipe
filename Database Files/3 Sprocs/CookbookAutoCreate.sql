create or alter proc dbo.CookbookAutoCreate(
	@staffid int = 0,
	@message varchar(500) = '' output 
)

as
begin
	declare @NewCookbookId int = 0

	;
	with x as(
    select r.StaffId, s."User", Price = count(r.RecipeId) * 1.33
    from recipe r 
    join Staff s 
    on r.StaffId = s.StaffId  
    where r.StaffId = @staffid
    group by r.StaffId, s."User"
	)
	Insert Cookbook(StaffId, CookbookName, Price, CookbookActive, DateCreated)
	select x.StaffId, concat('Recipes by ', x."User"), x.Price, 1, getdate()
	from x

	select @NewCookbookId = SCOPE_IDENTITY()
	
	Insert CookbookRecipe(CookbookId, RecipeId, RecipeNum)
	select b.CookbookId, r.RecipeId, Row_Number() over (order by r.RecipeName)
	from Cookbook b
	join Recipe r 
	on b.StaffId = r.StaffId 
	where b.CookbookId = @NewCookbookId

	return @NewCookbookId
end

/*
declare @NewCookbook int
exec @NewCookbook = CookbookAutoCreate @staffid = 21
select @NewCookbook
*/

