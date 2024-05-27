create or alter proc dbo.MeasurementDelete(
	@MeasurementId int = 0 output,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @MeasurementId = ISNULL(@MeasurementId, 0)

	begin try
	begin tran
--LB: It should be enough to delete the RecipeIngredient records in order to be able to delete Measurement record. Please remove all unnecessary statements. 

		delete br
		from Measurement m
		join RecipeIngredient ri
		on m.MeasurementId = ri.MeasurementId
		join CookbookRecipe br
		on ri.RecipeId = br.RecipeId
		where m.MeasurementId = @MeasurementId

		delete mcr
		from Measurement m
		join RecipeIngredient ri
		on m.MeasurementId = ri.MeasurementId
		join MealCourseRecipe mcr 
		on ri.RecipeId = mcr.RecipeId
		where m.MeasurementId = @MeasurementId

		delete n
		from Measurement m
		join RecipeIngredient ri
		on m.MeasurementId = ri.MeasurementId
		join Instructions n 
		on ri.RecipeId = n.RecipeId
		where m.MeasurementId = @MeasurementId

		delete RecipeIngredient where MeasurementId = @MeasurementId

		delete r
		from Measurement m
		join RecipeIngredient ri
		on m.MeasurementId = ri.MeasurementId
		join Recipe r 
		on ri.RecipeId = r.RecipeId
		where m.MeasurementId = @MeasurementId

		delete Measurement where MeasurementId = @MeasurementId
		commit
	end try
	begin catch
		throw
		rollback
	end catch

	return @return
end