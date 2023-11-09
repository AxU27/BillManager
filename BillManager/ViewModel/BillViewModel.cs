using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillManager.Model;
using CommunityToolkit.Mvvm.Input;

namespace BillManager.ViewModel
{
    
    public partial class BillViewModel : BaseViewModel
    {
        public ObservableCollection<Bill> Bills { get; } = new();

        public BillViewModel()
        {
            Title = "Bill Manager";
        }

        [RelayCommand]
        void GetBills()
        {
            if (Bills.Count > 0)
            {
                Bills.Clear();
            }

            for (int i = 0; i < 5; i++)
            {
                Bill bill = new Bill();
                bill.Name = "Bill " + (i + 1);
                bill.Receiver = "Receiver " + (i + 1);
                bill.Price = i;
                bill.DueDate = DateOnly.FromDateTime(DateTime.Now);
                Bills.Add(bill);
            }
        }
    }
}
