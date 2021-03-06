﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

namespace Transport
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds; 

        public MainWindow()
        {
            
            InitializeComponent();



        }

        private void Windows_Load (object sender, RoutedEventArgs e)
        {
            da = new SqlDataAdapter("Select * from ACTi_RMA", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SQLiteConnection.CreateFile("D:\\data.db");
            string databaseName = @"D:\\data.db";
        }
    }
}
