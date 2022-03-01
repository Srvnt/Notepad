using System;
using System.Collections.Generic;
using System.IO;
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


namespace Notepad
{
       public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Exit
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //Save as
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var sfd = new Microsoft.Win32.SaveFileDialog();
            sfd.FileName = "";
            sfd.Filter = "Text Document (.txt) | *.txt";
            sfd.Title = "Save File";
            if (sfd.ShowDialog() == true)
            {
                StreamWriter sw = new StreamWriter(File.Create(sfd.FileName));
                sw.Write(textbox.Text);
                sw.Dispose();
                
            }

        }
        //Open
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            var ofp = new Microsoft.Win32.OpenFileDialog();
            ofp.Title = "Open File";
            ofp.FileName = "";
            ofp.DefaultExt = ".txt";
            ofp.Filter = "Text Documents (.txt) | *.txt";
            if (ofp.ShowDialog() == true)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofp.FileName));
                textbox.Text = sr.ReadToEnd();
                sr.Dispose();
            }
            
            
        }
        //Print
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            var pfd = new PrintDialog();
            pfd.PageRangeSelection = PageRangeSelection.AllPages;
            pfd.UserPageRangeEnabled = true;
            if (pfd.ShowDialog() == true)
            {
                pfd.PrintVisual(textbox, "First Print");
            }
        }
        //Font
        public void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Font font = new Font();
            bool? DialogResult = font.ShowDialog();
            if (DialogResult == true)
            {
                int size = font.size;
                textbox.FontSize = size;
            }
           

        }
    }
}
