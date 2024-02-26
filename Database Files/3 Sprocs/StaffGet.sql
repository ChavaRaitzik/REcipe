create or alter procedure dbo.StaffGet(
	@staffid int = 0,
	@username varchar(35) = '',
	@all bit = 0
)
as
begin
	select s.StaffId, s.UserName, s.FirstName, s.LastName
	from Staff s
	where s.StaffId = @staffid
	or @all = 1
	or (@username <> '' and s.UserName like '%' + @username + '%')
	order by s.UserName
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