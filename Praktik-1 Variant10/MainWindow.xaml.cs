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
using static System.Math;

namespace Praktik_1_Variant10
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


        private void But_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(TexA.Text);
            double b = Convert.ToDouble(TexB.Text);
            double c = Sqrt(a * b);
            TexA.Text += "\n" + "a=" + a;
            TexB.Text += "\n" + "a=" + b;
            TexRe.Text += "\n" + "Cреднее:" + c;
        }
    }
}
