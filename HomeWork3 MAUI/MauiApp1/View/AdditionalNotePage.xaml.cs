using MauiApp1.Model;

namespace MauiApp1.View;

public partial class AdditionalNotePage : ContentPage
{
	Note EditorText { get; set; }

	public AdditionalNotePage()
	{
		InitializeComponent();

        BindingContext = new NotesPageViewModel();
    }

    async void SaveButtonClicked(object sender, EventArgs e)
    {
        ((NotesPageViewModel)BindingContext).notes.Add(EditorText);
    }
}