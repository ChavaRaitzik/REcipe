use HeartyHearthDB
go
--select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES R

grant execute on CookbookRecipeDelete to approle
grant execute on CuisineGet to approle
grant execute on RecipeGet to approle
grant execute on StaffGet to approle
grant execute on RecipeIngredientGet to approle
grant execute on CuisineUpdate to approle
grant execute on InstructionsGet to approle
grant execute on CuisineDelete to approle
grant execute on IngredientUpdate to approle
grant execute on RecipeDelete to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on IngredientGet to approle
grant execute on RecipeClone to approle
grant execute on RecipeInstructionsUpdate to approle
grant execute on MealCalories to approle
grant execute on RecipeInfo to approle
grant execute on RecipeInstructionsGet to approle
grant execute on CookbookAutoCreate to approle
grant execute on MeasurementGet to approle
grant execute on DashboardSummaryGet to approle
grant execute on RecipeIngredientDelete to approle
grant execute on RecipeInstructionsDelete to approle
grant execute on RecipeChangeStatus to approle
grant execute on RecipeListGet to approle
grant execute on MealGet to approle
grant execute on MealListGet to approle
grant execute on CourseGet to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on IngredientDelete to approle
grant execute on MeasurementUpdate to approle
grant execute on MeasurementDelete to approle
grant execute on CourseUpdate to approle
grant execute on CourseDelete to approle
grant execute on CookbookListGet to approle
grant execute on StaffUpdate to approle
grant execute on CookbookDelete to approle
grant execute on CookbookUpdate to approle
grant execute on CookbookRecipeGet to approle
grant execute on RecipeUpdate to approle
grant execute on CookbookGet to approle
grant execute on StaffDelete to approle