using GymApp.DAL;
using GymApp.ViewModels;


namespace GymApp.Views;

public partial class MembersPage : ContentPage
{
	MembersViewModel viewModel;
	public MembersPage()
	{
		InitializeComponent();
		HandlerChanged += OnHandlerChanged;
	}

	void OnHandlerChanged(object sender, EventArgs e)
	{
		viewModel = Handler?.MauiContext.Services.GetService<MembersViewModel>();
		BindingContext = viewModel;
		HandlerChanged -= OnHandlerChanged;	
	}
}