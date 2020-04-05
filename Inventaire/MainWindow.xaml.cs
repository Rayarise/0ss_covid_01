using System.Windows;
using BillingManagement.UI.ViewModels;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
     

        public MainWindow(CustomersViewModel vm)
        {
            InitializeComponent();

            DataContext = vm;
        }

       

      
    }
}
