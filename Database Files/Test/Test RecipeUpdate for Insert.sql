declare @Message varchar(500) = '', @return int, @recipeid int, @staffid int, @cuisineid int, @recipename varchar(75), @datedrafted datetime

select top 1 @staffid = StaffId from Staff
Select top 1 @cuisineid = CuisineId from Cuisine
select @recipename = concat('New Yummy Food Created ', GetDate())

exec @return = RecipeUpdate
	@RecipeId = @recipeid output, 
	@StaffId = @staffid, 
	@CuisineId = @cuisineId, 
	@RecipeName = @recipename, 
	@Calories = 250, 
	@DateDrafted = @datedrafted output,
	@Message = @Message output

select @return, @message
	
select * from Recipe where RecipeId = @recipeid

delete recipe where RecipeId = @recipeid
