using BillManager.ViewModel;

namespace BillManager;

public partial class MainPage : ContentPage
{
    
    public MainPage(BillViewModel viewModel)
    {
        InitializeComponent();
        BindingContext =  viewModel;
    }

    
}