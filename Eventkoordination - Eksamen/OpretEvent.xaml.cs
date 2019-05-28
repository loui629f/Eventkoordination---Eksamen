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
using ApplicationLayer;

namespace UI
{
    /// <summary>
    /// Interaction logic for OpretEvent.xaml
    /// </summary>
    public partial class OpretEvent : Window
    {
		Controller controller = new Controller();
		
        public OpretEvent()
        {
            InitializeComponent();
        }

        private void BtnClickEmail(object sender, RoutedEventArgs e)
        {

			controller.CreateEventAdmin(TxtEventNavn.Text, Convert.ToDateTime(TxtEventDato.Text), TxtEventBeskrivelse.Text);
			TxtEventNavn.Text = string.Empty;
			TxtEventDato.Text = string.Empty;
			TxtEventBeskrivelse.Text = string.Empty;

            
        }

        private void BtnClickAnnuller(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnClickLuk(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


	}
}
