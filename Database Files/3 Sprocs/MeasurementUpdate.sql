create or alter proc dbo.MeasurementUpdate(
	@MeasurementId int = 0 output,
	@MeasurementName varchar(20) = ' ',
	@message varchar(500) = '' output
)
as
begin 
	declare @return int = 0
	select @MeasurementId = ISNULL(@MeasurementId, 0)

	if @MeasurementId = 0
	begin
		insert Measurement(MeasurementName)
		values(@MeasurementName)
		select @MeasurementId = SCOPE_IDENTITY()
	end
	else 
	begin
		update Measurement 
		set 
			MeasurementName = @MeasurementName
		where MeasurementId = @MeasurementId
	end
	return @return
end