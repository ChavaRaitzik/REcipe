create or alter function dbo.MealCalories(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = sum(r.Calories)
	from MealCourse mc
	join MealCourseRecipe mcr
	on mc.MealCourseId = mcr.MealCourseId
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	where mc.MealId = @MealId
	group by mc.MealId

	return @value
end
go

select MealCalories = dbo.MealCalories(m.MealId), m.* 
from Meal m
