using BillManager.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager.ViewModel
{
    [QueryProperty("Bill", "Bill")]
    public partial class BillDetailsViewModel : BaseViewModel
    {
        public BillDetailsViewModel() 
        {

        }

        [ObservableProperty]
        Bill bill;
    }
}
