-- SM Excellent! 100%
use HeartyHearthDB
go 


drop table if exists dbo.CookbookRecipe
drop table if exists dbo.Cookbook
drop table if exists dbo.MealCourseRecipe
drop table if exists dbo.MealCourse
drop table if exists dbo.Meal
drop table if exists dbo.Course
drop table if exists dbo.Instructions
drop table if exists dbo.RecipeIngredient
drop table if exists dbo.Recipe
drop table if exists dbo.Measurement
drop table if exists dbo.Ingredient
drop table if exists dbo.Cuisine
drop table if exists dbo.Staff 
go 

Create table dbo.Staff(  
    StaffId int not null identity primary key, 
    FirstName varchar(35) not null 
        constraint ck_Staff_FirstName_cannot_be_blank check(FirstName <> ''), 
    LastName varchar(35) not null 
        constraint ck_Staff_LastName_cannot_be_blank check(LastName <> ''), 
    Username varchar(35) not null 
        constraint ck_Staff_UserName_cannot_be_blank check(UserName <> '')
        constraint u_Staff_UserName unique
)

Create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineName varchar(30) not null 
        constraint ck_Cusine_CuisineName_cannot_be_blank check(CuisineName <> '')
        constraint u_Cuisine_CuisineName unique 
)

Create table dbo.Ingredient(
    IngredientId int not null identity primary key, 
    IngredientName varchar(30) not null 
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_IngredientName unique, 
    IngredientPic as concat('Ingredient','-',replace(IngredientName,' ','-'),'.jpg') persisted
)

Create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementName varchar(20) null
        constraint ck_Measurement_MeasurementName_cannot_be_blank check(MeasurementName <> '')
        constraint u_Measurement_MeasurementName unique(MeasurementName)
)

Create table dbo.Recipe(
    RecipeId int not null identity primary key, 
    StaffId int not null 
        constraint f_Staff_Recipe foreign key references Staff(StaffId), 
    CuisineId int not null 
        constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId), 
    RecipeName varchar(75) not null  
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_RecipeName unique(RecipeName),
    Calories int not null 
        constraint ck_Recipe_Calories_must_be_greater_than_0 check(Calories > 0),
    DateDrafted datetime not null
        constraint ck_Recipe_DateDrafted_must_be_before_or_on_current_date check(DateDrafted <= getdate()),
    DatePublished datetime null
        constraint ck_Recipe_DatePublished_must_be_before_or_on_current_date check(DatePublished <= getdate()), 
    DateArchived datetime null
                constraint ck_Recipe_DateArchived_must_be_before_or_on_current_date check(DateArchived <= getdate()), 
    RecipeStatus as case   
                        when DateArchived is null 
                        then case
                                when DatePublished is null 
                                then 'Drafted'
                                else 'Published'
                        end  
                            else 'Archived'
                        end persisted, 
    RecipePic as concat('Recipe','-',replace(RecipeName,' ','-'),'.jpg') persisted,  
    constraint ck_Recipe_DateDrafted_must_be_before_DateArchived check(DateDrafted < DateArchived),
    constraint ck_Recipe_DatePublished_must_be_between_DateDrafted_and_DateArchived check(DatePublished between DateDrafted and DateArchived)
)

Create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key, 
    RecipeId int not null   
        constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId), 
    IngredientId int not null 
        constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementId int null 
        constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementId),
    IngredientNum int not null 
        constraint ck_RecipeIngredient_IngredientNum_must_be_greater_than_0 check(IngredientNum > 0),
    Quantity decimal(4,2) not null
            constraint ck_RecipeIngredient_Quantity_must_be_greater_than_0 check(Quantity > 0)
    constraint u_RecipeId_IngredientId unique(RecipeId, IngredientId),
    constraint u_RecipeId_IngredientNum unique(RecipeId, IngredientNum)
)

Create table dbo.Instructions(
    InstructionsId int not null identity primary key, 
    RecipeId int not null   
        constraint f_Recipe_Instructions foreign key references Recipe(RecipeId), 
    StepNum int not null 
        constraint ck_Instructions_StepNum_must_be_greater_than_0 check(StepNum > 0),
    Instructions varchar(200) not null 
        constraint ck_Instructions_Instructions_cannot_be_blank check(Instructions <> ''),
    constraint u_RecipeId_StepNum unique(RecipeId, StepNum)
)

Create table dbo.Course(
    CourseId int not null identity primary key, 
    CourseName varchar(25) not null 
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName <> '')
        constraint u_Course_CourseName unique,
    CourseNum int not null 
        constraint ck_Course_CourseNum_must_be_greater_than_0 check(CourseNum > 0)
        constraint u_Course_CourseNum unique
)

Create table dbo.Meal( 
    MealId int not null identity primary key,
    StaffId int not null 
        constraint f_Staff_Meal foreign key references Staff(StaffId), 
    MealName varchar(75) not null 
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> '')
        constraint u_Meal_MealName unique,
    MealActive bit default 1 not null, 
    DateCreated date not null
        constraint ck_Meal_DateCreated_must_be_before_or_on_current_date check(DateCreated <= getdate()), 
    MealPic as concat('Meal','-',replace(MealName,' ','-'),'.jpg') persisted
)

Create table dbo.MealCourse(  
    MealCourseId int not null identity primary key,
    MealId int not null 
        constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null 
        constraint f_Course_MealCourse foreign key references Course(CourseId),
    constraint u_MealId_CourseId unique(MealId, CourseId)
)

Create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key, 
    MealCourseId int not null
        constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId), 
    RecipeId int not null
        constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId), 
    IsMain bit not null,
    constraint u_MealCourseId_RecipeId unique(MealCourseId, RecipeId)
)
    
Create table dbo.Cookbook(    
    CookbookId int not null identity primary key, 
    StaffId int not null 
        constraint f_Staff_Cookbook foreign key references Staff(StaffId), 
    CookbookName varchar(75) not null 
        constraint ck_Cookbook_CookbookName_cannot_be_blank check(CookbookName <> '')
        constraint u_Cookbook_CookbookName unique, 
    Price decimal (5,2) not null
        constraint ck_Cookbook_Price_must_be_greater_than_0 check(Price > 0),
    CookbookActive bit default 1 not null,
    DateCreated date not null
                constraint ck_Cookbook_DateCreated_must_be_before_or_on_current_date check(DateCreated <= getdate()), 
    CookbookPic as concat('Cookbook','-',replace(CookbookName,' ','-'),'.jpg') persisted
)

Create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key, 
    CookbookId int not null 
        constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId), 
    RecipeId int not null 
        constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId), 
    RecipeNum int not null 
        constraint ck_CookbookRecipe_RecipeNum_must_be_greater_than_0 check(RecipeNum > 0),
    constraint u_CookbookId_RecipeId unique(CookbookId, RecipeId),
    constraint u_CookbookId_RecipeNum unique(CookbookId, RecipeNum)
)
