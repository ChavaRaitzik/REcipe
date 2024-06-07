create or alter procedure dbo.RecipeUpdate(
	@RecipeId int  output,
	@StaffId int,
	@CuisineId int,
	@RecipeName varchar (75),
	@Calories int,
	@DateDrafted datetime output,
--LB: This parameter is not used, please remove it.
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @Calories = isnull(@Calories, 0), @DateDrafted = isnull(@DateDrafted, Convert(Date, GetDate()))

	if @RecipeId = 0
	begin
--LB: No need to include DatePublished and DateArchived in the insert statement as they cannot be set frm the front end.
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
--LB: Unnecessary to include the date columns in the update statement as it won't come into this sproc when changing status.
		where RecipeId = @RecipeId
	end

	return @return
end
go