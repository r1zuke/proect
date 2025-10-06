using System.Windows;
using PersonalFinance.ViewModels;

namespace PersonalFinance.Views
{
    public partial class EditTransactionWindow : Window
    {
        public EditTransactionWindow()
        {
            InitializeComponent();
            DataContext = new EditTransactionViewModel();
        }
    }
}