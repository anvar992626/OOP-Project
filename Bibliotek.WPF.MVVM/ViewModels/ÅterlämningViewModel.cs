using AffärsLager;
using Bibliotek.WPF.MVVM.Commands;
using Bibliotek.WPF.MVVM.Models;
using DatalagerEF;
using EntitetsLager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Bibliotek.WPF.MVVM.ViewModels
{
    public class ÅterlämningViewModel : ObservableObject
    {
        private readonly Controller controller;
       

        private ObservableCollection<Bokning> aktivaBokningar = null!;
        public ObservableCollection<Bokning> AktivaBokningar { get => aktivaBokningar; set { aktivaBokningar = value; OnPropertyChanged(); } }

       
        
        private int aktivaBokningarSelectedIndex;
        public int AktivaBokningarSelectedIndex { get { return aktivaBokningarSelectedIndex; } set { aktivaBokningarSelectedIndex = value; OnPropertyChanged(); } }

        private Bokning aktivaBokningarSelectedItem = null!; 
        public Bokning AktivaBokningarSelectedItem
        {
            get { return aktivaBokningarSelectedItem; }
            set
            {
                aktivaBokningarSelectedItem = value;
                OnPropertyChanged();
            }
        }

        private int bokningarSelectedIndex;
        public int BokningarSelectedIndex
        {
            get { return bokningarSelectedIndex; }
            set { bokningarSelectedIndex = value; OnPropertyChanged(); }
        }

       
        
        
        
        private bool isNotModified = true;
        public bool IsNotModified
        {
            get { return isNotModified; }
            set { isNotModified = value; OnPropertyChanged(); }
        }
       
        public ÅterlämningViewModel()
        {
            controller = new Controller();
            aktivaBokningar = new ObservableCollection<Bokning>();
            ReadCommand.Execute(null!);
        }



        // COMMANDS

        private ICommand readCommand = null!;
        public ICommand ReadCommand => readCommand ??= readCommand = new RelayCommand(() =>
        {
            AktivaBokningar = new ObservableCollection<Bokning>(controller.HämtaBokningar());
        });


        private ICommand retuneraCommand;
        public ICommand RetuneraCommand => retuneraCommand ??= new RelayCommand(() =>
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Bokning selectedBooking = AktivaBokningarSelectedItem;
            Faktura faktura = controller.LämnaInBokning(selectedBooking.Bokningsnummer);
            // Ta bort bokningen från databasen
            unitOfWork.BokningRepos.Remove(selectedBooking);
            unitOfWork.Save();
            AktivaBokningar.Remove(selectedBooking); // Ta bort bokningen från ObservableCollection
            MessageBox.Show("Bokningen är nu återlämnad och borttagen från databasen!");
        });

    }
}

        










        
