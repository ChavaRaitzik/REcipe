create or alter procedure dbo.CookbookDelete(
@cookbookid int,
@message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @cookbookid = isnull(@cookbookid, 0)

	begin try
		begin tran
			Delete CookbookRecipe where CookbookId = @cookbookid
			Delete Cookbook where CookbookId = @cookbookid
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go