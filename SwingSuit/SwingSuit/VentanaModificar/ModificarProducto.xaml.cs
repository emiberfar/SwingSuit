using MySql.Data.MySqlClient;
using SwingSuit.VentanaEliminar;
using SwingSuit.Ventanas;
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
    /// Lógica de interacción para ModificarProducto.xaml
    /// </summary>
    public partial class ModificarProducto : Window
    {
        public ModificarProducto()
        {
            InitializeComponent();

            Conector.conexion();
        }

        private void Anadir_Click(object sender, RoutedEventArgs e)
        {



            int ID,StockMinimo,StockActual;
            double PVP;
            string Marca, Tipo, Talla;

            ID = Convert.ToInt32(id.Text);
            Marca = marca.Text;
            Tipo = tipo.Text;
            Talla = talla.Text;
            StockActual = Convert.ToInt32(stockActual.Text);
            StockMinimo = Convert.ToInt32(stockMinimo.Text);
            PVP = Convert.ToDouble(pvp.Text);

            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE producto" +
                " SET" + " Marca = '" + Marca + "', " + "Tipo = '" + Tipo + "', Talla = " + "'" + Talla + "', StockActual = " + StockActual + ", StockMinimo = " + StockMinimo + ", PVP="+ PVP +
                " WHERE " + "Id =" + ID + ";";
            cmd.ExecuteReader();
            conn.Close();

            if (existe(ID))
            {

                MessageBox.Show("Producto modificado");

                id.Text = "";
                marca.Text = "";
                tipo.Text = "";
                talla.Text = "";
                stockActual.Text = "";
                stockMinimo.Text = "";
                pvp.Text = "";

            }
            else
            {
                MessageBox.Show("Producto inexistente");

                id.Text = "";
                marca.Text = "";
                tipo.Text = "";
                talla.Text = "";
                stockActual.Text = "";
                stockMinimo.Text = "";
                pvp.Text = "";
            }



        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {

            EliminarProducto ep = new EliminarProducto();
            ep.Show();
            Close();

        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {

            VentanaProductos mp = new VentanaProductos();
            mp.Show();

            Close();

        }

        private Boolean existe(int ID)
        {

            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT Id,Marca,Tipo,Talla,StockActual,StockMminimo,PVP FROM producto WHERE Id =@ID";
            cmd.Parameters.AddWithValue("ID", ID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteReader();
            conn.Close();


            if (count == 0)
                return false;
            else
                return true;

        }

        private void stockMinimo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void pvp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("[^0-9.,]+");
            e.Handled = regex.IsMatch(e.Text);

        }

    }
}
