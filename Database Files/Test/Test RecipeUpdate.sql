declare @Message varchar(500) = '', @return int,
	@RecipeId int,
	@StaffId int ,
	@CuisineId int ,
	@RecipeName varchar (75),
	@Calories int ,
	@DateDrafted datetime,
	@DatePublished datetime,
	@DateArchived datetime

select top 1
	@RecipeId = RecipeId,
	@StaffId = StaffId,
	@CuisineId = CuisineId,
	@RecipeName = RecipeName,
	@Calories = Calories,
	@DateDrafted = DateDrafted,
	@DatePublished = DatePublished,
	@DateArchived = DateArchived
from Recipe 

Select @RecipeName = REVERSE(@RecipeName), @Calories = @Calories + 1

exec @return = RecipeUpdate
	@RecipeId = @RecipeId output,
	@StaffId = @StaffId,
	@CuisineId = @CuisineId,
	@RecipeName = @RecipeName,
	@Calories = @Calories,
	@DateDrafted = @DateDrafted output,
	@DatePublished = @DatePublished output,
	@DateArchived = @DateArchived output,
	@Message = @Message output

select @return, @message

select * from Recipe where RecipeId = @RecipeId
	