using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
using Microsoft.Data.SqlClient;////////////////////////////////////////////////// 

namespace database_gui
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {

        // Connect String 
        public string Retrun_Connect_String()
        {
            string connStr = "server=194.87.210.23;" +
                                    "user=Sasha2;database=autoPodbor;password=Qazx1234;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = $"INSERT INTO ProcatUsers VALUES('0','{login.Text}', '{pass.Text}')";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            Debug.WriteLine(new string('-', 30));
            conn.Close();
            return connStr;
        }

        // RETURN connect string
        public async Task ConnectViaStringDTBAsync(string nameDatabase)
        {
            boxConnectInfo.Text = "asdfasdfasdfasdfasdf";
            if (string.IsNullOrEmpty(nameDatabase) == false)
            {
                // Создание подключения
                SqlConnection connection = new SqlConnection($"Server=(localdb)\\mssqllocaldb;Database={nameDatabase};User Id=shindows10;password=;TrustServerCertificate=True");
                try
                {
                    // Открываем подключение
                    await connection.OpenAsync();
                    boxConnectInfo.Text = "Подключение открыто";
                }
                catch (SqlException ex)
                {
                    boxConnectInfo.Text = ex.Message;
                }
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        // connect to database via name
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nameDatabase = textBoxNameDatabase.Text;
            ConnectViaStringDTBAsync(nameDatabase);
        }

        


    }
}
