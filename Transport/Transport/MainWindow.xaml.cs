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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;



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
# cn = new SqlConnection(@"Data Source = DEMIAN - NB\VIDEOOSDB; Initial Catalog = rma; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
# cn.Open();


        }

        private void Windows_Load (object sender, RoutedEventArgs e)
        {
            da = new SqlDataAdapter("Select * from ACTi_RMA", cn);
            ds = new DataSet();
            da.Fill(ds);
            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}
