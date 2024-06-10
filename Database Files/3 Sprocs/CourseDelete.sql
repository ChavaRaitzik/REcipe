create or alter proc dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = ' ' output
)
as 
begin
	declare @return int = 0

	begin try
		begin tran
			delete mcr
			from Course c 
			join MealCourse mc
			on c.CourseId = mc.CourseId
			join MealCourseRecipe mcr
			on mc.MealCourseId = mcr.MealCourseId
			where c.CourseId = @CourseId

			delete MealCourse where CourseId = @CourseId

			delete Course where CourseId = @CourseId
		commit
	end try
	begin catch
		rollback;	
		throw 
	end catch
		
	return @return
end

--select * from meal