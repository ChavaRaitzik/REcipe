-- SM Excellent! See comments.
use HeartyHearthDB
go 
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
--Home Page
select ItemName = 'Recipes', Count = count(r.RecipeId)
from Recipe r 
union select 'Meals', count(m.MealId)
from Meal m 
union select 'Cookbooks', count(c.CookbookId)
from Cookbook c 
order by ItemName desc 

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
--Recipe List Page
Select RecipeName = (case r.RecipeStatus 
                                when 'Archived' then concat('<span style ="color:gray">', r.RecipeName, '</span>')
                                else r.RecipeName
                            end), 
r.RecipeStatus, DatePublished = isnull(convert(varchar, r.DatePublished, 101),''), DateArchived = isnull(convert(varchar, r.DateArchived, 101), ''), s.UserName, r.Calories, NumOfIngredients = count(distinct ri.IngredientId), r.RecipePic
from Recipe r 
join Staff s 
on r.StaffId = s.StaffId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.RecipeStatus in ('Published','Archived')
group by r.RecipeName, r.RecipeStatus, r.DatePublished, r.DateArchived, s.UserName, r.Calories, r.RecipePic
order by r.RecipeStatus desc 

/*
Recipe details page:
    Show for a specific recipe (three result sets):count(distinct ri.IngredientId)
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--Recipe Details Page
--a) Recipe Header
select r.RecipeName, NumOfCalories = r.Calories, NumOfIngredients = count(distinct ri.IngredientId), NumOfSteps = count(distinct i.InstructionsId), r.RecipePic
from Recipe r  
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Instructions i 
on r.RecipeId = i.RecipeId
where r.RecipeName = 'slurpee'
group by r.RecipeName, r.Calories, r.RecipePic

--b) List of Ingredients
select Ingredients = concat(ri.IngredientAmount, ' ', m.MeasurementName, ' ', i.IngredientName), i.IngredientPic
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Measurement m 
on ri.MeasurementId = m.MeasurementId
join Ingredient i 
on ri.IngredientId = i.IngredientId
where r.RecipeName = 'slurpee'
order by ri.IngredientNum

--c) List of Prep Steps
select PrepSteps = i.Instructions
from Recipe r 
join Instructions i 
on r.RecipeId = i.RecipeId
where r.RecipeName = 'Slurpee'
order by i.StepNum

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
--Meal List Page
Select m.MealName, s.UserName, NumOfCalories = sum(r.Calories), NumOfCourse = count(distinct mc.CourseId), NumOfRecipes = count(distinct mcr.RecipeId), m.MealPic
from Recipe r 
join MealCourseRecipe mcr 
on r.RecipeId = mcr.RecipeId
join MealCourse mc 
on mcr.MealCourseId = mc.MealCourseId
join Meal m 
on mc.MealId = m.MealId
join Staff s 
on m.StaffId = s.StaffId 
where m.MealActive = 1 
group by m.MealName, m.MealActive, m.MealPic, s.Username
order by m.MealName 

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--Meal Details Page
--a) Meal Header
select m.MealName, s.UserName, DateCreated = convert(varchar, m.DateCreated, 101), m.MealPic
from Meal m 
join Staff s 
on m.StaffId = s.StaffId
where m.MealName = 'Savory Supper'

--b) List of Recipes 
select Recipes = concat(case when c.CourseName = 'Main Course' and mcr.IsMain = 1 then '<b>' else '' end,
                        c.CourseName, 
                        ': ', 
                        case when c.CourseName = 'Main Course' and mcr.IsMain = 1 then 'Main Dish - ' when c.CourseName = 'Main Course' and mcr.IsMain = 0 then 'Side Dish - ' else '' end,
                        r.RecipeName, 
                        case when c.CourseName = 'Main Course' and mcr.IsMain = 1 then '<b>' else '' end),
r.RecipePic
from Meal m 
join MealCourse mc
on m.MealId = mc.MealId
join Course c 
on mc.CourseId = c.CourseId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r 
on mcr.RecipeId = r.RecipeId
where m.MealName = 'Savory Supper'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
--Cookbook List Page
select b.CookbookName, Author = concat(s.FirstName, ' ', s.LastName), NumOfRecipes = count(br.CookbookRecipeId), b.CookbookPic
from Cookbook b 
join Staff s 
on b.StaffId = s.StaffId
join CookbookRecipe br 
on b.CookbookId = br.CookbookId
where b.CookbookActive = 1
group by b.CookbookName, b.CookbookActive, b.CookbookPic, s.FirstName, s.LastName
order by b.CookbookName 

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--Cookbook Details Page
--a) Cookbook Header
select b.CookbookName, s.UserName, DateCreated = convert(varchar, b.DateCreated, 101), b.Price, NumOfRecipes = count(br.CookbookRecipeId), b.CookbookPic
from Cookbook b 
join Staff s 
on b.StaffId = s.StaffId
join CookbookRecipe br 
on b.CookbookId = br.CookbookId
where b.CookbookName = 'Dairy Delights'
group by b.CookbookName, b.DateCreated, b.Price, b.CookbookPic, s.UserName

--b) List of Recipes
select r.RecipeName, u.CuisineName, NumOfIngredients = count(distinct ri.IngredientId), NumOfSteps = count(distinct i.InstructionsId), r.RecipePic
from Cookbook b  
join CookbookRecipe br 
on b.CookbookId = br.CookbookId
join Recipe r 
on br.RecipeId = r.RecipeId
join Cuisine u 
on r.CuisineId = u.CuisineId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Ingredient d
on ri.IngredientId = d.IngredientId
join Instructions i 
on r.RecipeId = i.RecipeId
where CookbookName = 'Dairy Delights'
group by r.RecipeName, r.RecipePic, br.RecipeNum, b.CookbookName, u.CuisineName
order by br.RecipeNum

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--April Fools Page
--a) List of Recipes
select distinct Recipes = concat(upper(substring(reverse(r.RecipeName),1,1)), lower(substring(reverse(r.RecipeName),2, len(r.RecipeName)))), 
RecipePic = concat('Recipe','-',replace(concat(upper(substring(reverse(r.RecipeName),1,1)), lower(substring(reverse(r.RecipeName),2, len(r.RecipeName)))),' ','-'),'.jpg')
from CookbookRecipe cr 
join Recipe r 
on cr.RecipeId = r.RecipeId

--b) List of Steps
;
with x as(
    select i.RecipeId, StepNum = max(i.StepNum)
    from Instructions i 
    group by i.RecipeId
)
select i.Instructions 
from x 
join Instructions i 
on x.RecipeId = i.RecipeId
and x.StepNum = i.StepNum

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--Site Administration Page
--a)
select s.UserName, RecipeStatus = isnull(r.RecipeStatus, ''), NumOfRecipes = count(r.RecipeName) 
from Staff s 
left join Recipe r  
on s.StaffId = r.StaffId 
group by s.Username, r.RecipeStatus
order by s.Username, r.RecipeStatus

--b)
;
select s.UserName, NumOfRecipes = count(r.RecipeName), AvgDaysToPublish = Avg(DateDiff(day, r.DateDrafted, r.DatePublished))
from  Staff s 
join Recipe r  
on s.StaffId = r.StaffId 
group by s.Username
order by s.Username, NumOfRecipes

--c) 
select s.UserName, 
TotalMeals = count(m.MealId), 
TotalActiveMeals = sum(case m.MealActive
                            when 1 then 1
                            else 0
                        end),
TotalInactiveMeals = sum(case m.MealActive
                            when 0 then 1
                            else 0
                        end)
from Staff s 
left join Meal m 
on s.StaffId = m.StaffId
group by s.UserName 
order by s.Username

--d)
select s.UserName, 
TotalCookbooks = count(b.CookbookId),
TotalActiveCookbooks = sum(case b.CookbookActive
                                when 1 then 1 
                                else 0
                            end),
TotalInactiveCookbooks = sum(case b.CookbookActive
                                when 0 then 1 
                                else 0
                            end)
from Staff s 
left join Cookbook b 
on s.StaffId = b.StaffId
group by s.UserName 
order by s.Username

--e) 
select r.RecipeName, DaysToArchive = DateDiff(day, DateDrafted, DateArchived)
from Recipe r 
where r.RecipeStatus = 'Archived'
and r.DatePublished is null

/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: For the number of recipes, use count of records that have a staffid or CTE.
*/
--User Dashboard Page
--a)
;
with x as(
    select s.StaffId
    from Staff s 
    where s.UserName = 'Debby''sDelights'
)
select ItemName = 'Recipes', Total = count(r.RecipeID)
from Recipe r 
join x 
on r.StaffId = x.StaffId
union select 'Meals', count(m.MealID)
from Meal m 
join x 
on m.StaffId = x.StaffId
union select 'Cookbooks', count(b.CookbookId)
from Cookbook b 
join Staff s 
on b.StaffId = s.StaffId
join x 
on b.StaffId = x.StaffId

--b)
select r.RecipeName, r.RecipeStatus, 
HoursAtStatus = datediff(hour,
                case when r.RecipeStatus = 'Archived' and r.DatePublished is not null then r.DatePublished else r.DateDrafted end,
                case when r.RecipeStatus = 'Archived' and r.DatePublished is not null then r.DateArchived else isnull(r.DatePublished, r.DateArchived) end)
from Recipe r 
join Staff s 
on r.StaffId = s.StaffId
where s.UserName = 'Debby''sDelights'
and r.RecipeStatus in ('Published','Archived')

--OPTIONAL CHALLENGE QUESTION
--c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
-- Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
;
with x as(
    select c.CuisineName, NumOfRecipes = count(r.RecipeId)
    from Cuisine c 
    join Recipe r 
    on c.CuisineId = r.CuisineId
    join Staff s 
    on s.StaffId = r.StaffId
    where s.UserName = 'Debby''sDelights'
    group by c.CuisineName
)
select c.CuisineName, NumOfRecipes = isnull(x.NumOfRecipes, '')
from Cuisine c 
left join x 
on x.CuisineName = c.CuisineName