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
			delete RecipeIngredient where MeasurementId = @MeasurementId

			delete Measurement where MeasurementId = @MeasurementId
		commit
	end try
	begin catch
		throw
		rollback
	end catch

	return @return
end