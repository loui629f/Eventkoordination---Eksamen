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

namespace Eventkoordination___Eksamen
{
    /// <summary>
    /// Interaction logic for SletEvent.xaml
    /// </summary>
    public partial class SletEvent : Window
    {
        public SletEvent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SletEvent sletEvent = new SletEvent();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SletEvent sletEvent = new SletEvent();
            this.Close();
        }
    }
}
