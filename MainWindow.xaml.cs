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
using _1DataSetLab.RecordingStudioDataSetTableAdapters;

namespace _1DataSetLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientsTableAdapter clients = new ClientsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ClientsDataGrid.ItemsSource = clients.GetData();
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            this.Close();
            window2.Show();
        }
    }
}
