using System.Windows;
using kalum2021.ModelView;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace kalum2021.Views
{
    public partial class UsuarioView : MetroWindow
    {
        public UsuarioView(UsuariosViewModel UsuarioViewModel)
        {
            InitializeComponent();
            UsuarioViewModel Modelo = new UsuarioViewModel(UsuarioViewModel,DialogCoordinator.Instance);
            this.DataContext = Modelo;
        }
        
    }
}