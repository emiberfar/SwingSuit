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

            int ID;
            string Nombre;

            ID = Convert.ToInt32(id.Text);
            Nombre = nombre.Text;

            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT v.IdVenta,v.IdProducto,v.IdCliente,v.Cantidad FROM venta as v, cliente as c WHERE v.IdCliente=c.Id AND c.Id=" + ID + " AND c.Nombre='" + Nombre + "';";
            conn.Open();
            mostrar.ItemsSource = cmd.ExecuteReader();

        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {
            int ID;
            string Nombre;

            ID = Convert.ToInt32(id.Text);
            Nombre = nombre.Text;



            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM venta WHERE IdCliente IN(SELECT Id FROM  cliente as c WHERE c.Id=" + ID + " AND c.Nombre='" + Nombre + "')";
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
