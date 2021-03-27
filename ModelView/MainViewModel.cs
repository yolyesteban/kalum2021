using System;
using System.ComponentModel;
using System.Windows.Input;
using kalum2021.Views;

namespace kalum2021.ModelView
{
    public class MainViewModel : INotifyPropertyChanged, ICommand
    {
        public string Fondo {get;set;} = $"{Environment.CurrentDirectory}\\Images\\fondo2.gif";
        public MainViewModel Instancia {get;set;}
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public MainViewModel()
        {
            this.Instancia = this;
        }
        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Usuarios"))
            {
                UsuariosView ventanaUsuarios = new UsuariosView();
                ventanaUsuarios.ShowDialog();
            }
            else if (parametro.Equals("Roles"))
            {
                RolesView ventanaRoles = new RolesView();
                ventanaRoles.ShowDialog();
            }

        }
    }
}