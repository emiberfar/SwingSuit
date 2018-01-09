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

namespace SwingSuit.VentanaModificar
{
    /// <summary>
    /// Lógica de interacción para ModificarCliente.xaml
    /// </summary>
    public partial class ModificarCliente : Window
    {
        public ModificarCliente()
        {
            InitializeComponent();
            Conector.conexion();
        }






        private void Anadir_Click(object sender, RoutedEventArgs e)
        {

            

            int ID;
            string Nombre, Apellido, Dni, Direccion,Telefono;

            ID = Convert.ToInt32(id.Text);
            Nombre = nombre.Text;
            Apellido = apellido.Text;
            Dni = dni.Text;
            Direccion = direccion.Text;
            Telefono = telefono.Text;


            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE cliente" +
                " SET" + " Nombre = '" + Nombre + "' AND " + "Apellido = '" + Apellido + "' AND DNI = " + "'" + Dni + "' AND Direccion = " + "'" + Direccion + "' AND Telefono = " + "'" + Telefono +"'"+
                " WHERE " + "Id =" + ID + ";";
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
            cmd.CommandText = "DELETE FROM cliente WHERE " + "Id =" + ID + " AND" + "Nombre ='" + Nombre + "' AND " + "Apellido ='" + Apellido + "' AND DNI=" + "'" + Dni + "' AND Direccion=" + "'" + Direccion + "' AND Telefono=" + "'" + Telefono + "';";
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
