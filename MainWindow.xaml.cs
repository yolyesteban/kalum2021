using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using kalum2021.Models;
using kalum2021.Views;

namespace kalum2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Saludar(Object sender, RoutedEventArgs e)
        {
            /*Student estudiante = new Student();
            estudiante.FirstName = "Juan Alberto";
            estudiante.LastName = "De Leon Pereira";
            estudiante.Email = "jalbertodp@gmail.com";
            estudiante.Birthday = new DateTime(1980,3,30);
            estudiante.Gender = "Masculino";
            estudiante.Phone = "24876395";
            estudiante.StudentId = "20210001";*/

            /*
            Teacher profesor = new Teacher();
            profesor.FirstName = "Raul Antonio";
            profesor.LastName = "Perez Polanco";
            profesor.Email = "raperez@gmail.com";
            profesor.Birthday = new DateTime(1972,01,01);
            profesor.Gender = "Masculino";
            profesor.Phone = "33124578";
            profesor.EmployeeId = "FK-0001";
            */
            Student estudiante = new Student("20210001","Juan Alberto","De Leon Pereira","raperez@gmail.com",new DateTime(1972,01,01),"Masculino","33124578");
            Teacher profesor = new Teacher("FK-0001","Raul Antonio","Perez Polanco","raperez@gmail.com",new DateTime(1972,01,01),"Masculino","33124578");

            MessageBox.Show(estudiante.ToString(),"Estudiante");
            MessageBox.Show(profesor.ToString(),"Profesor");

            MessageBox.Show("Hola mundo");
        }

        public void VentanaUsuarios(object sender, RoutedEventArgs e)
        {
            UsuariosView VentanaUsuarios = new UsuariosView();
            VentanaUsuarios.ShowDialog();
        }

        public void VentanaRoles(object sender, RoutedEventArgs e)
        {
            RoleView VentanaRoles = new RoleView();
            VentanaRoles.ShowDialog();
        }
    }
}
