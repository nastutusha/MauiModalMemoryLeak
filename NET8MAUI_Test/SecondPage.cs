using Microsoft.VisualBasic;

namespace NET8MAUI_Test;

public class SecondPage : ContentPage
{
	public SecondPage()
	{
		var returnButton = new Button { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Return",
				};
		returnButton.Clicked += returnBackModally;
		Content = new VerticalStackLayout
		{
			
			Children = {
				returnButton
			}
		};
	}

    private async void returnBackModally(object? sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
