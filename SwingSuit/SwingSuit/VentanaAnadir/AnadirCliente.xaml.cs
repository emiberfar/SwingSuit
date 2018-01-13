using MySql.Data.MySqlClient;
using SwingSuit.VentanaEliminar;
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
    /// Lógica de interacción para AnadirCliente.xaml
    /// </summary>
    public partial class AnadirCliente : Window
    {
        public AnadirCliente()
        {
            InitializeComponent();
            Conector.conexion();

        }


        // añade un cliente a la base de datos
        private void Anadir_Click(object sender, RoutedEventArgs e)
        {



            int ID;
            string Nombre, Apellido, Dni, Direccion, Telefono;

            ID = Convert.ToInt32(id.Text);
            Nombre = nombre.Text;
            Apellido = apellido.Text;
            Dni = dni.Text;
            Direccion = direccion.Text;
            Telefono = telefono.Text;


            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();


            try
            {

                conn.Open();
                cmd.CommandText = "INSERT INTO cliente (Id,Nombre,Apellido,DNI,Direccion,Telefono) " +
                    "VALUES " + "(" + ID + "," + "'" + Nombre + "'," + "'" + Apellido + "'," + "'" + Dni + "'," + "'" + Direccion + "'," + "'" + Telefono + "');";
                cmd.ExecuteReader();
                conn.Close();


                MessageBox.Show("Cliente añadido");
                id.Text = "";
                nombre.Text = "";
                apellido.Text = "";
                dni.Text = "";
                direccion.Text = "";
                telefono.Text = "";

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {

                //se en carga de cuando exista un error el cual ba a ser que el cliente ya exise en la bd
                // te sale un mensaje


                MessageBox.Show("Ese cliente que intenta añadir ya existe");
                id.Text = "";
                nombre.Text = "";
                apellido.Text = "";
                dni.Text = "";
                direccion.Text = "";
                telefono.Text = "";


            }
            catch (Exception ex) {

                Console.Write("Error no controlado" + ex.Message);

            }
            
           



        }

        //te lleva ala ventana de elimiar cliente
        private void borrar_Click(object sender, RoutedEventArgs e)
        {

            EliminarCliente ec = new EliminarCliente();
                ec.Show();
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

        private void atras_Click(object sender, RoutedEventArgs e)
        {

            VentanaClientes mp = new VentanaClientes();
            mp.Show();

            Close();

        }


    }
}
