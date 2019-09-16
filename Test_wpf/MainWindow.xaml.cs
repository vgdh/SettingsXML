using SettingsXML_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Test_wpf.Properties;

namespace Test_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly SettingsXML _settings = new SettingsXML("Settings.xml");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = _settings.TestString;
            CheckBox1.IsChecked = _settings.UpdeteIsEnable;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _settings.TestString = TextBox1.Text;
            _settings.UpdeteIsEnable = CheckBox1.IsChecked.Value;

        }
    }
}
