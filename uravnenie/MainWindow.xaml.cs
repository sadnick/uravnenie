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

namespace uravnenie
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            double c = Convert.ToDouble(TextBox3.Text);
            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                TextBox4.Text = "Дискриминант меньше нуля. Корней нет.";
            }

            if (d == 0)
            {
                double x = (-b / (2 * a));
                TextBox4.Text = "Дискриминант равен нулю. Корень равен " + x + ".";                
            }

            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                TextBox4.Text = "Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".";                
            }            
        }
    }
}
