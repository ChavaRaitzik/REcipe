create or alter proc dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0
	select @CuisineId = isnull(@CuisineId,0)
	begin try
		begin tran
--LB: No need to include cuisine table in most of the statements. Please try to simplify the delete statements.
		delete br 
		from Cuisine c
		join Recipe r
		on c.CuisineId = r.CuisineId
		join CookbookRecipe br
		on r.RecipeId = br.RecipeId
		where c.CuisineId = @CuisineId

		delete mcr
		from Cuisine c
		join Recipe r
		on c.CuisineId = r.CuisineId
		join MealCourseRecipe mcr
		on r.RecipeId = mcr.RecipeId
		where c.CuisineId = @CuisineId
		
		delete ri
		from Cuisine c 
		join Recipe r 
		on c.CuisineId = r.CuisineId
		join RecipeIngredient ri 
		on r.RecipeId = ri.RecipeId
		where c.CuisineId = @CuisineId

		delete n 
		from Cuisine c
		join Recipe r 
		on c.CuisineId = r.CuisineId
		join Instructions n 
		on r.RecipeId = n.RecipeId
		where c.CuisineId = @CuisineId

		delete Recipe where CuisineId = @CuisineId

		delete Cuisine where CuisineId = @CuisineId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	return @return
end