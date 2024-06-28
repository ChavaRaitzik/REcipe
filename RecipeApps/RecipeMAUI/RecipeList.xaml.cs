using RecipeSystems;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
		DataTable dt = Recipe.GetRecipeList();
		RecipeLst.ItemsSource = dt.Rows;
	}
}