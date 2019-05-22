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
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
using System.Collections.ObjectModel;
using ApplicationLayer;


namespace UI
{
    /// <summary>
    /// Interaction logic for TabWindowAdmin.xaml
    /// </summary>
    public partial class TabWindowAdmin : Window
    {

		public Controller controller = new Controller();
		public EventRepository EventRepository = new EventRepository();


		public TabWindowAdmin()
        {
            InitializeComponent();


        }
		private void RichTextBox_TextChanged(object sender, EventArgs e)
		{
			
		}
		private void BtnClickSlet(object sender, RoutedEventArgs e)
        {
            SletEvent sletEvent = new SletEvent();
            sletEvent.Show();
        }
        private void BtnClickVagter(object sender, RoutedEventArgs e)
        {
            Shift vagter = new Shift();
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
        private void BtnClickSlet2(object sender, RoutedEventArgs e)
        {
            SletEvent sletEvent = new SletEvent();
            sletEvent.Show();
        }
        private void BtnClickVagter2(object sender, RoutedEventArgs e)
        {
            Shift vagter = new Shift();
            vagter.Show();
        }
        private void BtnClickKomment2(object sender, RoutedEventArgs e)
        {

        }
        private void BtnClickSlet3(object sender, RoutedEventArgs e)
        {
            SletEvent sletEvent = new SletEvent();
            sletEvent.Show();
        }
        private void BtnClickVagter3(object sender, RoutedEventArgs e)
        {
           Shift vagter = new Shift();
            vagter.Show();
        }
        private void BtnClickKomment3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

		private void NewsfeedDatePicker_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
		{
			EventRepository eventRepo = new EventRepository();

			string d;
			string s;
			d = NewsfeedDatePicker.SelectedDate.ToString();

			foreach(string st in eventRepo.GetDate())
			{
				while (d.Equals(st))
				{
					CurrentEvent.Document.Blocks.Add(new Paragraph(new Run("hej")));
				}


			}

				//if (d.Equals(s))
				//{
				//	EventRepository = controller.ShowNotConfirmedEvent();
				//	CurrentEvent.Document.Blocks.Clear();

				//	CurrentEvent.Document.Blocks.Add(new Paragraph(new Run("hej")));
				//}
				//else
				//{
				//	CurrentEvent.Document.Blocks.Add(new Paragraph(new Run("hejsa")));
				//}
			
		}

	}
	public class Statistik
    {
        public string Name { get; set; }
        public Int16 Share { get; set; }


    }

    public class StatistikCollection : Collection<Statistik>
    {
        public StatistikCollection()
        {
            Add(new Statistik { Name = "oprydning", Share = 15 });
            Add(new Statistik { Name = "Fest", Share = 15 });
            Add(new Statistik { Name = "Opstilling", Share = 30 });
            Add(new Statistik { Name = "Andet", Share = 30 });


        }

                

    }

}