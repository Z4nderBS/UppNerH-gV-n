using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace UppNerHögVän
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                   
                    var link1 = new ProcessStartInfo
                    {
                        FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                        UseShellExecute = true
                    };
                    Process.Start(link1);

                    break;
                case Key.Down:
                    var link2 = new ProcessStartInfo
                    {
                        FileName = "https://www.youtube.com/watch?v=ioRhanH4xmE",
                        UseShellExecute = true
                    };
                    Process.Start(link2);
                    break;
                case Key.Left:
                    var link3 = new ProcessStartInfo
                    {
                        FileName = "https://www.youtube.com/watch?v=oGjk4XZU06k",
                        UseShellExecute = true
                    };
                    Process.Start(link3);
                    break;
                case Key.Right:
                    var link4 = new ProcessStartInfo
                    {
                        FileName = "https://www.youtube.com/watch?v=LeZ3EAFgPr8",
                        UseShellExecute = true
                    };
                    Process.Start(link4);
                    break;

            }
        }

     
    }
}
