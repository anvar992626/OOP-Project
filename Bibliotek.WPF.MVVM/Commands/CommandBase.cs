using System;
using System.Windows.Input;

namespace Bibliotek.WPF.MVVM.Commands 
{
    // En abstrakt klass som implementerar ICommand-gränssnittet
    public abstract class CommandBase : ICommand
    {
        // Metod som avgör om kommandot kan köras eller inte.
        // Tar emot en parameter som inte används i denna basimplementering.
        // Implementeras av de härledda klasserna.
        public abstract bool CanExecute(object parameter);

        // Metod som körs när kommandot körs.
        // Tar emot en parameter som inte används i denna basimplementering.
        // Implementeras av de härledda klasserna.
        public abstract void Execute(object parameter);

        // Ett händelse som körs när CanExecute-metoden ändrar sitt svar.
        // Tillåter andra objekt att prenumerera på ändringar i CanExecute-metoden.
        // När händelsen körs, reagerar det WPF-interna CommandManager-objektet
        // och kallar på CanExecute-metoden för att avgöra om kommandot kan köras eller inte.
        // Om CanExecute-metoden har ändrats sedan den senaste anropet till RequerySuggested
        // kommer CommandManager att uppdatera knapparnas status i användargränssnittet.
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
