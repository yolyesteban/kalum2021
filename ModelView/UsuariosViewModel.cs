using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using kalum2021.Models;
using kalum2021.Views; 

namespace kalum2021.ModelView
{
    public class UsuariosViewModel : INotifyPropertyChanged, ICommand
    {
        public ObservableCollection<Usuarios> usuarios {get;set;}
        public UsuariosViewModel Instancia {get; set;}
        public Usuarios Seleccionado{get;set;}
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public UsuariosViewModel()
        {
            this.Instancia = this;
            this.usuarios = new ObservableCollection<Usuarios>();
            this.usuarios.Add(new Usuarios(1,"yesteban",true,"Yolanda","Esteban","yesteban09@gmail.com"));
            this.usuarios.Add(new Usuarios(2,"balonzo",true,"Benjamin","Alonzo","balonzo@gmail.com"));
            //this.usuarios.Add(new Usuarios(3,"cherrera",))
        }



        public void NotificarCambio(string propiedad)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        public void agregarElemento(Usuarios nuevo)
        {
            this.usuarios.Add(nuevo);
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Nuevo"))
            {
                //Usuarios elemento = new Usuarios(100,"yesteban",true,"Yolanda","Esteban","yec101@gmail.com");
                //agregarElemento(elemento);
                UsuarioView nuevoUsuario = new UsuarioView(Instancia);
                nuevoUsuario.Show();
            }else if (parametro.Equals("Eliminar"))
            {
                if (this.Seleccionado==null)
                {
                    MessageBox.Show("Debe seleccionar un elemento");
                }else
                {
                    this.usuarios.Remove(Seleccionado);
                }
                
            }
            
        }
    }
}