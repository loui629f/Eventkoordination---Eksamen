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
using System.IO;
using System.Windows.Forms;



namespace UI
{
    /// <summary>
    /// Interaction logic for TabWindowAdmin.xaml
    /// </summary>
    public partial class TabWindowAdmin : Window
    {



        public TabWindowAdmin()
        {
            InitializeComponent();

            /*string test = "test";
            Newsfeed1.Resources.Source = null;
            // Newsfeed1.ClearValue(Newsfeed1.Resources.Clear);
            
            Newsfeed1.AppendText(test);
            */


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

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             
        }


        string GetString(System.Windows.Controls.RichTextBox Newsfeed1)
        {
            var textRange = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
            return textRange.Text;
        }

        private void RefreshBtnClick(object sender, EventArgs e)
        {
            /*TextReader reader = new StreamReader(@"C:\Users\Kasper\Desktop\Eventkoordination---Eksamen\EventLibrary\NewsFeed1TextFile.txt");
            Newsfeed1.
            reader.Close();*/
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            
                    
        }
        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Kasper\\Desktop\\Eventkoordination---Eksamen\\EventLibrary\\NewsFeed1TextFile.txt";
            dlg.Filter = "text file(NewsFeed1TextFile.txt)|NewsFeed1TextFile.txt|All Files (NewsFeed1TextFile.NewsFeed1TextFile)|NewsFeed1TextFile.NewsFeed1TextFile";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadTextDocument(dlg.FileName);
            }
        }
        private void LoadTextDocument(string filename)
        {
            TextRange range;
            FileStream fStream;
            if (File.Exists(filename))
            {
                range = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
                fStream = new FileStream(filename, FileMode.OpenOrCreate);
                range.Load(fStream, System.Windows.DataFormats.Text);
                fStream.Close();
            }
        }*/

        string ConvertRichTextBoxContentToString(System.Windows.Controls.RichTextBox Newsfeed1 )
        { 
            TextRange textRange = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
            return textRange.Text;
        }

        /*private void textbox1(object sender, EventArgs e)
        {
            string a = "";
            string abe = "abe";
            string ble = "ble";
            int frm = 0;
            int to = 10;
            ArrayList arr = new ArrayList();
            for (int i = frm; i <= to; i++)
            {
                a = abe + i + ble;
                arr.Add(a);
            }

            foreach ( string s in arr)
            {
                Newsfeed1.AppendText += s + Environment.NewLine;
            }
        }*/

        /*private void GetNewsfeedText()
        {
            Controller c = new controller();

            List<string> infos = c.GetTextBoxDataFromDatabase();
        }*/
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