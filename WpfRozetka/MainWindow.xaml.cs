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

namespace WpfRozetka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            i--; 

            if (i < 1)
            {
                i = 5;
            }
            Gallery.Source = new BitmapImage(new Uri(@"Images/" + i + ".jpg", UriKind.Relative));
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            i++; 

            if (i > 5)
            {
                i = 1;
            }

            Gallery.Source = new BitmapImage(new Uri(@"Images/" + i + ".jpg", UriKind.Relative));
        }
    }
}
