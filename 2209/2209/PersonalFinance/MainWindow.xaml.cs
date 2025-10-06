using System.Windows;
using PersonalFinance.ViewModels;

namespace PersonalFinance
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}