create or alter procedure dbo.CuisineGet(
	@cuisineid int = 0,
	@cuisinename varchar(30) = '',
	@all bit = 0
)
as
begin
	declare @return int = 0

	select @cuisineid = isnull(@cuisineid,0), @all = isnull(@all,0)

	select c.CuisineId, c.CuisineName 
	from Cuisine c
	where c.Cuisineid = @cuisineid
	or @all = 1
	or (@cuisinename <> '' and c.CuisineName like '%' + @cuisinename + '%')
	order by c.CuisineName

	return @return
end
go

/*
exec CuisineGet

declare @cuisineid int = 0
select top 1 @cuisineid = c.cuisineid from cuisine c 
exec CuisineGet @cuisineid = @cuisineid

exec CuisineGet @cuisinename = null
exec CuisineGet @cuisinename = 'a'

exec CuisineGet @all = 0
exec CuisineGet @all = 1
*/