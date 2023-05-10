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
using System.Windows.Shapes;

namespace Informatik_Eksam_Projekt
{
    /// <summary>
    /// Interaction logic for testwindow.xaml
    /// </summary>
    public partial class testwindow : Window
    {
        public testwindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            TextBlock text1 = new TextBlock();
            text1.Text = "man";
            stackPanel.Children.Add(text1);

            TextBlock text2 = new TextBlock();
            text2.Text = "what";
            stackPanel.Children.Add(text2);

            TextBlock text3 = new TextBlock();
            text3.Text = "fuck";
            stackPanel.Children.Add(text3);

            TextBlock text4 = new TextBlock();
            text4.Text = firstNametext.Text;
            stackPanel.Children.Add(text4);
        }
    }
}
