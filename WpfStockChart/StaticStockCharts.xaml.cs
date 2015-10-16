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

namespace WpfStockChart
{
    /// <summary>
    /// Interaction logic for StaticStockCharts.xaml
    /// </summary>
    public partial class StaticStockCharts : Window
    {
        private ChartStyle cs;
        private DataCollection dc;
        private DataSeries ds;
        private TextFileReader tfr;
        public StaticStockCharts()
        {
            InitializeComponent();
        }
    }
}
