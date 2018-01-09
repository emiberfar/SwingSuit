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
    /// Lógica de interacción para EliminarProducto.xaml
    /// </summary>
    public partial class EliminarProducto : Window
    {
        public EliminarProducto()
        {
            InitializeComponent();

            Conector.conexion();
        }

        private void Anadir_Click(object sender, RoutedEventArgs e)
        {

            int ID;
            string Nombre;

            ID = Convert.ToInt32(id.Text);
            Nombre = nombre.Text;


            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT p.Id,p.Marca,p.Tipo,p.Talla FROM producto as p,cliente as c, venta as v WHERE p.Id = v.IdProducto AND v.IdCliente = c.Id AND c.Id=" + ID + " AND c.Nombre='" + Nombre + "';";
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
            cmd.CommandText = "DELETE  FROM producto "+
                "WHERE Id IN (SELECT v.IdProducto FROM cliente as c, venta as v WHERE v.IdCliente=c.Id AND c.Id ="+ID+");";
            cmd.ExecuteReader();
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
