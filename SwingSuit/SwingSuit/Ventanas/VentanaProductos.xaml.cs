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
    /// Lógica de interacción para VentanaProductos.xaml
    /// </summary>
    public partial class VentanaProductos : Window
    {
        public VentanaProductos()
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

            MostrarProducto mc = new MostrarProducto();
            mc.Show();
            Close();

        }

        private void boton_Modificar(object sender, RoutedEventArgs e)
        {
            ModificarProducto mc = new ModificarProducto();
            mc.Show();
            Close();
        }

        private void Button_Eliminar(object sender, RoutedEventArgs e)
        {

            EliminarProducto ec = new EliminarProducto();
            ec.Show();
            Close();


        }

        private void Anadir_boton(object sender, RoutedEventArgs e)
        {

            AnadirProducto ac = new AnadirProducto();
            ac.Show();
            Close();
        }

      
    }
}
