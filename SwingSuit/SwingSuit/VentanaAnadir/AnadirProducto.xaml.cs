using MySql.Data.MySqlClient;
using SwingSuit.Ventanas;
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
    /// Lógica de interacción para AnadirProducto.xaml
    /// </summary>
    public partial class AnadirProducto : Window
    {
        public AnadirProducto()
        {
            InitializeComponent();

            Conector.conexion();
        }




        private void Anadir_Click(object sender, RoutedEventArgs e)
        {



            int ID, StockMinimo, StockActual;
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
            cmd.CommandText = "INSERT INTO producto (Id,Marca,Tipo,Talla,StockActual,StockMinimo,PVP) " +
                "VALUES " + "(" + ID + "," + "'" + Marca + "'," + "'" + Tipo + "'," + "'" + Talla + "'," + StockActual + "," + StockMinimo +","+PVP+ ");";
            cmd.ExecuteReader();
            conn.Close();




        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {


            int ID, StockMinimo, StockActual;
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
            cmd.CommandText = "DELETE FROM producto WHERE " + "Id =" + ID + " Marca = '" + Marca + "' AND " + "Tipo = '" + Tipo + "' AND Talla = " + "'" + Talla + "' AND StockActual = " + StockActual + " AND StockMinimo = " + StockMinimo + " AND PVP=" + PVP +"; ";
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
