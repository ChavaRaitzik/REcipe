create or alter proc dbo.RecipeChangeStatus(
	@recipeid int = 0,
	@DateDrafted datetime = '' output,
	@DatePublished datetime = '' output,
	@DateArchived datetime = '' output,
	@NewStatus varchar(9) = '',
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @RecipeId = isnull(@RecipeId, 0), @DateDrafted = DateDrafted, @DatePublished = DatePublished, @DateArchived = DateArchived from Recipe where RecipeId = @RecipeId

	if @NewStatus = 'Drafted'
	begin
		select @DatePublished = null, @DateArchived = null
		Update Recipe
		set
			DateDrafted = @DateDrafted,
			DatePublished = @DatePublished,
			DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end
	if @NewStatus = 'Published'
	begin
		select @DatePublished = isnull(@DatePublished, GetDate()), @DateArchived = null
		Update Recipe
		set
			DateDrafted = @DateDrafted,
			DatePublished = @DatePublished,
			DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end
	if @NewStatus = 'Archived'
	begin
		select @DateArchived = GetDate() 
		Update Recipe
		set
			DateDrafted = @DateDrafted,
			DatePublished = DatePublished,
			DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end


	return @return
end

/*
exec RecipeChangeStatus
@recipeid = 10,
@newstatus = 'Published'
*/