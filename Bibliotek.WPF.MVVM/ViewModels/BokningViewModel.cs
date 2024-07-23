using AffärsLager;
using Bibliotek.WPF.MVVM.Commands;
using Bibliotek.WPF.MVVM.Models;
using EntitetsLager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Bibliotek.WPF.MVVM.ViewModels
{
    public class BokningViewModel : ObservableObject
    {
        private readonly Controller controller;

        private ObservableCollection<Bok> tillgängligaBöcker = null!;
        public ObservableCollection<Bok> TillgängligaBöcker { get => tillgängligaBöcker; set { tillgängligaBöcker = value; OnPropertyChanged(); } }

        public ObservableCollection<Bok> valdaBöcker = null!;
        public ObservableCollection<Bok> ValdaBöcker { get => valdaBöcker; set { valdaBöcker = value; OnPropertyChanged(); } }

        public ObservableCollection<Bokning> bokningar = null!;
        public ObservableCollection<Bokning> Bokningar { get => bokningar; set { bokningar = value; OnPropertyChanged(); } }


        private Bok böckerSelectedItem = null!;
        public Bok BöckerSelectedItem
        {
            get { return böckerSelectedItem; }
            set { böckerSelectedItem = value; OnPropertyChanged(); }
        }

        private Bok tillgängligaBöckerSelectedItem = null!;
        public Bok TillgängligaBöckerSelectedItem
        {
            get { return tillgängligaBöckerSelectedItem; }
            set
            {
                tillgängligaBöckerSelectedItem = value;
                OnPropertyChanged();
            }
        }
        private int tillgängligaBöckerSelectedIndex;
        public int TillgängligaBöckerSelectedIndex { get { return tillgängligaBöckerSelectedIndex; } set { tillgängligaBöckerSelectedIndex = value; OnPropertyChanged(); } }

      
        private int böckerSelectedIndex;
        public int BöckerSelectedIndex
        {
            get { return böckerSelectedIndex; }
            set { böckerSelectedIndex = value; OnPropertyChanged(); }
        }

      



        private bool isNotModified = true;
        public bool IsNotModified
        {
            get { return isNotModified; }
            set { isNotModified = value; OnPropertyChanged(); }
        }

        private string medlemsnummer;
        public string Medlemsnummer 
        {
            get { return medlemsnummer; }
            set
            {
                medlemsnummer = value;
                OnPropertyChanged();
            }
        }

        private DateTime valtDatum = DateTime.Now;
        public DateTime ValtDatum
        {
            get { return valtDatum; }
            set
            {
                valtDatum = value;
                OnPropertyChanged(nameof(ValtDatum));
            }
        }

        private int? antalDagar;
        public int? AntalDagar
        {
            get { return antalDagar; }
            set { antalDagar = value; OnPropertyChanged(); }
        }
        

     


        public BokningViewModel()
        {
            controller = new Controller();
            TillgängligaBöcker = new ObservableCollection<Bok>();
            ValdaBöcker = new ObservableCollection<Bok>();

            ReadCommand.Execute(null!);
        }



        // COMMANDS 

        private RelayCommand skapaBokningCommand = null!;
        public RelayCommand SkapaBokningCommand => skapaBokningCommand ??= new RelayCommand(() =>
        {
            int medlemsnummer = int.Parse(Medlemsnummer);
            DateTime startTid = ValtDatum;
            int? antalDagar = AntalDagar;
            DateTime slutTid = startTid.AddDays(antalDagar ?? 0);
            
            List<Bok> valdaBocker = new List<Bok>();

            foreach (Bok bok in valdaBöcker)
            {
                if (!valdaBocker.Contains(bok))
                {
                    valdaBocker.Add(bok);
                }
            }

            Bokning b = controller.SparaBokning(valdaBocker, medlemsnummer, startTid, slutTid);

            MessageBox.Show("Bokningen är bekräftad:\n\nMedlemsnamn: " + b.Medlemsnummer.Namn + "\nStarttid: " + startTid + "\nAntal dagar: " + antalDagar + "\nSluttid: " + slutTid);


        }, () => !string.IsNullOrEmpty(Medlemsnummer) && AntalDagar > 0);

        /// <summary>
        /// Flytta tillbaka från ValdaBöcker till TillgängligaBöcker
        /// </summary>
        private ICommand removeCommand = null!;
        public ICommand RemoveCommand => removeCommand ??= new RelayCommand(() =>
        {
            if (BöckerSelectedItem != null && ValdaBöcker.Contains(BöckerSelectedItem))
            {
                TillgängligaBöcker.Add(BöckerSelectedItem);
                ValdaBöcker.Remove(BöckerSelectedItem);

                IsNotModified = false;
            }
        }, () => BöckerSelectedItem != null && ValdaBöcker.Contains(BöckerSelectedItem));

        /// <summary>
        /// Flytta från TillgängligaBöcker till ValdaBöcker
        /// </summary>
        private ICommand addCommand = null!;
        public ICommand AddCommand => addCommand ??= new RelayCommand(() =>
        {
            if (BöckerSelectedItem != null && TillgängligaBöcker.Contains(BöckerSelectedItem))
            {
                ValdaBöcker.Add(BöckerSelectedItem);
                TillgängligaBöcker.Remove(BöckerSelectedItem);

                IsNotModified = false;
            }
        }, () => BöckerSelectedItem != null && TillgängligaBöcker.Contains(BöckerSelectedItem));

        private ICommand readCommand = null!;
        public ICommand ReadCommand => readCommand ??= readCommand = new RelayCommand(() =>
        {
            TillgängligaBöcker = new ObservableCollection<Bok>(controller.HämtaTillgängligaBöcker());
        });

    }


}
        













