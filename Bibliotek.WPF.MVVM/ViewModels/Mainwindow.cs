using AffärsLager;
using Bibliotek.WPF.MVVM.Commands;
using Bibliotek.WPF.MVVM.Models;
using EntitetsLager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Bibliotek.WPF.MVVM.ViewModels
{
    public class Mainwindow : ObservableObject   
    {
        public Controller controller = new Controller();



        private ICommand exitCommand = new RelayCommand(() => App.Current.Shutdown());
        public ICommand ExitCommand => exitCommand;

     

        public BokningViewModel Bokning { get; set; } = new BokningViewModel(); 
        public ÅterlämningViewModel Återlämning { get; set; } = new ÅterlämningViewModel();

    }
}
