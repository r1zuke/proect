using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalFinance.Models;
using PersonalFinance.Views;
using System.Collections.ObjectModel;
using System;
using _2209.PersonalFinance.Views;
using System.Transactions;

namespace PersonalFinance.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] private string pageTitle = "Дашборд";
        [ObservableProperty] private string sub = "Ваши транзакции";
        [ObservableProperty] private string textSearch;

        [ObservableProperty] private ObservableCollection<Transaction> transactions;

        public MainViewModel()
        {
            Transactions = new ObservableCollection<Transaction>
            {
                new Transaction { Id=1, Description="Продукты", Category="Еда", Date=DateTime.Now, Amount=-2300 },
                new Transaction { Id=2, Description="Зарплата", Category="Доход", Date=DateTime.Now.AddDays(-2), Amount=75000, IsIncome=true }
            };
        }

        [RelayCommand]
        private void AddTranz()
        {
            var win = new EditTransactionWindow();
            win.ShowDialog();
        }

        [RelayCommand]
        private void Export()
        {
            System.Windows.MessageBox.Show("Экспорт данных (заглушка)");
        }
    }
}
