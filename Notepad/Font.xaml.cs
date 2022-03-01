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
using System.IO;

namespace Notepad
{
    
    public partial class Font : Window
    {
        
        public Font()
        {
            InitializeComponent();
        }
        public int size;

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            bool isNumber = int.TryParse(fontSize.Text,out size);
        }
        
        
        //Cancel
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
