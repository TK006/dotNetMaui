namespace ButtonThenMessageBox;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await DisplayAlert("test Message", "if you press OK the Message disappears","Ok");
	}
}

