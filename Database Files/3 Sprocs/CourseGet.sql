create or alter procedure dbo.CourseGet(
	@CourseId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @CourseId = isnull(@CourseId, 0)

	select u.CourseId, u.CourseName, u.CourseNum
	from Course u
	where u.CourseId = @CourseId
	or @All = 1
	union select 0, ' ', 0
	where @IncludeBlank = 1
	order by u.CourseName

	return @return
end
go