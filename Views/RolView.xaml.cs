using System.Windows;
using kalum2021.ModelView;
using MahApps.Metro.Controls;

namespace kalum2021.Views
{
    public partial class RolView : MetroWindow
    {
        public RolView(RolesViewModel RolViewModel)
        {
            InitializeComponent();
            RolViewModel Modelo = new RolViewModel(RolViewModel);
            this.DataContext = Modelo;
        }
    }
}