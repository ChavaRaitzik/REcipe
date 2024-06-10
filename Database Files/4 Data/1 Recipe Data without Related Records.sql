use HeartyHearthDB
go

;
with x as(
   select UserName = 'Adina''sAromas', CuisineName = 'American', RecipeName = 'Apple Cider', Calories = 20, DateDrafted = '01/01/2011 11:00', DatePublished = '02/01/2011 11:00', DateArchived = '03/01/2016 11:00'
   union select 'Caroline''sCreations', 'Chinese', 'Fortune Cookies', 75, '02/02/2012 12:00', '03/03/2013 12:00', '04/04/2020'
   union select 'Esty''sEdibles', 'English', 'Egg Rolls', 250, '03/03/2013 13:00', '04/04/2014 13:00', null
   union select 'Fay''sFlavors', 'French', 'French Dressing', 40, '01/01/2024 14:00', null, null
)
Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select s.StaffId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x 
join Staff s 
on x.UserName = s.Username
join Cuisine c 
on x.CuisineName = c.CuisineName