create or alter proc dbo.CourseUpdate(
	@CourseId int = 0 output,
	@CourseName varchar(25) = ' ',
	@CourseNum int = 0,
	@Message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId, 0), @CourseNum = isnull(@CourseNum, 0)

	if @CourseId = 0
	begin
		insert Course(CourseName, CourseNum)
		values(@CourseName, @CourseNum)
		select @CourseId = SCOPE_IDENTITY()
	end
	else 
	begin 
		update Course
		set
			CourseName = @CourseName,
			CourseNum = @CourseNum
		where CourseId = @CourseId
	end

	return @return
end