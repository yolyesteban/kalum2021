using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using kalum2021.Models;
using kalum2021.Views; 

namespace kalum2021.ModelView
{
    public class RolesViewModel : INotifyPropertyChanged, ICommand
    {
        public ObservableCollection<Role> roles {get;set;}
        public RolesViewModel Instancia {get;set;}
        public Role Seleccionado {get; set;}
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public RolesViewModel()
        {
            this.Instancia = this;
            roles = new ObservableCollection<Role>();
            roles.Add(new Role(1,"ROLE_ADMIN"));
            roles.Add(new Role(2,"ROLE_USER"));
            roles.Add(new Role(3,"ROLE_SUPERV"));
        }

        public void NotificarCambio(string propiedad)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        public void agregarElemento(Role nuevo)
        {
            this.roles.Add(nuevo);
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Nuevo"))
            {
                RolView nuevoRol = new RolView (Instancia);
                nuevoRol.Show();
            }
            else if (parametro.Equals("Eliminar"))
            {
                if (this.Seleccionado==null)
                {
                    MessageBox.Show("Debe seleccionar un elemento");
                }
                else
                {
                    this.roles.Remove(Seleccionado);
                }
            }
        }
    }
}