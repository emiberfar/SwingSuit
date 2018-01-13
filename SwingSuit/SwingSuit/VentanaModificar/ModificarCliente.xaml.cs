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
                cmd.CommandText = "UPDATE cliente SET Nombre='" + Nombre + "', Apellido ='" + Apellido + "', DNI='" + Dni + "', Direccion='" + Direccion + "', Telefono='" + Telefono + "' WHERE Id=" + ID + ";";
                cmd.ExecuteReader();
                conn.Close();

            if (existe(ID))
            {

                MessageBox.Show("Cliente modificado");

                id.Text = "";
                nombre.Text = "";
                apellido.Text = "";
                dni.Text = "";
                direccion.Text = "";
                telefono.Text = "";


            }
            else
            {
                MessageBox.Show("Cliente inexistente");

                id.Text = "";
                nombre.Text = "";
                apellido.Text = "";
                dni.Text = "";
                direccion.Text = "";
                telefono.Text = "";

            }


        }

        private void borrar_Click(object sender, RoutedEventArgs e)
        {


            EliminarCliente ec = new EliminarCliente();
            ec.Show();
            Close();

        }

        private void atras_Click(object sender, RoutedEventArgs e)
        {

            VentanaClientes mp = new VentanaClientes();
            mp.Show();

            Close();

        }

        private Boolean existe(int ID)
        {

            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "SELECT Id,Nombre,Apellido,DNI,Direccion,Telefono FROM cliente WHERE Id=@ID";
            cmd.Parameters.AddWithValue("ID",ID);
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
