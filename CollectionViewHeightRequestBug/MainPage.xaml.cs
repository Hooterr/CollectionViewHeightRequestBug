namespace CollectionViewHeightRequestBug;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        collection.ItemsSource = Enumerable.Range(0, 2000).ToList();
    }

    
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        collection.HeightRequest = 600.5d;
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        collection.HeightRequest = 600.0d;
    }
}


