using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace MauiShellTitleView2;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
        On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
	}
}