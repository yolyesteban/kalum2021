using System.Windows;
using kalum2021.ModelView;

namespace kalum2021.Views
{
    public partial class RolView : Window
    {
        public RolView(RolesViewModel RolViewModel)
        {
            InitializeComponent();
            RolViewModel Modelo = new RolViewModel(RolViewModel);
            this.DataContext = Modelo;
        }
    }
}