create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int = 0 output,
	@RecipeId int = 0,
	@IngredientId int = 0,
	@MeasurementId int = 0,
	@Quantity decimal(4,2) = 0,
	@IngredientNum int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@RecipeId,0), @IngredientId = isnull(@IngredientId,0), @MeasurementId = isnull(@MeasurementId,0), @Quantity = isnull(@Quantity,0), @IngredientNum = isnull(@IngredientNum,0)

	If @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, Quantity, IngredientNum)
		values(@RecipeId,@IngredientId,@MeasurementId,@Quantity,@IngredientNum)
		select @RecipeIngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeIngredient
		set 
			RecipeId = @RecipeId,
			IngredientId = @IngredientId,
			MeasurementId = @MeasurementId,
			Quantity = @Quantity,
			IngredientNum = @IngredientNum
		where RecipeIngredientId = @RecipeIngredientId
	end

	return @return
end
go