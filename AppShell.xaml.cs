namespace MauiShellTitleView2;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(SubPage), typeof(SubPage));
        Routing.RegisterRoute(nameof(ModalPage), typeof(ModalPage));
        Routing.RegisterRoute(nameof(ModalPage_Full), typeof(ModalPage_Full));
    }

    private async void ModalPage_Clicked(object sender, EventArgs e)
    {
        FlyoutIsPresented = false;

        await Shell.Current.GoToAsync(nameof(ModalPage));
    }

    private async void ModalPage_Full_Clicked(object sender, EventArgs e)
    {
        FlyoutIsPresented = false;

        await Shell.Current.GoToAsync(nameof(ModalPage_Full));
    }
}
