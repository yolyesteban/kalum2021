using System.Collections.ObjectModel;
using System.ComponentModel;
using kalum2021.Models;

namespace kalum2021.ModelView
{
    public class RoleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Role> roles {get;set;}

        public RoleViewModel()
        {
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
    }
}