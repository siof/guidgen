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

namespace binding_tst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Txt = "{0}";
            DataContext = this;
            InitializeComponent();
            DataContext = this;
        }

        public string Txt { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtBox.Text += (string.Format(Txt, Guid.NewGuid()) + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Txt += " ||| Exception: " + ex.Message;
            }
        }
    }
}
