using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorDialogWPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowsFormsHost host = new WindowsFormsHost();
            
            var colorChoice = new System.Windows.Forms.Button();
            colorChoice.MouseClick += ColorChoice_MouseClick;
            host.Child = colorChoice;
            this.myPanel.Children.Add(host);
        }

        private void ColorChoice_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            var button = (System.Windows.Forms.Button)sender;
            ColorDialog colorDialog = new ColorDialog();
            var dr = colorDialog.ShowDialog();
            var color = colorDialog.Color;
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                button.BackColor = color;
            }
        }
    }
}
