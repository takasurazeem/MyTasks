using MyTasks.ViewModel;

namespace MyTasks;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}