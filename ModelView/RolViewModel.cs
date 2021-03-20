
using System;
using System.ComponentModel;
using System.Windows.Input;
using kalum2021.Models;

namespace kalum2021.ModelView
{
    public class RolViewModel: INotifyPropertyChanged, ICommand
    {
        public RolViewModel Instancia {get;set;}
        public RolesViewModel RolesViewModel {get;set;}
        public string Id{get;set;}
        public string Nombre{get;set;}

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public RolViewModel(RolesViewModel RolesViewModel)
        {
            this.Instancia = this;
            this.RolesViewModel = RolesViewModel;
            
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Guardar"))
            {
                Role nuevo = new Role(4,Nombre);
                this.RolesViewModel.agregarElemento(nuevo);   
            }
        }
    }
}