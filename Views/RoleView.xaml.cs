using kalum2021.ModelView;
using System.Windows;

namespace kalum2021.Views
{
    public partial class RoleView : Window
    {
        public RoleView()
        {
            InitializeComponent();
            RoleViewModel ModeloDatos = new RoleViewModel();
            this.DataContext = ModeloDatos;            
        }
    }
}