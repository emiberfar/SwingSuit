using MySql.Data.MySqlClient;
using SwingSuit.Ventanas;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SwingSuit
{
 
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void Cliente_Click(object sender, RoutedEventArgs e)
        {
            VentanaClientes vc = new VentanaClientes();
            vc.Show();
            Close();

        }

        private void Ventas_Click(object sender, RoutedEventArgs e)
        {

            VentanaVentas vv = new VentanaVentas();
            vv.Show();
            Close();

        }

        private void Producto_Click(object sender, RoutedEventArgs e)
        {

            VentanaProductos vp = new VentanaProductos();
            vp.Show();
            Close();

        }
    }
}
