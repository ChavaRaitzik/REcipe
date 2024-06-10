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