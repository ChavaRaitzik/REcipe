-- SM Excellent neat code! 100%
use HeartyHearthDB
go 


delete dbo.CookbookRecipe
delete dbo.Cookbook
delete dbo.MealCourseRecipe
delete dbo.MealCourse
delete dbo.Meal
delete dbo.Course
delete dbo.Instructions
delete dbo.RecipeIngredient
delete dbo.Recipe
delete dbo.Measurement
delete dbo.Ingredient
delete dbo.Cuisine
delete dbo.Staff 
go 

Insert Staff(FirstName, LastName, Username)
select 'Adina', 'Adler', 'Adina''sAromas'
union select 'Caroline', 'Cohen', 'Caroline''sCreations'
union select 'Debby', 'Deutsch', 'Debby''sDelights'
union select 'Esty', 'Epstein', 'Esty''sEdibles'
union select 'Fay', 'Freund', 'Fay''sFlavors'
union select 'Tova', 'Tepper', 'Tova''sTemptations'

Insert Cuisine(CuisineName)
select 'American'
union select 'Chinese'
union select 'English'
union select 'French'
union select 'Greek'
union select 'Japanese'

Insert Ingredient(IngredientName)
select 'sugar'
union select 'oil'
union select 'eggs'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'garlic'
union select 'crushed garlic'
union select 'black pepper'
union select 'salt'
union select 'butter'
union select 'vanilla pudding'
union select 'eggs'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'lettuce'
union select 'cubed feta cheese'
union select 'black olives'
union select 'cucumber'
union select 'tomato'
union select 'olive oil'
union select 'balsamic vinegar'
union select 'white rice'
union select 'water'
union select 'onions'
union select 'coke'
union select 'chicken bones'
union select 'carrots'
union select 'parsnip'
union select 'zucchini'
union select 'potato'
union select 'vinegar'

Insert Measurement(MeasurementName)
select 'cup'
union select 'tsp'
union select 'tbsp'
union select 'clove'
union select 'cloves'
union select 'stick'
union select 'sticks'
union select 'oz'
union select 'pinch'
union select 'bag'
union select 'can'

;
with x as(
   select UserName = 'Adina''sAromas', CuisineName = 'American', RecipeName = 'Chocolate Chip Cookies', Calories = 300, DateDrafted = '05/03/2013 10:00', DatePublished = '07/03/2013 10:00', DateArchived = '01/01/2018 10:00'
   union select 'Caroline''sCreations', 'French', 'Apple Yogurt Smoothie', 150, '02/09/2019 11:30', '04/09/2019 11:30', null
   union select 'Debby''sDelights', 'English', 'Cheese Bread', 280, '01/01/2020 13:00', '02/28/2020 13:00', null
   union select 'Esty''sEdibles', 'American', 'Butter Muffins', 250, '07/17/2017 14:30', '09/01/2017 14:30', null
   union select 'Fay''sFlavors', 'Greek', 'Greek Salad', 180, '01/01/2022 16:00', '03/01/2022 16:00', null
   union select 'Adina''sAromas', 'Japanese', 'Rice', 350, '04/01/2018 17:30', '05/01/2018 17:30', null
   union select 'Caroline''sCreations', 'American', 'Slurpee', 200, '05/03/2015 19:00', '07/03/2015 19:00', '01/01/2020 19:00'
   union select 'Caroline''sCreations', 'English', 'Chicken Soup', 50, '05/20/2021 20:30', null, '05/20/2022 20:30'
   union select 'Esty''sEdibles', 'French', 'French Fries', 200, '01/10/2023 14:00', null, null
   union select 'Fay''sFlavors', 'French', 'French Toast', 150, '02/28/2023 14:30', null, null

)
Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select s.StaffId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x 
join Staff s 
on x.UserName = s.Username
join Cuisine c 
on x.CuisineName = c.CuisineName

;
with x as(
   select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'sugar', MeasurementName = 'cup', IngredientNum = 1, IngredientAmount = 1
   union select 'Chocolate Chip Cookies', 'oil', 'cup', 2, .5 
   union select 'Chocolate Chip Cookies', 'eggs', null, 3, 3
   union select 'Chocolate Chip Cookies', 'flour', 'cup', 4, 2
   union select 'Chocolate Chip Cookies', 'vanilla sugar', 'tsp', 5, 1
   union select 'Chocolate Chip Cookies', 'baking powder', 'tsp', 6, 2 
   union select 'Chocolate Chip Cookies', 'baking soda', 'tsp', 7, .5
   union select 'Chocolate Chip Cookies', 'chocolate chips', 'cup', 8, 1
   union select 'Apple Yogurt Smoothie', 'granny smith apples', null, 1, 3
   union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cup', 2, 2
   union select 'Apple Yogurt Smoothie', 'sugar', 'tsp', 3, 2
   union select 'Apple Yogurt Smoothie', 'orange juice', 'cup', 4, .5
   union select 'Apple Yogurt Smoothie', 'honey', 'tbsp', 5, 2
   union select 'Apple Yogurt Smoothie', 'ice cubes', null, 6, 6
   union select 'Cheese Bread', 'club bread', null, 1, 1
   union select 'Cheese Bread', 'butter', 'oz', 2, 4
   union select 'Cheese Bread', 'shredded cheese', 'oz', 3, 8
   union select 'Cheese Bread', 'crushed garlic', 'cloves', 4, 2
   union select 'Cheese Bread', 'black pepper', 'tsp', 5, .25
   union select 'Cheese Bread', 'salt', 'pinch', 6, 1
   union select 'Butter Muffins', 'butter', 'stick', 1, 1
   union select 'Butter Muffins', 'sugar', 'cup', 2, 3
   union select 'Butter Muffins', 'vanilla pudding', 'tbsp', 3, 2
   union select 'Butter Muffins', 'eggs', null, 4, 4
   union select 'Butter Muffins', 'whipped cream cheese', 'oz', 5, 8
   union select 'Butter Muffins', 'sour cream cheese', 'oz', 6, 8
   union select 'Butter Muffins', 'flour ', 'cup', 7, 1
   union select 'Butter Muffins', 'baking powder', 'tsp', 8, 2
   union select 'Greek Salad', 'lettuce', 'oz', 1, 8
   union select 'Greek Salad', 'cubed feta cheese', 'oz', 2, 2
   union select 'Greek Salad', 'black olives', 'oz', 3, 2
   union select 'Greek Salad', 'cucumber', null, 4, 1
   union select 'Greek Salad', 'tomato', null, 5, 1
   union select 'Greek Salad', 'olive oil', 'cup', 6, .25
   union select 'Greek Salad', 'balsamic vinegar', 'tbsp', 7, 1
   union select 'Greek Salad', 'salt', 'tsp', 8, 1
   union select 'Greek Salad', 'black pepper', 'tsp', 9, .5
   union select 'Greek Salad', 'crushed garlic', 'cloves', 10, 2
   union select 'Rice', 'white rice', 'oz', 1, 8
   union select 'Rice', 'water', 'cup', 2, 2
   union select 'Rice', 'salt', 'tsp', 3, 2
   union select 'Rice', 'onions', null, 4, 2
   union select 'Rice', 'oil', 'tsp', 5, 2
   union select 'Slurpee', 'coke', 'can', 1, 1
   union select 'Slurpee', 'ice cubes', null, 2, 6
   union select 'Chicken Soup', 'chicken bones', 'bag', 1, 1
   union select 'Chicken Soup', 'carrots', null, 2, 7
   union select 'Chicken Soup', 'parsnip', null, 3, 2
   union select 'Chicken Soup', 'zucchini', null, 4, 3
   union select 'Chicken Soup', 'onions', null, 5, 3
   union select 'Chicken Soup', 'salt', 'tbsp', 6, 4
   union select 'Chicken Soup', 'garlic', 'cloves', 7, 2
   union select 'Chicken Soup', 'water', 'cup', 8, 20
   union select 'French Fries', 'potato', null, 1, 1
   union select 'French Fries', 'oil', 'tbsp', 2, 1
   union select 'French Fries', 'salt', 'tsp', 3, 1
   union select 'French Fries', 'vinegar', 'tsp', 4, 1
)
Insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, IngredientNum, IngredientAmount)
select r.RecipeId, i.IngredientId, m.MeasurementId, x.IngredientNum, x.IngredientAmount
from x 
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i 
on x.IngredientName = i.IngredientName
left join Measurement m 
on x.MeasurementName = m.MeasurementName

;
with x as(
   select RecipeName = 'Chocolate Chip Cookies', StepNum = 1, Instructions = 'First combine sugar, oil and eggs in a bowl'
   union select 'Chocolate Chip Cookies', 2, 'mix well'
   union select 'Chocolate Chip Cookies', 3, 'add flour, vanilla sugar, baking powder and baking soda'
   union select 'Chocolate Chip Cookies', 4, 'beat for 5 minutes'
   union select 'Chocolate Chip Cookies', 5, 'add chocolate chips'
   union select 'Chocolate Chip Cookies', 6, 'freeze for 1-2 hours'
   union select 'Chocolate Chip Cookies', 7, 'roll into balls and place spread out on a cookie sheet'
   union select 'Chocolate Chip Cookies', 8, 'bake on 350 for 10 min'
   union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
   union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
   union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
   union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
   union select 'Apple Yogurt Smoothie', 5, 'pour into glasses'
   union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
   union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
   union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
   union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes'
   union select 'Butter Muffins', 1, 'Cream butter with sugars'
   union select 'Butter Muffins', 2, 'Add eggs and mix well'
   union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
   union select 'Butter Muffins', 4, 'fill muffin pans 3/4 full and bake for 30 minutes'
   union select 'Greek Salad', 1, 'Slice the olives, and dice the cucumber and tomato'
   union select 'Greek Salad', 2, 'layer the lettuce, olives, cucumber, and tomato in a large bowl'
   union select 'Greek Salad', 3, 'sprinkle feta cheese over the top layer'
   union select 'Greek Salad', 4, 'for the dressing, combine the olive oil, vinegar, salt, pepper, and garlic in a small bowl'
   union select 'Greek Salad', 5, 'whisk'
   union select 'Greek Salad', 6, 'pour the dressing over the salad before serving'
   union select 'Rice', 1, 'Peel and dice the onions'
   union select 'Rice', 2, 'sautee the onions in the oil'
   union select 'Rice', 3, 'sift and rinse the rice'
   union select 'Rice', 4, 'pour into a pan'
   union select 'Rice', 5, 'add the water, salt, and sauteed onion'
   union select 'Rice', 6, 'mix'
   union select 'Rice', 7, 'bake covered on 375 for 1 hour'
   union select 'Slurpee', 1, 'Put the ice cubes in a blender cup'
   union select 'Slurpee', 2, 'Add the coke'
   union select 'Slurpee', 3, 'Blend'
   union select 'Slurpee', 4, 'Pour into a cup'
   union select 'Slurpee', 5, 'Put in a wide straw and enjoy'
)
Insert Instructions(RecipeId, StepNum, Instructions)
select r.RecipeId, x.StepNum, x.Instructions 
from x 
join Recipe r 
on x.RecipeName = r.RecipeName

Insert Course(CourseName, CourseNum)
select 'Appetizer', 1
union select 'Soup', 2
union select 'Main Course', 3
union select 'Dessert', 4

;
with x as(
   select Username = 'Debby''sDelights', MealName = 'Breakfast Bash', MealActive = 1, DateCreated = '05/01/2020'
   union select 'Adina''sAromas', 'Savory Supper', 1, '05/20/2023'
   union select 'Caroline''sCreations', 'Sweet Snack', 0, '12/01/2015'
   union select 'Debby''sDelights', 'Luscious Lunch', 1, '07/01/2022'
   union select 'Esty''sEdibles', 'Grab N Go', 1, '12/01/2019'
)
Insert Meal(StaffId, MealName, MealActive, DateCreated)
select s.StaffId, x.MealName, x.MealActive, x.DateCreated
from x 
join Staff s 
on x.Username = s.UserName

;
with x as(
   select MealName = 'Breakfast Bash', CourseName = 'Appetizer'
   union select 'Breakfast Bash', 'Main Course'
   union select 'Savory Supper', 'Appetizer'
   union select 'Savory Supper', 'Main Course'
   union select 'Savory Supper', 'Dessert'
   union select 'Sweet Snack', 'Main Course'
   union select 'Luscious Lunch', 'Appetizer'
   union select 'Luscious Lunch', 'Main Course'
   union select 'Grab N Go', 'Appetizer'
   union select 'Grab N Go', 'Main Course'
) 
Insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId 
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName

;
with x as(
   select MealName = 'Breakfast Bash', CourseName = 'Appetizer', RecipeName = 'Apple Yogurt Smoothie', IsMain = 0 
   union select 'Breakfast Bash', 'Main Course', 'Cheese Bread', 1
   union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 0
   union select 'Savory Supper', 'Appetizer', 'Apple Yogurt Smoothie', 0
   union select 'Savory Supper', 'Main Course', 'Greek Salad', 1
   union select 'Savory Supper', 'Main Course', 'Rice', 0
   union select 'Savory Supper', 'Dessert', 'Butter Muffins', 0
   union select 'Sweet Snack', 'Main Course', 'Chocolate Chip Cookies', 1
   union select 'Sweet Snack', 'Main Course', 'Slurpee', 0
   union select 'Luscious Lunch', 'Appetizer', 'Greek Salad', 0
   union select 'Luscious Lunch', 'Main Course', 'Cheese Bread', 1 
   union select 'Grab N Go', 'Appetizer', 'Apple Yogurt Smoothie', 0
   union select 'Grab N Go', 'Main Course', 'Butter Muffins', 1   
)
Insert MealCourseRecipe(MealCourseId, RecipeId, IsMain)
select mc.MealCourseId, r.RecipeId, x.IsMain
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
join Meal m 
on x.MealName = m.MealName 
join Course c 
on x.CourseName = c.CourseName 
join MealCourse mc 
on m.MealId = mc.MealId
and c.CourseId = mc.CourseId

;
with x as(
   select UserName = 'Caroline''sCreations', CookbookName = 'Treats for Two', Price = 30, CookBookActive = 0, DateCreated = '07/01/2019'
   union select 'Debby''sDelights', 'Wholesome', 36, 1, '01/21/2021'
   union select 'Fay''sFlavors', 'Dairy Delights', 32, 1, '10/04/2022'
   union select 'Esty''sEdibles', 'Sumptious Snacks', 30, 1, '06/11/2022'
   union select 'Fay''sFlavors', 'Happy and Healthy', 28, 1, '01/23/2023'
)
Insert Cookbook(StaffId, CookbookName, Price, CookbookActive, DateCreated)
select s.StaffId, x.CookbookName, x.Price, x.CookbookActive, x.DateCreated
from x 
join Staff s 
on x.UserName = s.UserName

;
with x as(
   select CookbookName = 'Treats for Two', RecipeName = 'Apple Yogurt Smoothie', RecipeNum = 1
   union select 'Treats for Two', 'Butter Muffins', 2
   union select 'Treats for Two', 'Chocolate Chip Cookies', 3 
   union select 'Treats for Two', 'Slurpee', 4
   union select 'Wholesome', 'Butter Muffins', 1
   union select 'Wholesome', 'Cheese Bread', 2
   union select 'Wholesome', 'Rice', 3 
   union select 'Dairy Delights', 'Apple Yogurt Smoothie', 1
   union select 'Dairy Delights', 'Cheese Bread', 2
   union select 'Dairy Delights', 'Greek Salad', 3
   union select 'Sumptious Snacks', 'Apple Yogurt Smoothie', 1 
   union select 'Sumptious Snacks', 'Butter Muffins', 2
   union select 'Sumptious Snacks', 'Greek Salad', 3 
   union select 'Happy and Healthy', 'Apple Yogurt Smoothie', 1
   union select 'Happy and Healthy', 'Greek Salad', 2
   union select 'Happy and Healthy', 'Rice', 3 
)
Insert CookbookRecipe(CookbookId, RecipeId, RecipeNum)
select c.CookbookId, r.RecipeId, x.RecipeNum 
from x 
join Cookbook c 
on x.CookbookName = c.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName
