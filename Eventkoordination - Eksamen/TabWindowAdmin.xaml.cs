using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
        StatistikCollection StatistikCollection1;

        public TabWindowAdmin()
        {
            InitializeComponent();

            StatistikCollection1 = new StatistikCollection();
           
               StatistikCollection1.Add(new Statistik { Name = "Oprydning", Share = 10 });
               StatistikCollection1.Add(new Statistik { Name = "Fest", Share = 35 });
               StatistikCollection1.Add(new Statistik { Name = "Fest", Share = 35 });
               StatistikCollection1.Add(new Statistik { Name = "Opstilling", Share = 10 });
               StatistikCollection1.Add(new Statistik { Name = "Andet", Share = 45 });

            mcChart.DataContext = StatistikCollection1;

        }

        public class Statistik
        {
            public string Name { get; set; }
            public Int16 Share { get; set; }

        }

  

    }

    internal class StatistikCollection
    {
        internal void Add(TabWindowAdmin.Statistik statistik)
        {
            throw new NotImplementedException();
        }
    }
}