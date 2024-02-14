set nocount on
declare @recipeid int

Select top 1 @recipeid = r.RecipeId
from Recipe r
left
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
left
join Instructions ins
on r.RecipeId = ins.RecipeId
left
join MealCourseRecipe mcr
on r.RecipeId = mcr.RecipeId
left
join CookbookRecipe cr
on r.RecipeId = cr.RecipeId
where mcr.MealCourseRecipeId is null
and cr.CookbookRecipeId is null
--and r.RecipeStatus = 'drafted'
and r.RecipeStatus = 'published'
order by r.RecipeId

select 'Table' = 'Recipe', 'Id' = r.RecipeId, 'Title' = r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'Ingredient', ri.IngredientId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @recipeid 
union select 'Instructions', ins.InstructionsId, ins.Instructions from Instructions ins where ins.RecipeId = @recipeid

declare @return int, @message varchar(500)
exec @return = RecipeDelete @recipeid = @recipeid, @message = @message output
select @return, @message

select 'Table' = 'Recipe', 'Id' = r.RecipeId, 'Title' = r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'Ingredient', ri.IngredientId, i.IngredientName from RecipeIngredient ri join Ingredient i on ri.IngredientId = i.IngredientId where ri.RecipeId = @recipeid 
union select 'Instructions', ins.InstructionsId, ins.Instructions from Instructions ins where ins.RecipeId = @recipeid
