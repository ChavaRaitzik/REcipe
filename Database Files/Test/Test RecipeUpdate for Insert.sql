declare @Message varchar(500) = '', @return int, @recipeid int, @staffid int, @cuisineid int

select top 1 @staffid = StaffId from Staff
Select top 1 @cuisineid = CuisineId from Cuisine
