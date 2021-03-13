using System.Collections.ObjectModel;
using System.ComponentModel;
using kalum2021.Models;
namespace kalum2021.ModelView
{
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Usuarios> usuarios {get;set;}

        public UsuarioViewModel()
        {
            this.usuarios = new ObservableCollection<Usuarios>();
            this.usuarios.Add(new Usuarios(1,"yesteban",true,"Yolanda","Esteban","yesteban09@gmail.com"));
            this.usuarios.Add(new Usuarios(2,"balonzo",true,"Benjamin","Alonzo","balonzo@gmail.com"));
            //this.usuarios.Add(new Usuarios(3,"cherrera",))
        }

        public event PropertyChangedEventHandler PropertyChanged;
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
    }
}