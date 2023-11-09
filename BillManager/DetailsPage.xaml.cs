using BillManager.ViewModel;

namespace BillManager;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(BillDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}