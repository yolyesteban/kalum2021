using kalum2021.ModelView;
using System.Windows;
using MahApps.Metro.Controls;

namespace kalum2021.Views
{
    public partial class RolesView : MetroWindow
    {
        public RolesView()
        {
            InitializeComponent();
            RolesViewModel ModeloDatos = new RolesViewModel();
            this.DataContext = ModeloDatos;            
        }
    }
}