create or alter procedure dbo.InstructionsGet(
	@InstructionsId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @InstructionsId = isnull(@InstructionsId, 0)

	select n.InstructionsId, n.Instructions
	from Instructions n
	where @InstructionsId = n.InstructionsId
	or @All = 1
	union select 0, ' '
	where @IncludeBlank = 1
	order by n.Instructions

	return @return
end
go

exec InstructionsGet @all = 1