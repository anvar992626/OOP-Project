
using AffärsLager;
using Bibliotek.WPF.MVVM.Commands;
using Bibliotek.WPF.MVVM.Models;
using Bibliotek.WPF.MVVM.Views;
using EntitetsLager;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Bibliotek.WPF.MVVM.ViewModels
{
    public class LoggInViewModel : ObservableObject
    {
        private int? expeditnummer;  // ? för att ta bort 0 default värdet ifrån textboxen
        private string lösenord;
        private Expedit loggedIn;




        public int? Expeditnummer
        {
            get { return expeditnummer; }
            set { expeditnummer = value; OnPropertyChanged(); }
        }

        public string Lösenord
        {
            get { return lösenord; }
            set { lösenord = value; OnPropertyChanged(); }
        }
        public Expedit LoggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; OnPropertyChanged(); }
        }


        public LoggInViewModel()
        {
            ExitApplicationCommand = new RelayCommand(ExitApplication);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // COMMANDS

        private ICommand loggaInCommand;
        public ICommand LoggaInCommand
        {
            get
            {
                if (loggaInCommand == null)
                {
                    loggaInCommand = new RelayCommand(() =>
                    {
                        var controller = new Controller();
                        bool success = controller.LoggaIn(Expeditnummer ?? 0, Lösenord);  // ?? 0 för att ta bort 0 default värde 
                        if (success)
                        {
                            LoggedIn = controller.LoggedIn;
                            // Navigera till nästa vy här
                            MainWindow MW = new MainWindow();
                            MW.Show(); 
                            App.Current.MainWindow.Close();
                            App.Current.MainWindow = MW;
                        }
                        else
                        {
                            MessageBox.Show("Fel expeditnummer eller lösenord, försök igen.");
                        }
                    });
                }
                return loggaInCommand;
            }
        }
       

        

       

        private ICommand exitCommand = new RelayCommand(() => App.Current.Shutdown());
        public ICommand ExitCommand => exitCommand;

        
       
        public ICommand ExitApplicationCommand { get; set; }
        private void ExitApplication()
        {
            App.Current.Shutdown();
        }

       
    }
}
















