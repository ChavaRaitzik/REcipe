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
			delete br 
			from Recipe r
			join CookbookRecipe br
			on r.RecipeId = br.RecipeId
			where r.CuisineId = @CuisineId

			delete mcr
			from Recipe r
			join MealCourseRecipe mcr
			on r.RecipeId = mcr.RecipeId
			where r.CuisineId = @CuisineId
			
			delete ri
			from Recipe r 
			join RecipeIngredient ri 
			on r.RecipeId = ri.RecipeId
			where r.CuisineId = @CuisineId

			delete n 
			from Recipe r 
			join Instructions n 
			on r.RecipeId = n.RecipeId
			where r.CuisineId = @CuisineId

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