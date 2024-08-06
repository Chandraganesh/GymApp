using Microsoft.Maui.Controls;
using GymApp.Views;

namespace GymApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("registration", typeof(RegistrationPage));
		Routing.RegisterRoute("members", typeof(MembersPage));
		Routing.RegisterRoute("reports", typeof(ReportsPage));
		Routing.RegisterRoute("enquiries", typeof(EnquiriesPage));
	}
}