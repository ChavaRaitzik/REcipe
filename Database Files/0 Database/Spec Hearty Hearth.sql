/*
Hearty Hearth Spec:


Website includes: 
- Recipes
- Meals 
- Cookbooks

Recipe can be on recipe page, part of a meal, and part of a cookbook. 
Recipe is duplicated on multiple pages.

Problem is that everything is duplicated, and when people fix things in one place, not changed everywhere.

Database needed where all information will be stored in one place. Nothing will be duplicated. It will just be displayed in multiple places.


Recipes are our most basic unit.

Recipes have:
-Cuisine types e.g. Chinese, Mediterranean
Cuisine has to be part of a master list 
-Ingredients
Each ingredient has a measurement type and an amount
Need to record the sequence of the ingredient in the recipe
-Directions
Each step has instructions and a sequence number
-Status
Draft (not yet on website), Published (on website), and Archive (when recipe gets taken off website)
Status needs dates when it was created, when it was published (needs date and time), and when it was archived so that we can see how long a recipe was in each stage
When something is archived it's not deleted
-Calories

Meals have:
-Names
-Multiple courses e.g. appetizer, main, dessert
Each course can have multiple recipes
Courses have sequence in the meals
Can have many courses and recipes, but cannot have 2 courses with the same name. (There can be multiple recipes in one course)
Need to record which recipe is the main dish and which are side dishes
-Status of active or inactive, no dates needed
-Record date created

*Everything in the system has a unique name e.g. Name of ingredient, recipe, book, or meal has one time use

Cookbooks have:
-Names
-Prices 
-Recipes
Cookbooks do not have meals
Recipes are in the cookbook in a specific sequence
-Status of active or inactive, no dates needed
-Record date created

Pictures:
Every picture belongs to a certain type.
Name of picture is very tight.
It starts with the name of the picture type e.g. ingredient, then it has the name of what it is e.g. baby-carrot
There are no spaces in the naming e.g. ingredient-baby-carrot.jpg or recipe-family-pizza.jpg
All pictures are jpegs
One master pictures folder

Meals and Cookbooks have status of active and inactive, no dates needed
Should record the dates they were created

Staff have:
-Firstname 
-Lastname 
-Username
Staff are called users
Everything that is created in the system has to have the user that created it

Tasks:
There should be a way to clone items

First create schema sketch and approve it.
*/
