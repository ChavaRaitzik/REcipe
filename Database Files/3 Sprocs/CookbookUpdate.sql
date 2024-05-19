create or alter procedure dbo.CookbookUpdate(
	@CookbookId int output,
	@StaffId int,
	@CookbookName varchar(75),
	@Price decimal(5,2),
	@DateCreated date output,
	@CookbookActive bit,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId, 0), @StaffId = isnull(@StaffId, 0), @DateCreated = isnull(@DateCreated, GetDate())

	if @CookbookId = 0
	begin
		Insert Cookbook(StaffId, CookbookName, Price, DateCreated, CookbookActive)
		values(@StaffId, @CookbookName, @Price, @DateCreated, @CookbookActive)

		select @CookbookId = SCOPE_IDENTITY()
	end
	else
	begin
		Update Cookbook
		set
			StaffId = @StaffId, 
			CookbookName = @CookbookName,
			Price = @Price,
			DateCreated = @DateCreated,
			CookbookActive = @CookbookActive
			where CookbookId = @CookbookId
	end

	return @return
end
go