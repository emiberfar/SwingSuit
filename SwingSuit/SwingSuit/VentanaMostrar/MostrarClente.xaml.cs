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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using SwingSuit.Ventanas;

namespace SwingSuit.VentanaMostrar
{
    /// <summary>
    /// Lógica de interacción para MostrarClente.xaml
    /// </summary>
    public partial class MostrarClente : Window
    {
       
       

        public MostrarClente()
        {
            InitializeComponent();
            
            

        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {


            
            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT Id,Nombre,Apellido,DNI,Direccion,Telefono FROM cliente";
            
            mostrar.ItemsSource = cmd.ExecuteReader();
            
            

        }

        private void Atras_Click(object sender, RoutedEventArgs e)
        {
            VentanaClientes mp = new VentanaClientes();
            mp.Show();
            Close();
        }
    }
}
