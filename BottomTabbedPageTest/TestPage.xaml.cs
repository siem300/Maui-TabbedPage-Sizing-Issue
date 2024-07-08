namespace BottomTabbedPageTest;

public partial class TestPage : ContentPage
{
    private MainPage _mainPage;
	public TestPage(MainPage mainPage)
	{
        _mainPage = mainPage;
        InitializeComponent();
        BackgroundColor = Colors.Red;
	}

    public void OnButtonClicked(object sender, EventArgs args)
    {
        _mainPage.ClearAndAddPages();
    }
}