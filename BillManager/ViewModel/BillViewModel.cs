using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillManager.Model;

namespace BillManager.ViewModel
{
    
    public partial class BillViewModel : BaseViewModel
    {
        public ObservableCollection<Bill> Bills { get; } = new();

        public BillViewModel()
        {
            Title = "asd";
        }
    }
}
