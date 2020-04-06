using BillingManagement.busines;
using BillingManagement.models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System;

namespace BillingManagement.UI.ViewModels
{
    public class CustomersViewModel : BaseViewModel
    {

        CustomersDataService customersDataService = new CustomersDataService();

        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;

        public ObservableCollection<Customer> Customers
        {
            get => customers;
            private set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        public CustomersViewModel()
        {
            InitValues();
            CreateAddCommand();
            CreateDelCommand();
            CreateQuitCommand();
        }


        private void InitValues()
        {
            Customers = new ObservableCollection<Customer>(customersDataService.GetAll());
            Debug.WriteLine(Customers.Count);
        }

        //binding:

        public ICommand AddCommand
        {
            get;
            internal set;
        }

      /*  private bool CanExecuteAddCommand()
        {
            return !string.IsNullOrEmpty(LastName);
        }*/

        private void CreateAddCommand()
        {
            AddCommand = new RelayCommand(AddExecute);
        }

        public void AddExecute()
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            Customers.Add(temp);
            SelectedCustomer = temp;
        }




        public ICommand DelCommand
        {
            get;
            internal set;
        }

        /*  private bool CanExecuteAddCommand()
          {
              return !string.IsNullOrEmpty(LastName);
          }*/

        private void CreateDelCommand()
        {
            DelCommand = new RelayCommand(DelExecute);
        }


        public void DelExecute()
        {

            int currentIndex = Customers.IndexOf(SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            Customers.Remove(SelectedCustomer);

          //  lvCustomers.SelectedIndex = currentIndex;

        }


        public ICommand QuitCommand
        {
            get;
            internal set;
        }
        
        /*  private bool CanExecuteAddCommand()
          {
              return !string.IsNullOrEmpty(LastName);
          }*/

        private void CreateQuitCommand()
        {
           QuitCommand = new RelayCommand(QuitExecute);
        }


        public void QuitExecute()
        {

            Environment.Exit(0);
            Application.Current.Shutdown();
        }


    }
}
