create or alter procedure dbo.CookbookGet(
	@cookbookid int = 0,
	@all bit = 0,
	@message varchar(500) = '' output
)
as 
begin
	declare @return int = 0;
	select @cookbookid = isnull(@cookbookid,0), @all = isnull(@all,0)
	select b.CookbookId, b.StaffId, b.CookbookName, s."User", b.Price, b.DateCreated, b.CookbookActive
	from Cookbook b 
	join Staff s 
	on b.StaffId = s.StaffId
	where @cookbookid = b.CookbookId
	or @all = 1
	order by b.CookbookName
	return @return
end
go

exec CookbookGet @all = 1