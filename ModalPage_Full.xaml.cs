using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace MauiShellTitleView2;

public partial class ModalPage_Full : ContentPage
{
	public ModalPage_Full()
	{
		InitializeComponent();
		On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FullScreen);
	}

    private async void CancelButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}