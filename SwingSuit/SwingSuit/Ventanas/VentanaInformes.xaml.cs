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

namespace SwingSuit.Ventanas
{
    /// <summary>
    /// Lógica de interacción para VentanaInformes.xaml
    /// </summary>
    public partial class VentanaInformes : Window
    {
        public VentanaInformes()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();

            Close();
        }

        private void Anadir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
