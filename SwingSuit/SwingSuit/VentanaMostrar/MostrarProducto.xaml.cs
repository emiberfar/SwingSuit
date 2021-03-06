﻿using MySql.Data.MySqlClient;
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

namespace SwingSuit.VentanaMostrar
{
    /// <summary>
    /// Lógica de interacción para MostrarProducto.xaml
    /// </summary>
    public partial class MostrarProducto : Window
    {
        public MostrarProducto()
        {
            InitializeComponent();
            
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {



            MySqlConnection conn = new MySqlConnection(Conector.conexion());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id,Marca,Tipo,Talla,StockActual,StockMminimo,PVP FROM producto";
            conn.Open();
            mostrar.ItemsSource = cmd.ExecuteReader();



        }

        private void Atras_Click(object sender, RoutedEventArgs e)
        {
            VentanaProductos mp = new VentanaProductos();
            mp.Show();
            Close();
        }
    }
}
