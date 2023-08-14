namespace Todo2409063;
using Todo2409063.Views;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
    }
}
