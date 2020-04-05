using BillingManagement.UI.ViewModels;
using Inventaire;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainWindow _wnd;

        public App()
        {
            CustomersViewModel vm = new CustomersViewModel();

            _wnd = new MainWindow(vm);

            _wnd.Show();

        }
    }
}
