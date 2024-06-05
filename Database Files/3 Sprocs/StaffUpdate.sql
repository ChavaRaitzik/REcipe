create or alter proc dbo.StaffUpdate(
	@StaffId int = 0 output,
	@Username varchar(35) = ' ',
	@FirstName varchar(35) = ' ',
	@LastName varchar(35) = ' ',
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0)

	if @StaffId = 0
	begin
		insert Staff(UserName, FirstName, LastName)
		values (@Username, @FirstName, @LastName)
		select @StaffId = SCOPE_IDENTITY()
	end
	else 
	begin
		update Staff
		set 
			Username = @Username,
			FirstName = @FirstName,
			LastName = @LastName
		where StaffId = @StaffId
	end

	return @return
end