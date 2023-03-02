namespace MauiApp1.View;

public partial class NotesPage : ContentPage
{

    public NotesPage()
    {
        InitializeComponent();
    }

    private async void OnButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdditionalNotePage());
    }

}