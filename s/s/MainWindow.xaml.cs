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

namespace s
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

        private void Вычислить_Click(object sender, RoutedEventArgs e)
        {
            double b1 = Convert.ToDouble(base1.Text);
            double b2 = Convert.ToDouble(base2.Text);
            double hh = Convert.ToDouble(h.Text);
            double ss = (b1 + b2) * hh / 2;
            s.Text = Convert.ToString(ss);
        }
    }
}
