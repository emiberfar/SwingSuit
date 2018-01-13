using MySql.Data.MySqlClient;
using SwingSuit.VentanaEliminar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SwingSuit.VentanaAnadir
{
    /// <summary>
    /// Lógica de interacción para AnadirVenta.xaml
    /// </summary>
    public partial class AnadirVenta : Window
    {
        public AnadirVenta()
        {
            InitializeComponent();
            Conector.conexion();
        }

        private void Anadir_Click(object sender, RoutedEventArgs e)
        {

            int IdVenta, IdProducto, IdCliente, Cantidad;


            IdVenta = Convert.ToInt32(id.Text);
            IdProducto = Convert.ToInt32(idProducto.Text);
            IdCliente = Convert.ToInt32(idCliente.Text);
            Cantidad = Convert.ToInt32(cantidad.Text);

            try
            {
                MySqlConnection conn = new MySqlConnection(Conector.conexion());
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO venta (idVenta,IdProducto,IdCliente,Cantidad)" +
                    " VALUES (" + IdVenta + "," + idProducto + "," + IdCliente + "," + Cantidad + ");";
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                //se en carga de cuando exista un error el cual ba a ser que el cliente ya exise en la bd
                // te sale un mensaje


                System.Windows.MessageBox.Show("Esa venta que intenta añadir ya existe");
                id.Text = "";
                idProducto.Text = "";
                idCliente.Text = "";
                cantidad.Text = "";
                


            }
            catch (Exception ex)
            {

                Console.Write("Error no controlado" + ex.Message);

            }
        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {

            EliminarVenta ev = new EliminarVenta();
            ev.Show();
            Close();

        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {

            VentanaVentas mp = new VentanaVentas();
            mp.Show();

            Close();

        }

        private void id_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }



    }
}
