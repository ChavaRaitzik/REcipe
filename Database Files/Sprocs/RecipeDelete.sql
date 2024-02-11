create or alter procedure dbo.RecipeDelete(
@recipeid int
)
as 
begin
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
end