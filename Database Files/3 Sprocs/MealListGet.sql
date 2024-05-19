create or alter proc dbo.MealListGet(
	@mealid int = 0, 
	@all bit = 0,
	@message varchar(500) = '' output
)
as
begin 
	declare @return int = 0
	select @mealid = isnull(@mealid, 0), @all = isnull(@all,0)
	Select m.MealId, m.MealName, 'User' = s.UserName, NumCalories = sum(r.Calories), NumCourses = count(distinct mc.CourseId), NumRecipes = count(distinct mcr.RecipeId)
	from Recipe r 
	left join MealCourseRecipe mcr 
	on r.RecipeId = mcr.RecipeId
	left join MealCourse mc 
	on mcr.MealCourseId = mc.MealCourseId
	left join Meal m 
	on mc.MealId = m.MealId
	join Staff s 
	on m.StaffId = s.StaffId 
	where m.MealActive = 1
	and (@mealid = m.MealId or @All = 1)
	group by m.MealId, m.MealName, m.MealActive, s.Username
	order by m.MealName 
	return @return
end
go 

Exec MealListGet