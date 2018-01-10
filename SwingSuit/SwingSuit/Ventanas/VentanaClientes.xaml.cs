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
using System.Windows.Shapes;
using SwingSuit.VentanaMostrar;
using SwingSuit.VentanaModificar;
using SwingSuit.VentanaEliminar;
using SwingSuit.VentanaAnadir;

namespace SwingSuit.Ventanas
{
    /// <summary>
    /// Lógica de interacción para VentanaClientes.xaml
    /// </summary>
    public partial class VentanaClientes : Window
    {
        public VentanaClientes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();

            Close();
        }

        private void Button_Mostrar(object sender, RoutedEventArgs e)
        {

            MostrarClente mc = new MostrarClente();
            mc.Show();
            Close();

        }

        private void Modificar(object sender, RoutedEventArgs e)
        {
            ModificarCliente mc = new ModificarCliente();
            mc.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            EliminarCliente ec = new EliminarCliente();
            ec.Show();
            Close();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            AnadirCliente ac = new AnadirCliente();
            ac.Show();
            Close();
        }

        private void Button_report(object sender, RoutedEventArgs e)
        {

            Window1 w = new Window1();
            w.Show();
        }
    }
}
