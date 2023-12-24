-- SM Excellent sketch! See comments. I believe you can start creating the DB! Good luck!

Staff  
    StaffId int not null identity primary key, 
    FirstName varchar(35) not null 
        constraint ck_Staff_FirstName_cannot_be_blank, 
    LastName varchar(35) not null 
        constraint ck_Staff_LastName_cannot_be_blank, 
    Username varchar(35) not null 
        constraint ck_Staff_UserName_cannot_be_blank
        unique constraint

Cuisine
    CuisineId int not null identity primary key,
    CuisineName varchar(30) not null 
        constraint ck_Cusine_CuisineName_cannot_be_blank
        unique constraint,

Ingredient
    IngredientId int not null identity primary key, 
    IngredientName varchar(30) not null 
        constraint ck_Ingredient_IngredientName_cannot_be_blank
        unique constraint, 
    IngredientPic as concat('Ingredient','-',replace(IngredientName,' ','-'),'.jpg') persisted

Measurement 
    MeasurementId int not null identity primary key,
    MeasurementName varchar(20) not null
        unique constraint

Recipe
    RecipeId int not null identity primary key, 
    StaffId int not null 
        constraint f_Staff_Recipe foreign key references Staff, 
    CuisineId int not null 
        constraint f_Cuisine_Recipe foreign key references Cuisine, 
    RecipeName varchar(75) not null 
        constraint ck_Recipe_RecipeName_cannot_be_blank 
        unique constraint,
    Calories int not null 
        constraint ck_Recipe_Calories_must_be_greater_than_0,
-- SM Update this based on my comments later. And best would be to use nested case, like that you wont repeat yourself. And this column should be the status not the date.
--CR I wasn't sure how to do a nested case.....
-- SM case when [column] is <not> null then case when [other column] is <not> null then [value] else [value] end else [value] end
    DateDrafted date not null,
    DatePublished datetime null, 
    DateArchived date null, 
    RecipeStatus as case   
                        when DatePublished is not null 
                        then case
                                when DateArchived is not null 
                                then 'Archived'
                                else 'Published'
                        end  
                            else 'Drafted'
                        end persisted, 
    RecipePic as concat('Recipe','-',replace(RecipeName,' ','-'),'.jpg') persisted, 
    constraint ck_Recipe_DateDrafted_must_be_before_DateArchived,
    constraint ck_Recipe_DatePublished_must_be_between_DateDrafted_and_DateArchived


RecipeIngredient
    RecipeIngredientId int not null identity primary key, 
    RecipeId int not null   
        constraint f_Recipe_RecipeIngredient foreign key references Recipe, 
    IngredientId int not null 
        constraint f_Ingredient_RecipeIngredient foreign key references Ingredient,
    MeasurementId int not null 
        constraint f_Measurement_RecipeIngredient foreign key references Measurement,
    IngredientNum int not null 
        constraint ck_RecipeIngredient_IngredientNum_must_be_greater_than_0,
    IngredientAmount varchar(5) not null 
        constraint ck_RecipeIngredient_IngredientAmount_cannot_be_blank,
    unique constraint RecipeId, IngredientId,
    unique constraint RecipeId, IngredientNum


Instructions
    InstructionsId int not null identity primary key, 
    RecipeId int not null   
        constraint f_Recipe_Instructions foreign key references Instructions, 
    StepNum int not null 
        constraint ck_Instructions_StepNum_must_be_greater_than_0,
    Instructions varchar(200) not null 
        constraint ck_Instructions_Instructions_cannot_be_blank,
    unique constraint RecipeId, StepNum 

Course
    CourseId int not null identity primary key, 
    CourseName varchar(25) not null 
        constraint ck_Course_CourseName_cannot_be_blank
        unique constraint,
    CourseNum int not null 
        constraint ck_Course_CourseNum_must_be_greater_than_0
        unique constraint

Meal 
    MealId int not null identity primary key,
    StaffId int not null 
        constraint f_Staff_Meal foreign key references Staff, 
    MealName varchar(75) not null 
        constraint ck_Meal_MealName_cannot_be_blank
        unique constraint,
-- SM default to true
    MealActive bit default 1, 
    DateCreated date not null, 
    MealPic as concat('Meal','-',replace(MealName,' ','-'),'.jpg') persisted

MealCourse  
    MealCourseId int not null identity primary key,
    MealId int not null 
        constraint f_Meal_MealCourse foreign key references Meal,
    CourseId int not null 
        constraint f_Course_MealCourse foreign key references Course,
    unique constraint MealId, CourseId

MealCourseRecipe
    MealCourseRecipeId int not null identity primary key, 
    MealCourseId int not null
        constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse, 
    RecipeId int not null
        constraint f_Recipe_MealCourseRecipe foreign key references Recipe, 
    IsMain bit,
    unique constraint MealCourseId, RecipeId
    
Cookbook    
    CookbookId int not null identity primary key, 
    StaffId int not null 
        constraint f_Staff_Cookbook foreign key references Staff, 
    CookbookName varchar(75) not null 
        constraint ck_Cookbook_CookbookName_cannot_be_blank
        unique constraint, 
    Price decimal (5,2) not null
        constraint ck_Cookbook_Price_must_be_greater_than_0,
-- SM default to true
    CookbookActive bit default 1,
    DateCreated date not null,
    CookbookPic as concat('Cookbook','-',replace(CookbookName,' ','-'),'.jpg') persisted 

CookbookRecipe
    CookbookRecipeId int not null identity primary key, 
    CookbookId int not null 
        constraint f_Cookbook_CookbookRecipe foreign key references Cookbook, 
    RecipeId int not null 
        constraint f_Recipe_CookbookRecipe foreign key references Recipe, 
    RecipeNum int not null 
        constraint ck_CookbookRecipe_RecipeNum_must_be_greater_than_0,
    unique constraint CookbookId, RecipeId,
    unique constraint CookbookId, RecipeNum


*/