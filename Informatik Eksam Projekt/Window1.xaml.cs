using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Diagnostics;

namespace Informatik_Eksam_Projekt
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void openFileButton(object sender, RoutedEventArgs e)
        {
            List<TextBlock> textBlocks = new List<TextBlock>();
            List<TextBlock> textBlocks1 = new List<TextBlock>();
            
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                Trace.Write(ofd.FileName);
                string[] lines = File.ReadAllLines(ofd.FileName);
                List<string[]> csvFile = new List<string[]>();
                foreach (string line in lines)
                {
                    csvFile.Add(line.Split(','));
                }
                for (int i = 0; i < csvFile.Count; i++)
                {
                    textBlocks.Add(new TextBlock());
                    textBlocks[i].Text = csvFile[i][0];
                    textBlocks[i].FontSize = 30;
                    stkPnl.Children.Add(textBlocks[i]);
                    stkPnl.Children.Add(new Separator());
                }
                for (int i = 0; i < csvFile.Count; i++)
                {
                    textBlocks1.Add(new TextBlock());
                    textBlocks1[i].Text = csvFile[i][1];
                    textBlocks1[i].FontSize = 30;
                    stkPnl2.Children.Add(textBlocks1[i]);
                    stkPnl2.Children.Add(new Separator());
                }
            }
        }
    }
}
