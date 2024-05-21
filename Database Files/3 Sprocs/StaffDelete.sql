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
		from Staff s 
		join Recipe r 
		on s.StaffId = r.StaffId
		join Instructions i
		on r.RecipeId = i.RecipeId
		where s.StaffId = @StaffId
		
		delete ri 
		from Staff s 
		join Recipe r 
		on s.StaffId = r.StaffId 
		join RecipeIngredient ri 
		on r.RecipeId = ri.RecipeId
		where s.StaffId = @StaffId
		
		delete mcr 
		from Staff s 
		join Recipe r 
		on s.StaffId = r.StaffId
		join MealCourseRecipe mcr 
		on r.RecipeId = mcr.RecipeId
		where s.StaffId = @StaffId
		
		delete mcr
		from Staff s 
		join Meal m 
		on s.StaffId = m.StaffId
		join MealCourse mc 
		on m.MealId = mc.MealId 
		join MealCourseRecipe mcr 
		on mc.MealCourseId = mcr.MealCourseId
		where s.StaffId = @StaffId

		delete mc
		from Staff s 
		join Meal m 
		on s.StaffId = m.StaffId
		join MealCourse mc 
		on m.MealId = mc.MealId 
		where s.StaffId = @StaffId

		delete br
		from Staff s 
		join Recipe r 
		on s.StaffId = r.StaffId
		join CookbookRecipe br
		on r.RecipeId = br.RecipeId
		where s.StaffId = @StaffId
		
		delete br
		from Staff s 
		join Cookbook b
		on s.StaffId = b.StaffId
		join CookbookRecipe br 
		on b.CookbookId = br.CookbookId
		where s.StaffId = @StaffId
		
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