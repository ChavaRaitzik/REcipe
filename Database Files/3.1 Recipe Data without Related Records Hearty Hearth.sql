use HeartyHearthDB
go 

;
with x as(
    select Username = 'Adina''sAromas', CuisineName = 'American', RecipeName = 'Apple Cider', Calories = 20, DateDrafted = '01/01/2001 11:00', DatePublished = '02/02/2002 11:00', DateArchived = '05/05/2005 11:00'
    union select 'Caroline''sCreations', 'Chinese', 'Fortune Cookies', 75, '12/12/2012 12:00', '12/13/2013 12:00',  '01/21/2021 12:00'
    union select 'Esty''sEdibles', 'English', 'Egg Rolls', 200, '02/13/2023 13:00', '01/04/2024 13:00', null
    union select 'Fay''sFlavors', 'French', 'French Dressing', 100, '01/04/2024 14:00', null, null
)
Insert Recipe(StaffId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select s.StaffId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x 
join Staff s 
on x.Username = s.Username
join Cuisine c 
on x.CuisineName = c.CuisineName