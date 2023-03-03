using MauiApp1.Model;

namespace MauiApp1.View;

public partial class NotesPage : ContentPage
{

    public NotesPage()
    {
        InitializeComponent();

        BindingContext = new NotesPageViewModel();
       /* ((NotesPageViewModel)BindingContext).notes.Add(new Model.Note());*/  //проверка вывода из модели 
    }

    private async void OnButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdditionalNotePage());
    }
    

}