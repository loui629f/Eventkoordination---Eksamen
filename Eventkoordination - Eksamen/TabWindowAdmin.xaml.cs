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

        /*private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string destination = Environment.CurrentDirectory;
            for (int i = 0; i < 3; i++)
            {
                destination = Directory.GetParent(destination).ToString();
            }
            string loc;
            loc = destination + "/EventLibrary/NewsFeed1TextFile.txt";
            //string loc = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "");
            //loc += "\\..\\EventLibrary\\NewsFeed1TextFile.txt";
            using (StreamReader sr = new StreamReader(File.OpenRead(loc)))
            {
                TextRange textRange = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
                textRange.Text = sr.ReadToEnd();
            }
        }*/

        private void Newsfeed1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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






    //trash code:


/*string GetString(System.Windows.Controls.RichTextBox Newsfeed1)
{
    var textRange = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
    return textRange.Text;
}*/

/*string destination = Environment.CurrentDirectory;

        destination = Directory.GetParent(destination).ToString();
        string loc;
        loc = destination + "/EvenLibrary/" + fileName;
        using (FileStream str = File.OpenRead(loc))
        {
            using (StreamReader sr = new StreamReader(str))
            {

            }
        }*/

/*static void FilePath(string fileName)
{
    string destination = Environment.CurrentDirectory;

    destination = Directory.GetParent(destination).ToString();
    string loc;
    string resultout = "";
    loc = destination + "/EvenLibrary/" + fileName;
    using (FileStream str = File.OpenRead(loc))
    {
        using (StreamReader sr = new StreamReader(str))
        {
            resultout = sr.ReadToEnd();
        }
    }
}*/
/*private void RefreshBtnClick(object sender, EventArgs e)
{
    string strfilename = openFileDialog1.FileName;
    string filetext = File.ReadAllText(strfilename);
    TextRange richText = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
    richText.Text = ;

    Stream myStream;
    OpenFileDialog openFileDialog1 = new OpenFileDialog();

    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
    {
        if ((myStream = openFileDialog1.OpenFile()) != null)
        {

            string strfilename = openFileDialog1.FileName;
            string filetext = File.ReadAllText(strfilename);
            var richText = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
            richText.Text = filetext;

        }
    }
} */

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

/*string ConvertRichTextBoxContentToString(System.Windows.Controls.RichTextBox Newsfeed1)
{
    TextRange textRange = new TextRange(Newsfeed1.Document.ContentStart, Newsfeed1.Document.ContentEnd);
    return textRange.Text;
}*/
