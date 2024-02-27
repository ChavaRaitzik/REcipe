--Session 29 Homework:

/*
1) Server Name: craitzik.database.windows.net
   Database Name: HeartyHearthDB

2) SQL Login: dev_login  
       Password: HAPpy123***
create user dev_user2 from login dev_login
alter role db_datareader add member dev_user2
alter role db_datawriter add member dev_user2

3) AD user credentials: sqldev@chavafeldergmail.onmicrosoft.com
           password: Dev123***
4) Data for a recipe:
*/

Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select s.StaffId, u.CuisineId, 'Peppermint Tea', 30, '06/10/2023 14:30', null, null
from Staff s 
cross join Cuisine u
where s.UserName = 'Esty''sEdibles' 
and u.CuisineName = 'English'

Insert Ingredient(IngredientName)
select 'peppermint tea bag'
union select 'hot water'

;
with x as(
   select RecipeName = 'Peppermint tea', IngredientName = 'hot water', MeasurementName = 'cup', IngredientNum = 1, IngredientAmount = 1
   union select 'Peppermint tea', 'peppermint tea bag', null, 2, 1
   union select 'Peppermint tea', 'honey', 'tsp', 3, 2

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