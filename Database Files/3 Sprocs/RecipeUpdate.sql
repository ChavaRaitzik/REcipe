create or alter procedure dbo.RecipeUpdate(
	@RecipeId int  output,
	@StaffId int,
	@CuisineId int,
	@RecipeName varchar (75),
	@Calories int,
	@DateDrafted datetime output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @Calories = isnull(@Calories, 0), @DateDrafted = isnull(@DateDrafted, Convert(Date, GetDate()))

	if @RecipeId = 0
	begin
		Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted)
		values (@StaffId, @CuisineId, @RecipeName, @Calories, @DateDrafted)

		select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		Update Recipe
		set
			StaffId = @StaffId, 
			CuisineId = @CuisineId, 
			RecipeName = @RecipeName, 
			Calories = @Calories
		where RecipeId = @RecipeId
	end

	return @return
end
go