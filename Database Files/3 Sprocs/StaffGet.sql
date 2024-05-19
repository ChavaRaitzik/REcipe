create or alter procedure dbo.StaffGet(
	@staffid int = 0,
	@user varchar(71) = '',
	@all bit = 0,
	@includeblank bit = 0,
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @staffid = isnull(@staffid,0), @all = isnull(@all,0)
	select s.StaffId, s.UserName, s.FirstName, s.LastName, s."User"
	from Staff s
	where s.StaffId = @staffid
	or @all = 1
	or (@user <> '' and s."User" like '%' + @user + '%')
	union select 0, '', '', '', ''
	where @includeblank = 1
	order by s."User"
	return @return
end

/*
exec StaffGet

declare @staffid int
select top 1 @staffid = s.staffid from Staff s
exec StaffGet @staffid = @staffid

exec StaffGet @user = null
exec StaffGet @user = 'a'

exec StaffGet @all = 0
exec StaffGet @all = 1
*/