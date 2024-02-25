create or alter procedure dbo.RecipeUpdate(
	@RecipeId int  output,
	@StaffId int ,
	@CuisineId int ,
	@RecipeName varchar (75),
	@Calories int ,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @Calories = isnull(@Calories, 0)

	if @RecipeId = 0
	begin
		Insert Recipe(StaffId, CuisineId, RecipeName, Calories)
		values (@StaffId, @CuisineId, @RecipeName, @Calories)

		select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		Update Recipe
		set
			StaffId = @StaffId, 
			CuisineId = @CuisineId, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
		where RecipeId = @RecipeId
	end

	finished:
	return @return
end
go