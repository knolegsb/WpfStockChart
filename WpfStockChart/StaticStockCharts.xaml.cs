﻿using System;
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
            dc = new DataCollection();
            tfr = new TextFileReader();
            cs = new ChartStyle();
        }

        private void chartGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            textCanvas.Width = chartGrid.ActualWidth;
            textCanvas.Height = chartGrid.ActualHeight;
            chartCanvas.Children.Clear();
            textCanvas.Children.RemoveRange(1, textCanvas.Children.Count - 1);

            AddChart();
        }

        private void AddChart()
        {
            if (dc.DataList.Count > 0)
            {
                cs = new ChartStyle();
                cs.ChartCanvas = chartCanvas;
                cs.TextCanvas = textCanvas;
                cs.Xmin = -1;
                cs.Xmax = ds.DataString.GetLength(1);
                cs.XTick = 3;
                cs.Ymin = double.Parse(txYmin.Text);
                cs.Ymax = double.Parse(txYmax.Text);
                cs.YTick = double.Parse(txYTick.Text);
                cs.Title = "Stock Chart";
                cs.AddChartStyle(tbTitle, tbXLabel, tbYLabel, ds);
                dc.StockChartType = DataCollection.StockChartTypeEnum.HiLo;
                dc.AddStockChart(cs);
            }
        }

        private void LoadFile_Click(object sender, RoutedEventArgs e)
        {
            dc.DataList.Clear();

            ds = new DataSeries();
            ds.DataString = tfr.LoadFile();
            ds.LineColor = Brushes.DarkBlue;
            ds.FillColor = Brushes.DarkBlue;
            dc.DataList.Add(ds);
            AddChart();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
