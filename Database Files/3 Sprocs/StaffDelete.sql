create or alter proc dbo.StaffDelete(
	@StaffId int = 0,
	@Message varchar(500) = '' output
)
as
begin 
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0)

	begin try
		begin tran
--LB: Formatting tip: code inside transaction should be indented.
--LB: All delete statements can be done without joining the staff table. Please modify all of them.
			delete i
			from  Recipe r 
			join Instructions i
			on r.RecipeId = i.RecipeId
			where r.StaffId = @StaffId
			
			delete ri 
			from Recipe r 
			join RecipeIngredient ri 
			on r.RecipeId = ri.RecipeId
			where r.StaffId = @StaffId
			
			delete mcr 
			from Recipe r 
			join MealCourseRecipe mcr 
			on r.RecipeId = mcr.RecipeId
			where r.StaffId = @StaffId
			
			delete mcr
			from Meal m 
			join MealCourse mc 
			on m.MealId = mc.MealId 
			join MealCourseRecipe mcr 
			on mc.MealCourseId = mcr.MealCourseId
			where m.StaffId = @StaffId

			delete mc
			from Meal m 
			join MealCourse mc 
			on m.MealId = mc.MealId 
			where m.StaffId = @StaffId

			delete br
			from Recipe r 
			join CookbookRecipe br
			on r.RecipeId = br.RecipeId
			where r.StaffId = @StaffId
			
			delete br
			from Cookbook b
			join CookbookRecipe br 
			on b.CookbookId = br.CookbookId
			where b.StaffId = @StaffId
			
			delete Recipe where StaffId = @StaffId
			
			delete Meal where StaffId = @StaffId
			
			delete Cookbook where StaffId = @StaffId
			
			delete Staff where StaffId = @StaffId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end