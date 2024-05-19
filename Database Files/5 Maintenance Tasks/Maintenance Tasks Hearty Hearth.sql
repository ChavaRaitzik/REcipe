-- SM Excellent! See comments, no need to resubmit.
use HeartyHearthDB 
go 

--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete i
--select * 
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
join Instructions i
on r.RecipeId = i.RecipeId
where s.Username = 'Esty''sEdibles'

delete ri 
--select * 
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where s.Username = 'Esty''sEdibles'

delete mcr 
--select * 
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
join MealCourseRecipe mcr 
on r.RecipeId = mcr.RecipeId
where s.Username = 'Esty''sEdibles'

delete mcr
--select * 
from Staff s 
join Meal m 
on s.StaffId = m.StaffId
join MealCourse mc 
on m.MealId = mc.MealId 
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
where s.Username = 'Esty''sEdibles'

delete mc
--select * 
from Staff s 
join Meal m 
on s.StaffId = m.StaffId
join MealCourse mc 
on m.MealId = mc.MealId 
where s.Username = 'Esty''sEdibles'

delete br
--select * 
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
join CookbookRecipe br
on r.RecipeId = br.RecipeId
where s.Username = 'Esty''sEdibles'

delete br
--select * 
from Staff s 
join Cookbook b
on s.StaffId = b.StaffId
join CookbookRecipe br 
on b.CookbookId = br.CookbookId
where s.Username = 'Esty''sEdibles'


delete r 
--select * 
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
where s.Username = 'Esty''sEdibles'

delete m 
--select * 
from Staff s 
join Meal m 
on s.StaffId = m.StaffId
where s.Username = 'Esty''sEdibles'

delete b
--select *
from Staff s 
join Cookbook b
on s.StaffId = b.StaffId
where s.Username = 'Esty''sEdibles'

delete s 
--select *
from Staff s 
where s.UserName = 'Esty''sEdibles'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select r.StaffId, r.CuisineId, concat(r.RecipeName, ' - Clone'), r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
from Recipe r 
where r.RecipeName = 'Greek Salad'

Insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, IngredientNum, Quantity)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Greek Salad - Clone'), ri.IngredientId, ri.MeasurementId, ri.IngredientNum, ri.Quantity
from RecipeIngredient ri  
join Recipe r 
on ri.RecipeId = r.RecipeId
where r.RecipeName = 'Greek Salad'

Insert Instructions(RecipeId, StepNum, Instructions)
select (select r.RecipeId from Recipe r where r.RecipeName = 'Greek Salad - Clone'), i.StepNum, i.Instructions 
from Instructions i  
join Recipe r 
on i.RecipeId = r.RecipeId
where r.RecipeName = 'Greek Salad'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;
with x as(
    select r.StaffId, s.Username, Price = count(r.RecipeId) * 1.33
    from recipe r 
    join Staff s 
    on r.StaffId = s.StaffId  
    where s.Username = 'Adina''sAromas'
    group by r.StaffId, s.Username
)
Insert Cookbook(StaffId, CookbookName, Price, CookbookActive, DateCreated)
select x.StaffId, 'Recipes by Adina Adler', x.Price, 1, getdate()
from x

Insert CookbookRecipe(CookbookId, RecipeId, RecipeNum)
select b.CookbookId, r.RecipeId, Row_Number() over (order by r.RecipeName)
from Cookbook b
join Recipe r 
on b.StaffId = r.StaffId 
where b.CookbookName = 'Recipes by Adina Adler' 


/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
Update r 
--select r.RecipeName, r.Calories,
set Calories = case m.MeasurementName
				when 'cup' then r.Calories + (48*ri.Quantity)
				when 'tbsp' then r.Calories + (3*ri.Quantity)
				when 'tsp' then r.Calories + (1*ri.Quantity)
			end 
from Ingredient n 
join RecipeIngredient ri 
on n.IngredientId = ri.IngredientId 
join Recipe r 
on ri.RecipeId = r.RecipeId 
join Measurement m 
on ri.MeasurementId = m.MeasurementId
where n.IngredientName = 'sugar'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
	select AvgHoursToPublish = Avg(DateDiff(hour, r.DateDrafted, r.DatePublished))
	from Recipe r  
)
select s.FirstName, s.LastName, EmailAddress = concat(substring(s.FirstName,1,1),s.LastName,'@heartyhearth.com'), 
Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', DateDiff(hour, r.DateDrafted, getdate()), ' hours.', '
That is ', DateDiff(hour, r.DateDrafted, getdate()) - x.AvgHoursToPublish, ' hours more than the average ', x.AvgHoursToPublish, ' hours all other recipes took to be published.')
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
join x
on DateDiff(hour, r.DateDrafted, getdate()) > x.AvgHoursToPublish
where r.RecipeStatus = 'Drafted'


/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
;
with x as(
	select AvgPrice = avg(b.Price), NumOfCookbooks = count(b.CookbookId), TotalPrice = sum(b.Price)
	from Cookbook b 
	where b.CookbookActive = 1
)
Select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', x.NumOfCookbooks, ' books for sale, average price is ', convert(decimal(5,2), x.AvgPrice), '. You can order them all and receive a 25% discount, for a total of ', convert(decimal(6,2),x.TotalPrice * .75), '.
Click <a href = "www.heartyhearth.com/order/', newid(), '">here</a> to order.')
from x 