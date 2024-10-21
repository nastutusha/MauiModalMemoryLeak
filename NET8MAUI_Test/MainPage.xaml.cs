using Microsoft.Maui.Handlers;

namespace NET8MAUI_Test;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		 Navigation.PushModalAsync (new SecondPage ());
	}
}


