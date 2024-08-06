using System.Windows.Input;

namespace GymApp.Views;

public partial class HomePage : ContentPage
{
	HomeViewModel viewModel;
	public HomePage()
	{
		InitializeComponent();
		HandlerChanged += OnHandlerChanged;
	}

	void OnHandlerChanged(object sender, EventArgs e)
	{
		viewModel = Handler?.MauiContext.Services.GetService<HomeViewModel>();
		BindingContext = viewModel;
		HandlerChanged -= OnHandlerChanged;
	}
}