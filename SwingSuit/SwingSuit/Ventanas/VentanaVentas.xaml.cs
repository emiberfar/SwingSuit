using SwingSuit.VentanaAnadir;
using SwingSuit.VentanaEliminar;
using SwingSuit.VentanaModificar;
using SwingSuit.VentanaMostrar;
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

namespace SwingSuit
{
    /// <summary>
    /// Lógica de interacción para VentanaVentas.xaml
    /// </summary>
    public partial class VentanaVentas : Window
    {
        public VentanaVentas()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, RoutedEventArgs e)
        {

            MostrarVentas mv = new MostrarVentas();
            mv.Show();
            Close();
        }

        private void buttonModificar_Click(object sender, RoutedEventArgs e)
        {

            ModificarVenta mv = new ModificarVenta();
            mv.Show();
            Close();

        }

        private void buttonEliminar_Click(object sender, RoutedEventArgs e)
        {

            EliminarVenta ev = new EliminarVenta();
            ev.Show();
            Close();


        }

        private void buttonAñadir_Click(object sender, RoutedEventArgs e)
        {

            AnadirVenta av = new AnadirVenta();
            av.Show();
            Close();

        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {

            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            Close();

        }
    }
}
