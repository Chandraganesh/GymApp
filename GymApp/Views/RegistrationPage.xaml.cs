using GymApp.DAL;
using GymApp.ViewModels;

namespace GymApp.Views;

public partial class RegistrationPage : ContentPage
{
	RegistrationViewModel viewModel;
	public RegistrationPage()
	{
		InitializeComponent();
		HandlerChanged += OnHandlerChanged;
	}

	void OnHandlerChanged(object sender, EventArgs e)
	{
		viewModel = Handler?.MauiContext.Services.GetService<RegistrationViewModel>();
		BindingContext = viewModel;
		HandlerChanged -= OnHandlerChanged;
	}
}