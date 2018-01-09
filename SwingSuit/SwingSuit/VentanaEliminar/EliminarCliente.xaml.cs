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

namespace SwingSuit.VentanaEliminar
{
    /// <summary>
    /// Lógica de interacción para EliminarCliente.xaml
    /// </summary>
    public partial class EliminarCliente : Window
    {
        public EliminarCliente()
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
            cmd.CommandText = "SELECT Id,Nombre,Apellido,DNI,Direccion,Telefono FROM cliente WHERE Id="+ID+" AND Nombre='"+Nombre+"';";
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
            cmd.CommandText = "DELETE FROM cliente WHERE Id =" +ID +" AND Nombre ='"+Nombre+ "';";
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
