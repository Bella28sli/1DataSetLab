using _1DataSetLab.RecordingStudioDataSetTableAdapters;
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

namespace _1DataSetLab
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        Staff_ChoiceTableAdapter staffchoice = new Staff_ChoiceTableAdapter();
        public Window3()
        {
            InitializeComponent();
            StaffChoiceDataGrid.ItemsSource = staffchoice.GetData();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }
    }
}
