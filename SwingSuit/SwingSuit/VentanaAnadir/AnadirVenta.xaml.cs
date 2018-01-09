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

            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO venta (idVenta,IdProducto,IdCliente,Cantidad)" +
                " VALUES ("+IdVenta+","+idProducto+","+IdCliente+","+Cantidad+");";
            cmd.ExecuteReader();
            conn.Close();




        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {


            int IdVenta, IdProducto, IdCliente, Cantidad;


            IdVenta = Convert.ToInt32(id.Text);
            IdProducto = Convert.ToInt32(idProducto.Text);
            IdCliente = Convert.ToInt32(idCliente.Text);
            Cantidad = Convert.ToInt32(cantidad.Text);


            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM venta WHERE " + "IdVenta =" + IdVenta + " IdProducto = " + idProducto + " AND " + "IdCliente = " + IdCliente + " AND Cantidad = " + Cantidad + "; ";
            conn.Close();



        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {

            VentanaProductos mp = new VentanaProductos();
            mp.Show();

            Close();

        }
    }
}
