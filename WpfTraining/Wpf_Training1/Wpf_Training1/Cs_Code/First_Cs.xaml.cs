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

namespace Wpf_Training1.Cs_Code
{
    /// <summary>
    /// Interaction logic for First_Cs.xaml
    /// </summary>
    public partial class First_Cs : Window
    {
        public First_Cs()
        {
            InitializeComponent();
        }

        private void First_Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi this is first Button");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi this is second Button");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            First_Cs_window.Name = "Hi Madhumitha!";
        }
    }
}
