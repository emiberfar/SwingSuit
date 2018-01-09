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
    /// Lógica de interacción para AnadirCliente.xaml
    /// </summary>
    public partial class AnadirCliente : Window
    {
        public AnadirCliente()
        {
            InitializeComponent();
            Conector.conexion();

        }



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
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO cliente (Id,Nombre,Apellido,DNI,Direccion,Telefono) " +
                "VALUES " + "(" + ID + "," + "'" + Nombre + "'," + "'" + Apellido + "'," + "'" + Dni + "'," + "'" + Direccion + "'," + "'" + Telefono + "');";
            cmd.ExecuteReader();
            conn.Close();
           



        }

        private void borrar_Click(object sender, RoutedEventArgs e)
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
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM cliente WHERE " + "id =" + ID + " AND " + "Nombre ='" + Nombre + "' AND " + "Apellido ='" + Apellido + "' AND DNI=" + "'" + Dni + "' AND Direccion=" + "'" + Direccion + "' AND Telefono=" + "'" + Telefono + "';";
            cmd.ExecuteReader();
            conn.Close();





        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {

            VentanaClientes mp = new VentanaClientes();
            mp.Show();

            Close();

        }
    }
}
