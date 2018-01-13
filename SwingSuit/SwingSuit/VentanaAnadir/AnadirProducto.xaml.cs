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
using System.Windows.Forms;
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

            try
            {
                MySqlConnection conn = new MySqlConnection(Conector.conexion());
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO producto (Id,Marca,Tipo,Talla,StockActual,StockMinimo,PVP) " +
                    "VALUES " + "(" + ID + "," + "'" + Marca + "'," + "'" + Tipo + "'," + "'" + Talla + "'," + StockActual + "," + StockMinimo + "," + PVP + ");";
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                //se en carga de cuando exista un error el cual ba a ser que el cliente ya exise en la bd
                // te sale un mensaje


                System.Windows.MessageBox.Show("Ese producto que intenta añadir ya existe");
                id.Text = "";
                tipo.Text = "";
                talla.Text = "";
                stockActual.Text = "";
                stockMinimo.Text = "";
                pvp.Text = "";


            }
            catch (Exception ex)
            {

                Console.Write("Error no controlado" + ex.Message);

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


        //se encarga de que se puedadn introducir solo numeros en el id
        public void SoloNumeros(TextCompositionEventArgs e)
        {
            //se convierte a Ascci del la tecla presionada 
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            //verificamos que se encuentre en ese rango que son entre el 0 y el 9 
            if (ascci >= 48 && ascci <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



        private void id_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void pvp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("[^0-9.,-]+");
            e.Handled = regex.IsMatch(e.Text);

        }
    }
}
