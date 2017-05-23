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

namespace WpfApplication5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("btnClick");

            //e.Handled = true;
        }

        private void Grid_Click(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Grid_Click");
        }

        private void Grid_out_Click(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Grid_out_Click");
        }

        private void windowClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("windowClick");
        }
    }
}
