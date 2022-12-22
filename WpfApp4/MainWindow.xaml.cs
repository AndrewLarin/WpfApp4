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

namespace WpfApp4
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate5.Text);
            double sum = Convert.ToDouble(sum1.Text);
            double res = sum * rate;
            res1.Text = res.ToString();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate6.Text);
            double sum = Convert.ToDouble(sum2.Text);
            double res = sum * rate;
            res2.Text = res.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate7.Text);
            double sum = Convert.ToDouble(sum3.Text);
            double res = sum * rate;
            res3.Text = res.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rate8.Text);
            double sum = Convert.ToDouble(sum4.Text);
            double res = sum * rate;
            res4.Text = res.ToString();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            double distance = Convert.ToDouble(distance1.Text);
            double res = distance*0.7112;
            res5.Text = res.ToString();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            double distance = Convert.ToDouble(distance2.Text);
            double res = distance * 0.305;
            res6.Text = res.ToString();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            double distance = Convert.ToDouble(distance3.Text);
            double res = distance * 25.4;
            res7.Text = res.ToString();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            double distance = Convert.ToDouble(distance4.Text);
            double res = distance * 0.621;
            res8.Text = res.ToString();
        }
    }
}
