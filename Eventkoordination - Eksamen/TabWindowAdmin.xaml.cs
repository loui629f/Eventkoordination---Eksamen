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
	/// Interaction logic for TabWindowAdmin.xaml
	/// </summary>
	public partial class TabWindowAdmin : Window
	{
		public TabWindowAdmin()
		{
			InitializeComponent();
		}

        private void BtnClickSlet(object sender, RoutedEventArgs e)
        {
            SletEvent sletEvent = new SletEvent();
            sletEvent.Show();
        }

        private void BtnClickVagter(object sender, RoutedEventArgs e)
        {
            Vagt vagter = new Vagt();
            vagter.Show();
        }

        private void BtnClickOpretEvent(object sender, RoutedEventArgs e)
        {
            OpretEvent opretEvent = new OpretEvent();
            opretEvent.Show();
        }

        private void BtnClickKomment(object sender, RoutedEventArgs e)
        {

        }
    }
}
