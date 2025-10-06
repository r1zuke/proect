using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalFinance.Models;
using System;
using System.Windows;

namespace PersonalFinance.ViewModels
{
    public partial class EditTransactionViewModel : ObservableObject
    {
        [ObservableProperty]
        private Transaction transaction;

        public EditTransactionViewModel()
        {
            Transaction = new Transaction { Date = DateTime.Now };
        }

        [RelayCommand]
        private void Save()
        {
            MessageBox.Show($"Сохранено: {Transaction.Description} ({Transaction.Amount:C})");
            CloseWindow();
        }

        [RelayCommand]
        private void Cancel()
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is Views.EditTransactionWindow)
                {
                    window.Close();
                    break;
                }
            }
        }
    }
}
