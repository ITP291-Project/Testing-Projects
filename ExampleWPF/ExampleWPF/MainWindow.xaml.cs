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

namespace ExampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = -1;
        private String[] text = { "Hello From C#", "These strings are drawn from C# code", "This is the last string in the array" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            txtHello.Text = " ";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            txtHello.Text = text[counter];
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            counter--;
            txtHello.Text = text[counter];
        }
    }
}
