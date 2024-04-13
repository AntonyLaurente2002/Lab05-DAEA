using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace lab05
{
    public partial class MainWindow : Window
    {
        public string connectionString = "Data Source=LAB1504-18\\SQLEXPRESS01;Initial Catalog=NeptunoDB;User Id=antony;Password=123456";
        public List<Clientes> ListaClientes { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ListaClientes = new List<Clientes>();
            dataClientes.ItemsSource = ListaClientes;
        }

        private void Button_Insertar(object sender, RoutedEventArgs e)
        {
            // Tu código para insertar un nuevo cliente aquí
        }

        private void Button_Listar(object sender, RoutedEventArgs e)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ListarClientes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string idCliente = reader.GetString(reader.GetOrdinal("idCliente"));
                                string nombreCompañia = reader.GetString(reader.GetOrdinal("NombreCompañia"));
                                string nombreContacto = reader.GetString(reader.GetOrdinal("NombreContacto"));
                                string cargoContacto = reader.GetString(reader.GetOrdinal("CargoContacto"));
                                string direccion = reader.GetString(reader.GetOrdinal("Direccion"));
                                string ciudad = reader.GetString(reader.GetOrdinal("Ciudad"));
                                string pais = reader.GetString(reader.GetOrdinal("Pais"));
                                string telefono = reader.GetString(reader.GetOrdinal("Telefono"));

                                clientes.Add(new Clientes(idCliente, nombreCompañia, nombreContacto, cargoContacto, direccion, ciudad, pais, telefono));
                            }
                        }
                    }
                }

                dataClientes.ItemsSource = clientes;
                dataClientes.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
