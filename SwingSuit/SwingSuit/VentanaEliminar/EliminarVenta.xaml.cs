using MySql.Data.MySqlClient;
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

namespace SwingSuit.VentanaEliminar
{
    /// <summary>
    /// Lógica de interacción para EliminarVenta.xaml
    /// </summary>
    public partial class EliminarVenta : Window
    {
        public EliminarVenta()
        {
            InitializeComponent();
        }


        private void Anadir_Click(object sender, RoutedEventArgs e)
        {

            int ID,IdCliente;
            

            ID = Convert.ToInt32(id.Text);
            IdCliente = Convert.ToInt32(idCliente.Text);


            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT IdVenta,IdProducto,IdCliente,Cantidad FROM venta WHERE idVenta=" + ID + " AND IdCliente" + idCliente + ";";
            conn.Open();
            mostrar.ItemsSource = cmd.ExecuteReader();

        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {
            int ID, IdCliente;


            ID = Convert.ToInt32(id.Text);
            IdCliente = Convert.ToInt32(idCliente.Text);



            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM venta WHERE IdVenta="+ID+" AND IdCliente=" + idCliente + ";";
            cmd.ExecuteReader();
            conn.Close();
        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {
            VentanaVentas mp = new VentanaVentas();
            mp.Show();

            Close();

        }

    }
}
