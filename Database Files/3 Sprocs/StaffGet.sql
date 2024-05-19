create or alter procedure dbo.StaffGet(
	@staffid int = 0,
	@username varchar(35) = '',
	@all bit = 0,
	@includeblank bit = 0,
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @staffid = isnull(@staffid,0), @all = isnull(@all,0)
	select s.StaffId, s.UserName, s.FirstName, s.LastName
	from Staff s
	where s.StaffId = @staffid
	or @all = 1
	or (@username <> '' and s.UserName like '%' + @username + '%')
	union select 0, '', '', ''
	where @includeblank = 1
	order by s.UserName
	return @return
end

/*
exec StaffGet

declare @staffid int
select top 1 @staffid = s.staffid from Staff s
exec StaffGet @staffid = @staffid

exec StaffGet @username = null
exec StaffGet @username = 'a'

exec StaffGet @all = 0
exec StaffGet @all = 1
*/