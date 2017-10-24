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

namespace ChangeTheme
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

        private void Light_Click(object sender, RoutedEventArgs e)
        {
            this.Resources = new ResourceDictionary { Source = new Uri(@"C:\Users\СагадиевЕ\Documents\Visual Studio 2017\Projects\ChangeTheme\ChangeTheme\LightThemeDictionary.xaml") };
        }
        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            this.Resources = new ResourceDictionary { Source = new Uri(@"C:\Users\СагадиевЕ\Documents\Visual Studio 2017\Projects\ChangeTheme\ChangeTheme\DarkThemeDictionary.xaml") };
        }
        private void Mine_Click(object sender, RoutedEventArgs e)
        {
            this.Resources = new ResourceDictionary { Source = new Uri(@"C:\Users\СагадиевЕ\Documents\Visual Studio 2017\Projects\ChangeTheme\ChangeTheme\mineThemeDictionary.xaml") };
        }
    }
}
