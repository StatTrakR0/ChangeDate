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

namespace ChangeDate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            string changeDate_1;
            string changeDate_2;
            string dateTb_1 = tb_1.Text;
            string dateTb_2 = tb_2.Text;
            if (tb_1.Text == "" && tb_2.Text == "")
            {
                MessageBox.Show("At least one field must contain text!");
            }
            changeDate_1 = dateTb_1;
            changeDate_2 = dateTb_2;
            tb_1.Text = changeDate_2;
            tb_2.Text = changeDate_1;



        }

        private void tb_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tb_2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to do that?",
        "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
    
}
