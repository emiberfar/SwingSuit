using MySql.Data.MySqlClient;
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

namespace SwingSuit.VentanaModificar
{
    /// <summary>
    /// Lógica de interacción para ModificarVenta.xaml
    /// </summary>
    public partial class ModificarVenta : Window
    {
        public ModificarVenta()
        {
            InitializeComponent();
            Conector.conexion();
        }


        private void Anadir_Click(object sender, RoutedEventArgs e)
        {


            int IdVenta,IdProducto,IdCliente,Cantidad;


            IdVenta = Convert.ToInt32(id.Text);
            IdProducto = Convert.ToInt32(idProducto.Text);
            IdCliente = Convert.ToInt32(idCliente.Text);
            Cantidad = Convert.ToInt32(cantidad.Text);

            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE venta" +
                " SET" + " IdProducto = " + IdProducto + " AND IdCliente= " + IdCliente + " AND Cantidad=" + Cantidad +
                " WHERE " + "IdVenta =" + IdVenta + ";";
            cmd.ExecuteReader();
            conn.Close();


            if (existe(IdVenta))
            {

                MessageBox.Show("Venta modificado");

                id.Text = "";
                idCliente.Text = "";
                idProducto.Text = "";
                cantidad.Text = "";
               

            }
            else
            {
                MessageBox.Show("Venta inexistente");

                id.Text = "";
                idCliente.Text = "";
                idProducto.Text = "";
                cantidad.Text = "";
            }


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
            cmd.CommandText = "DELETE FROM venta WHERE " + "IdVenta =" + IdVenta + " IdProducto = " + IdProducto + " , " + "IdCliente = " + IdCliente + " AND Cantidad = " + Cantidad + "; ";
            conn.Close();

        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {

            VentanaVentas mp = new VentanaVentas();
            mp.Show();

            Close();

        }


        private Boolean existe(int ID)
        {

            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT IdVenta,IdProducto,IdCliente,Cantidad FROM venta WHERE IdVenta =@ID";
            cmd.Parameters.AddWithValue("ID", ID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteReader();
            conn.Close();


            if (count == 0)
                return false;
            else
                return true;

        }

        private void id_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }
    }
}
