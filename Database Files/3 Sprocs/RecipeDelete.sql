create or alter procedure dbo.RecipeDelete(
@recipeid int,
@message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	if exists(select * from Recipe r where r.RecipeId = @recipeid and ((r.RecipeStatus = 'published') or (r.RecipeStatus = 'archived' and DateDiff(day, r.DateArchived, GETDATE()) < 30)))
	begin
		select @return = 1, @message = 'Can only delete recipe that either has a status of drafted or archived for over 30 days.'
		goto finished
	end

	begin try
		begin tran
		Delete RecipeIngredient where RecipeId = @recipeId
		Delete Instructions where RecipeId = @recipeid
		Delete Recipe where RecipeId = @recipeid
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

		finished:
		return @return

end
go