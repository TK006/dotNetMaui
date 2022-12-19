namespace textInputWithMessageBox;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		string text = entry.Text;
		await DisplayAlert("your Input", text, "OK");
	}
	
	
}

